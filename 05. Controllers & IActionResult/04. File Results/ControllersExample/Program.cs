var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers(); //adds all the controller classes as services

var app = builder.Build();
app.UseStaticFiles();// for using static files in our project and it is default set to wwwroot folder
app.UseRouting();
app.MapControllers();
app.Run();
