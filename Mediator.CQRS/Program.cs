using huzcodes.Extensions.Exceptions;
using Mediator.CQRS.Application;
using Mediator.CQRS.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddServicesRegistrations();
builder.Services.AddApplicationRegistrations();



var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();

app.AddExceptionHandlerExtension();

app.UseAuthorization();

app.MapControllers();

app.Run();
