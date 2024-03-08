using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class BindController : Controller
    {
        // Model biding : Map action parameters wiht erquest data (FormData - Query String - RouteData)
        // bind premitive type 
        public IActionResult testPrimitive(int id , string name)
        {
            return Content($"Name {name} id {id}");
        }

        // Bind on collection 
        public IActionResult testdic(Dictionary<string,int>phones, string name)
        {
            return Content($"Name = {name} , Phone Number is = {phones[name]}");
        }
    }
} 
