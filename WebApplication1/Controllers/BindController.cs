using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

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

        // Bind Custom /Complex type 
        public IActionResult testComplex([Bind(include:"Id,Name")]Department dep) // here you will send the types in the complex type only
        {
            return Content($"Name = {dep.Name} \n ID = {dep.Id} \n Manager Name = {dep.ManagerName}");
        }
    }
} 
