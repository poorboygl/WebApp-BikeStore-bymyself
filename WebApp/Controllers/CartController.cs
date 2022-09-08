using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class CartController : BaseController
    {
        public CartController(SiteProvider provider) : base(provider)
        {

        }
        public IActionResult Index()
        {
            if (Request.Cookies["cartID"] != null)
            {
                Guid cartID = Guid.Parse(Request.Cookies["cartID"]);
                IEnumerable<Cart> list = provider.Cart.GetCarts(cartID);
                return View(list);
            }
            return Redirect("/");
        }
        public IActionResult Districts(string id)
        {
            return Json(provider.District.GetDistricts(id));
        }
        public IActionResult Wards(string id)
        {
            return Json(provider.Ward.GetWards(id));
        }
        [Authorize]
        public IActionResult CheckOut()
        {
            ViewBag.provinces = new SelectList(provider.Provinces.GetProvinces(), "ProvinceID", "ProvinceName");
            return View();
        }
        [HttpPost]
        public IActionResult CheckOut(Invoice obj)
        {
            if (Request.Cookies["cartID"] != null)
            {
                obj.InvoiceID = obj.CartID = Guid.Parse(Request.Cookies["cartid"]);
                obj.AccountID = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
                provider.Invoice.Add(obj);
                //xoa cookie cart
                Response.Cookies.Delete("cartID", new CookieOptions { Path = "/" });
                return Redirect($"/invoice/detail/{obj.CartID}");
            }
            return Redirect("/");
        }
        public IActionResult Delete(int id)
        {
            if (Request.Cookies["cartID"] != null)
            {
                Guid cardID = Guid.Parse(Request.Cookies["cartID"]);
                provider.Cart.Delete(cardID, id);
            }
            return Redirect("/cart");
        }
        [HttpPost]
        public IActionResult Add(Cart obj)
        {
            //if (Helper.CartID is null)
            //{
            //    Helper.CartID = Guid.NewGuid();
            //}
            ////obj.CartID = Guid.NewGuid();
            //obj.CartID = Helper.CartID.Value;
            if (Request.Cookies["cartID"] is null)
            {
                CookieOptions option = new CookieOptions
                {
                    Path = "/",
                    Expires = DateTime.UtcNow.AddDays(30)
                };
                obj.CartID = Guid.NewGuid();
                Response.Cookies.Append("cartID", obj.CartID.ToString(), option);
            }
            else
            {
                obj.CartID = Guid.Parse(Request.Cookies["cartID"]);
            }

            provider.Cart.Add(obj);
            return Redirect("/cart");
        }
        public IActionResult Edit(Cart obj)
        {

            if (Request.Cookies["cartID"] != null)
            {

                obj.CartID = Guid.Parse(Request.Cookies["cartID"]);
                return Json(provider.Cart.Update(obj));
            }
            return Json(-1);
        }
    }
}
