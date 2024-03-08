using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductsController : Controller
    {
        //public string ShowMsg()
        //{
        //    return "Hello";
        //}

        //public ContentResult ShowMsg2()
        //{
        //    ContentResult result = new ContentResult();
        //    result.Content = "HI IAM MOHAMED RAMADAN ELARABY";
        //    return result;
        //} 

        //public ViewResult ShowMsg3()
        //{
        //    ViewResult result = new ViewResult();
        //    result.ViewName = "View1";
        //    return result;
        //}

        public ProductsController() { }

        public IActionResult Details(int id)
        {
            ProductsSampleData sampleData = new ProductsSampleData();
            Products p = sampleData.GetById(id);

            return View("ProductsView" , p);
        }

        public IActionResult AllProductsDetails() 
        {
            ProductsSampleData sampleData1 = new ProductsSampleData();
            List<Products> p = sampleData1.GetAll();
            return View("showall", p); 
        }
    }
}
