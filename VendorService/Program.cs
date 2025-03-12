using InventoryService.Repositories;
using Microsoft.EntityFrameworkCore;
using VendorService.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<VendorDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("InventoryDatabase")));

builder.Services.AddScoped<ProductRepository>();

var app = builder.Build();

app.Run();