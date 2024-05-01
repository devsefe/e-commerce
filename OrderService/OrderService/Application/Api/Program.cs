using Api.Middlewares;
using DomainModel.Extensions;
using DomainService.Extensions;
using Dto.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.LoadDomainModelExtensions(builder.Configuration);
builder.Services.LoadDomainServiceExtensions();
builder.Services.LoadDtoExtensions();
builder.Services.AddScoped<GlobalExceptionHandlingMiddleware>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.UseMiddleware<GlobalExceptionHandlingMiddleware>();

app.Run();
