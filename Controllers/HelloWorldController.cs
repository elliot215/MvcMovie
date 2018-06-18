using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
  public class HelloWorldController : Controller
  {
    //
    // GET: HelloWorld/

    public string Index()
    {
      return "this is my default action...";
    }

    //
    // GET: HelloWorld/Welcome/
    public string Welcome()
    {
      return "this is the welcome action...";
    }
  }
}