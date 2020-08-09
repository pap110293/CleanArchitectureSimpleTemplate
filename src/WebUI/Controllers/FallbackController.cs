using System;
using System.IO;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore.WebUI.Controllers
{
    public class FallbackController : Controller
    {
        public IActionResult Index()
        {
            return PhysicalFile(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/dist", "index.html"), "text/HTML");
        }
    }
}
