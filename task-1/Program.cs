

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

app.MapControllerRoute("default", "{controller}/{action=index}");
app.MapControllerRoute("default", "{controller}/{action=list}");
app.MapControllerRoute("default", "{controller}/{action=game}");

app.Run();
 