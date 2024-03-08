using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DepartmentController : Controller
    {
        ITIEntity entity = new ITIEntity(); // one object for all actions
        public IActionResult Index()
        {
            // get all department 
            // mn hena w rai7 we will name the view with the same name of the action
            List<Department> DeplistModel = entity.Departments.Include(d=>d.Employees).ToList();
            // .Include() --> get the department wiht all of its employees from the data base 
            //return View("Index",DeplistModel);
            return View(DeplistModel);  // he will go and search for view with the same name as the action
            //return View("Index") // view = index , model = null 
        }
    }
}
