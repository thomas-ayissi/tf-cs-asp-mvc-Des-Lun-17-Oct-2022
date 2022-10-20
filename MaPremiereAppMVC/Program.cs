var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name:"erreur-slides",
    pattern: "Home/17",
    defaults : new { Controller = "Home", Action = "Index"}
    );

app.MapControllerRoute(
    name:"Monsite",
    pattern: "Monsite/{action=Index}",
    defaults : new { Controller = "Home" }
    );

app.MapControllerRoute(
    name:"no-prefix",
    pattern: "{action=Index}",
    defaults : new { Controller = "Home" }
    );

app.MapControllerRoute(
    name:"contrat",
    pattern:"Contrat-de-confidentialite",
    defaults : new { Controller = "Home", Action = "Privacy" }
    );

//app.MapControllerRoute(
//    name: "carre",
//    pattern: "Math/{nombre}/auCarre",
//    defaults: new { Controller = "Math", Action = "Carre" });

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
