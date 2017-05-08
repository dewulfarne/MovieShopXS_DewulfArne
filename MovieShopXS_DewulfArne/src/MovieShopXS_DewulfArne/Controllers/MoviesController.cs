using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MovieShopXS_DewulfArne.Controllers
{
    [Route("")]
    [Route("[controller]")]
    public class MovieController : Controller
    {
        [Route("")]
        [Route("[action]")]
        // GET: /<controller>/
        public IActionResult Index()
        {

            return View();
        }

        [Route("[action]/{year?}")]
        public IActionResult Year(int year)
        {
            return View();
        }

        [Route("[action]/{id?}/Rating/{Up?}")]
        public IActionResult Update(int rating, string Up)
        {
            return View();
        }
    }
}
