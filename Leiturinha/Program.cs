using Leiturinha.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Adicionando o contexto do banco de dados ao contêiner de serviços
string conexao = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(conexao)
);

// Adicione os serviços do Blazor e Razor Pages
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// Se precisar de controllers (API ou MVC)
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure o pipeline HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Se for Blazor Server
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
