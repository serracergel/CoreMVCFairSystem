using CoreMVCFairSystem.Models.Entities;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddIdentity<AppUser,AppRole>(x=>
{
    x.Password.RequiredLength = 5;
    x.Password.RequireDigit=true;
    x.Password.RequireLowercase=true;
    x.Password.RequireUppercase=true;
    x.Password.RequireNonAlphanumeric=true;
    x.Lockout.MaxFailedAccessAttempts = 5;
    x.SignIn.RequireConfirmedPhoneNumber=true;
    //sign in icin phonenumberi signin actioninda mi yapicam
});
//todo:middleware'e identity tanimlamasi yapildi middlewarede eksikler tammalanip migrate edilcek

WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
