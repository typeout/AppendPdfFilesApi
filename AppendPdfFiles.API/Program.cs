using System.Reflection;
using AppendPdfFiles.API.Brokers;
using AppendPdfFiles.API.Services;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IPdfBroker, PdfBroker>();
builder.Services.AddScoped<IAppendPdfFilesService, AppendPdfFilesService>();

AddSwaggerGen(builder);

var app = builder.Build();

app.UseSwagger(options =>
{
    options.SerializeAsV2 = true;
    options.RouteTemplate = "swagger/{documentName}/swagger.json";
    options.PreSerializeFilters.Add(
        (swaggerDoc, httpReq) =>
        {
            swaggerDoc.Servers = new List<OpenApiServer>
            {
                new OpenApiServer { Url = $"{httpReq.Scheme}://{httpReq.Host.Value}" }
            };
        }
    );
});
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();

static void AddSwaggerGen(WebApplicationBuilder builder)
{
    builder.Services.AddSwaggerGen(options =>
    {
        options.SwaggerDoc(
            "v1",
            new OpenApiInfo
            {
                Version = "v1",
                Title = "Append PDF Files API",
                Description = "An ASP.NET Core Web Append PDF Files API"
            }
        );

        var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
        options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
    });
}
