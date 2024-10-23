using DITraining.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace DITraining.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAddValueService _service;
        public HomeController(IAddValueService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
           int x= _service.Tehran(1000);
            return Content(x.ToString());
        }
    }
}
