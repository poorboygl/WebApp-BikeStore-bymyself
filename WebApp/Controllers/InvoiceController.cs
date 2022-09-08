using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class InvoiceController : BaseController
    {
        public InvoiceController(SiteProvider provider) : base(provider)
        {

        }
        public IActionResult Detail(Guid id)
        {
            Invoice obj = provider.Invoice.GetInvoicebyID(id);
            obj.InvoiceDetails = provider.InvoiceDetail.GetInvoiceDetailsByInvoice(id);
            return View(obj);
        }
    }
}
