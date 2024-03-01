using BasicTaxApp.Data;
using BasicTaxApp.Extentions;
using BasicTaxApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BasicTaxApp.Controllers
{
    
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<List<Product>>  inputList = new List<List<Product>>().ToList();
            var input1 = Input1SampleData.getInput1().ToList();
            var input2 = Input2SampleData.getInput2().ToList();
            var input3 = Input3SampleData.getInput3().ToList();
            inputList.Add(input1);
            inputList.Add(input2);
            inputList.Add(input3);
            return View(inputList);
        }

        
        public IActionResult Input1() 
        {
            decimal tax = 0;
           var products = Input1SampleData.getInput1().ToList();
           foreach(var product in products)
            {
               tax += product.CalculateTax(); ;
            }
           
          return View("Reciept",products);
        }

        public IActionResult Input2()
        {
            decimal tax = 0;
            var products = Input2SampleData.getInput2().ToList();
            foreach (var product in products)
            {
                tax += product.CalculateTax(); ;
            }

            return View("Reciept", products);
        }
        public IActionResult Input3()
        {
            decimal tax = 0;
            var products = Input3SampleData.getInput3().ToList();
            foreach (var product in products)
            {
                tax += product.CalculateTax(); ;
            }

            return View("Reciept", products);
        }
    }
}
