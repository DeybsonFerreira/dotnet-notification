using dotnet_notification.Interfaces;
using dotnet_notification.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//injeção de dependencia
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<INotification, NotificationService>();
var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
