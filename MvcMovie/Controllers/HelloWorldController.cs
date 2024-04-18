using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    [Route("HelloWorld")]
    public class HelloWorldController : Controller
    {
        [HttpGet("Index")]
        public string Index()
        {
            return "Acción por defecto...";
        }

        [HttpGet("Welcome/{name}")]
        public string Welcome(string name, int id = 1)
        {
            var encoder = HtmlEncoder.Default;
            return encoder.Encode($"Hello {name}, ID: {id}");
        }
    }
}
