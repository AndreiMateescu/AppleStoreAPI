using Microsoft.EntityFrameworkCore;
using Subscriptions.Data;
using Subscriptions.Helpers;
using Subscriptions.Interfaces;
using Subscriptions.Services;

var builder = WebApplication.CreateBuilder(args);

var file = Path.Combine(Directory.GetCurrentDirectory(), ".env");
DotEnv.Load(file);
builder.Configuration.AddEnvironmentVariables();

// Add services to the container.
builder.Services.AddDbContext<DataContext>(options => options.UseMySql(builder.Configuration.GetConnectionString("MySQL"), ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("MySQL"))));
builder.Services.AddScoped<INotificationRepository, NotificationRepository>();
builder.Services.AddScoped<INotificationProcessor, NotificationProcessor>();
builder.Services.AddScoped<ISubscriptionService, SubscriptionService>();
builder.Services.AddScoped<IAppleStoreTokenService, AppleStoreTokenService>();

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

app.UseAuthorization();

app.MapControllers();

app.Run();
