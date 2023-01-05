using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerUI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1.0",
        Title = "Gaziantep Metropolitian Municipility Opendata Api Service",
        Description = "It is an API webservice provider that shares live data under the umbrella of open data.",
        TermsOfService = new Uri("https://gaziantep.bel.tr"),
        Contact = new OpenApiContact
        {
            Name = "Example Contact",
            Url = new Uri("https://akillikent.gaziantep.bel.tr/"),
            Email = "akillikent@gaziantep.bel.tr"
        },
        License = new OpenApiLicense
        {
            Name = "Example License",
            Url = new Uri("https://gaziantep.bel.tr")
        }
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
/*if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}*/
app.UseSwagger(options =>
{
    options.SerializeAsV2 = true;
});

app.UseSwaggerUI(option =>
{
    option.DocumentTitle = "Opendata Api Service";
    option.InjectStylesheet("/swagger-ui/SwaggerDark.css");
});


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
