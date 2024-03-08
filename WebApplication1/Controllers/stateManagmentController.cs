using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace WebApplication1.Controllers
{
    public class stateManagmentController : Controller
    {

        public IActionResult setSession()
        {
            HttpContext.Session.SetString("name", "ahmed"); 
            HttpContext.Session.SetInt32("age", 21);
            return Content("Session Data saved"); 

        }
        
        public IActionResult getSessionData()
        {
            string name = HttpContext.Session.GetString("name");
            int age = HttpContext.Session.GetInt32("age").Value; // its allaw nulls so use .value or ?
            return Content($"data name = {name} age = {age}"); 
        }
        public IActionResult SetTempData()
        {
            TempData["msg"] = "hi iam temp data";
            return Content("Data Saved");
        }

        public IActionResult GetTempData()
        {
            string message = TempData.Peek("msg").ToString(); 
            return Content("The get data is " + message);
        }
    }
}
