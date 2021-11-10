using Microsoft.AspNetCore.Mvc;
using NewPortfolioUpdate.Models;
using NewPortfolioUpdate.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewPortfolioUpdate.Controllers
{
    public class InfoDisplayController : Controller
    {
        public IActionResult Index()//url will be .../product or product/index
        {
            //  List<PageDisplayModel> displayList = new List<PageDisplayModel>();
            // displayList.Add(new PageDisplayModel { Id = 1, Name = "Joey", Date = new DateTime(2008, 4, 10, 6, 30, 0), Description = "Appointment for something" });
            // displayList.Add(new PageDisplayModel { Id = 2, Name = "Joe boogy", Date = new DateTime(2021, 4, 1, 8, 30, 0), Description = "Appointment for something new" });
            // displayList.Add(new PageDisplayModel { Id = 3, Name = "Zoe", Date = new DateTime(2023, 3, 12, 5, 30, 0), Description = "Appointment for disapointment" });
            HardCodedSampleDataRepos hardCodedSampleDataRepos = new HardCodedSampleDataRepos();
            return View(hardCodedSampleDataRepos.GetAllData());//returns page from views>Product>Index with the list.   View was created by right clicking add view Razor View. then choose[list]. and [product model] check partial view
        }
        public IActionResult Welcome()
        {
            WelcomeDataRepos welcomeDataRepos = new WelcomeDataRepos();
            return View(welcomeDataRepos.GetAllData());
        }
        
  public IActionResult Shop()

        {
            ShopDAO products = new ShopDAO();
            return View(products.GetAllProducts());
        }

        public IActionResult AI()
        {
            return View ();
        }
        public IActionResult ShowDetails(int Id)
        {
            ShopDAO products = new ShopDAO();
            shopModel foundProduct = products.GetProductById(Id);
            return View(foundProduct);
        
        }
        public IActionResult Edit(int id)
        {
            ShopDAO products = new ShopDAO();
            shopModel foundProduct = products.GetProductById(id);

            return View("ShowEdit", foundProduct);
        }
        public IActionResult ProcessEdit(shopModel product)
        {
            ShopDAO products = new ShopDAO();
            products.Update(product);

            return View("Shop", products.GetAllProducts());
        }
        public IActionResult Delete(int id)
        {
            ShopDAO products = new ShopDAO();
            shopModel product = products.GetProductById(id);
            products.Delete(product);
            return View("Shop", products.GetAllProducts());

        }
        public IActionResult InputForm(int id)
        {
            ShopDAO products = new ShopDAO();
            shopModel foundProduct = products.GetProductById(id);

            return View();
        }
        public IActionResult ProcessCreate(shopModel product)
        {
            ShopDAO products = new ShopDAO();
            products.Insert(product);
            // products.Insert(product);
            // ProductsDAO products = new ProductsDAO();
            shopModel foundProduct = products.GetProductById(product.Id);

            return View("Added", foundProduct);
            // return View("Index", products.GetAllProducts());
        }
    }
}
