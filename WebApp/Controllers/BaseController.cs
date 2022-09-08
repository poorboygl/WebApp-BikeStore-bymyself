using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Controllers
{
    public abstract class BaseController : Controller
    {
        protected SiteProvider provider;
        public BaseController(SiteProvider provider)
        {
            this.provider = provider;
        }

    }
}
