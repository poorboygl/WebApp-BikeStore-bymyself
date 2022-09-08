using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(SiteProvider provider) : base(provider)
        {

        }
        public IActionResult Search(string q)
        {
            ViewBag.categories = provider.Category.GetCategories();
            return View(provider.Product.SearchProducts(q));
        }
        [Route("/home/category/{id}/{p?}")]
        public IActionResult Category(short id = 1, int p = 1)
        {
            Console.WriteLine(p);
            ViewBag.categories = provider.Category.GetCategories();
            int size = 10;
            int total;
            IEnumerable<Product> list = provider.Product.GetProductsByCategory(id, p, size, out total);
            ViewBag.total = total;
            return View(list);
        }
        public IActionResult List()
        {
            IEnumerable<Category> list = provider.Category.GetCategories();
            Dictionary<short, List<Product>> dict = provider.Product.keyValuePairs();
            foreach (Category item in list)
            {
                if (dict.ContainsKey(item.CategoryID))
                {
                    item.Products = dict[item.CategoryID];
                }
            }
            return View(list);
        }
        public IActionResult Index(int id = 1)
        {
            //ViewBag.Welcome = "Xin CHao <b>THanh</b>";
            //ViewBag.categories = provider.Category.GetCategories();
            ViewBag.categories = provider.Category.GetCategories();
            int size = 10;
            int total;
            IEnumerable<Product> list = provider.Product.GetProducts((id - 1) * size, size, out total);
            ViewBag.n = (total - 1) / size + 1;
            ViewBag.total = total;
            return View(list);
        }
        public IActionResult Category(short id)
        {
            ViewBag.categories = provider.Category.GetCategories();
            return View("Index", provider.Product.GetProductsByCategory(id));
        }
        public IActionResult Detail(int id)
        {
            ViewBag.categories = provider.Category.GetCategories();
            Product obj = provider.Product.GetProduct(id);
            ViewBag.relations = provider.Product.GetProductsRelation(obj.CategoryId, id);
            return View(obj);
        }

    }
}
