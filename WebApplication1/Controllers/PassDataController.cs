using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModel;

namespace WebApplication1.Controllers
{
    public class PassDataController : Controller
    {
        //Passdata/testviewdata/id
        ITIEntity entity = new ITIEntity();
        public IActionResult testviewdata(int id)
        {
            Employee empModel = entity.Employees.FirstOrDefault(e=>e.Id==id);

            //extra info to send to view
            string msg = "Hello"; 

            List<string> branches =new List<string>();
            branches.Add("assuit");
            branches.Add("ALex");
            branches.Add("Smart");
            branches.Add("Sohag");
            branches.Add("Menia");

            int temp = 44; 

            string color = "red";
            //using viewData
            //ViewData["Message"] = msg;

            //using viewbag
            ViewBag.Message = msg; 
            ViewData["Temp"] = temp;
            ViewData["brch"] = branches;
            ViewData["Color"] = color;
            ViewData["lala"] = "lala";

            return View(empModel);
        }


        // using ViewModel
        public IActionResult testviewModel(int id)
        {
            Employee empModel = entity.Employees.FirstOrDefault(e => e.Id == id);

            //extra info to send to view
            string msg = "Hello";

            List<string> branches = new List<string>();
            branches.Add("assuit");
            branches.Add("ALex");
            branches.Add("Smart");
            branches.Add("Sohag");
            branches.Add("Menia");

            int temp = 44;

            string color = "red";
            //using viewData
            //ViewData["Message"] = msg;

            //using viewbag
            ViewData["lala"] = "lala";
            ViewBag.Message = msg;
            ViewData["Temp"] = temp;
            ViewData["brch"] = branches;
            ViewData["Color"] = color;

            // Delcare ViewModel
            Employee_Message_BranchesList_ViweModel empViewModel = new Employee_Message_BranchesList_ViweModel();
            // get data from Model set viewModel
            empViewModel.Messagae = msg;
            empViewModel.Temp = temp; 
            empViewModel.Color = color;
            empViewModel.Branches = branches;
            empViewModel.EmpName = empModel.Name; 
            empViewModel.EmpID = empModel.Id;

            return View(empViewModel);
        }
    }
}
