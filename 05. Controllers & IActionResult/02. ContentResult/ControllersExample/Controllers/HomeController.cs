using Microsoft.AspNetCore.Mvc;

namespace ControllersExample.Controllers
{
  public class HomeController : Controller
  {
    [Route("home")]
    [Route("/")]
    public ContentResult Index()
    {
            // here Content property contain actual information that you want to return as response which will be added to response body
            // content type automatically added with response headers.
      //return new ContentResult() { Content = "Hello from Index", ContentType = "text/plain" };

       // We can use Predefined method also instead of returing the new object same as above statement
      //return Content("Hello from Index", "text/plain");

      return Content("<h1>Welcome</h1> <h2>Hello from Index</h2>", "text/html");
    }

    [Route("about")]
    public string About()
    {
      return "Hello from About";
    }

    [Route("contact-us/{mobile:regex(^\\d{{10}}$)}")]
    public string Contact()
    {
      return "Hello from Contact";
    }
  }
}
