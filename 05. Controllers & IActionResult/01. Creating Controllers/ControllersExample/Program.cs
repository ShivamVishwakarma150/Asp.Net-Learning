using ControllersExample.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Service class is a reusable class a class which performs a specific functionality  without having direct relationship with UI
// COntrollers must also be treated as services
// builder.Services.AddTransient<HomeController>(); we can addlike this also but more shortcut way is given below
builder.Services.AddControllers(); //adds all the controller classes as services

var app = builder.Build();
app.UseRouting();
// We can use it aslo
/*app.UseEndpoints(endpints =>
{
    endpints.Map("url1",...)
})*/
// but it will more easy way
app.MapControllers(); // enables routing for each action method
app.Run();
