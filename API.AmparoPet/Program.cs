using API.AmparoPet.Data;
using API.AmparoPet.Repositories;
using API.AmparoPet.Services;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AmparoPetContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AmparoPetContext")));

builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "AmparoPet API", Version = "v1" });
    //c.IncludeXmlComments(System.AppDomain.CurrentDomain.BaseDirectory + @"API.AmparoPet.xml");
});

// Add services to the container.
//builder.Services.AddRazorPages();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// No método ConfigureServices da classe Startup
builder.Services.AddScoped<IAddressService, AddressService>();
builder.Services.AddScoped<IAddressRepository, AddressRepository>();

builder.Services.AddScoped<ICarerService, CarerService>();
builder.Services.AddScoped<ICarerRepository, CarerRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}
else
{
    app.UseDeveloperExceptionPage();
    app.UseMigrationsEndPoint();
}

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<AmparoPetContext>();

    context.Database.Migrate();

    //DbInitializer.Initialize(context);
}

app.UseSwagger();
//app.UseSwaggerUI();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "AmparoPet API V1");
});

app.UseAuthorization();
//app.UseCors();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.MapControllers();

app.UseRouting();

app.Run();
