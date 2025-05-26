using ArtDealer2.Components;
using ArtDealer2.Data;
using ArtDealer2.Repositorio;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();


//conexion

builder.Services.AddDbContext<BDArtDealerContext>(options =>
                      options.UseSqlServer(
                          builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IRepositorioArtistas, RepositorioArtistas>();

builder.Services.AddScoped<IRepositorioObras, RepositorioObras>();

builder.Services.AddScoped<IRepositorioComisiones, RepositorioComisiones>();

//------------

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
