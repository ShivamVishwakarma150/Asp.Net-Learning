using Microsoft.AspNetCore.Mvc;

namespace ControllersExample.Controllers
{
  [Controller] // For Adding this class as Controller class
  public class HomeController // Must be a public class then only it is intantiated with asp.net core internally
  {
    [Route("home")] // Attribute Routing Here "home" is route Template
    [Route("/")] // we can add multiple route for same action method
    public string Index() // In general it is not recommended to return string or other data type
            // we should return IActionResult
    {
      return "Hello from Index";
    }

    [Route("about")]
    public string About()
    {
      return "Hello from About";
    }
    // we can add route constraint as well
    // Like Here we resrict it to 10 digit mobile number only
    [Route("contact-us/{mobile:regex(^\\d{{10}}$)}")]
    public string Contact()
    {
      return "Hello from Contact";
    }
  }
}
