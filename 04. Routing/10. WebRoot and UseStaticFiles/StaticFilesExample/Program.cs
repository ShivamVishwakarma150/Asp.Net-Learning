using Microsoft.Extensions.FileProviders;

// in order to myroot recognize by asp.net 
//we are doing this
// using this options you can configure some of the default settings
// by default WebRootPath can accept one default path not more than one
var builder = WebApplication.CreateBuilder(new WebApplicationOptions() { 
 WebRootPath = "myroot"
});
var app = builder.Build();

app.UseStaticFiles(); //works with the web root path (myroot)

// for configure mywebroot which is one extra folder other than myroot
app.UseStaticFiles(new StaticFileOptions()
{
 FileProvider = new PhysicalFileProvider(
 Path.Combine(builder.Environment.ContentRootPath, "mywebroot")
 )
}); //works with "mywebroot"

//c:\aspnetcore\StaticFilesExample\StaticFilesExample
app.UseRouting();

// for /
app.UseEndpoints(endpoints => {
 endpoints.Map("/", async context =>
 {
  await context.Response.WriteAsync("Hello");
 });
});

app.Run();
