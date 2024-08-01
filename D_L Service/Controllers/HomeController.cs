using D_L_Service.Models;
using D_L_Service.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text;

namespace D_L_Service.Controllers
{
    public class HomeController : Controller
    {

        private IScopedGuid _scope1;
        private IScopedGuid _scope2;
        private ITransientGuid _transient1;
        private ITransientGuid _transient2;
        private ISingletonGuid _singleton1;
        private ISingletonGuid _singleton2;

        public HomeController(ISingletonGuid singleton1,ISingletonGuid singleton2,
            ITransientGuid transient1,ITransientGuid transient2,
            IScopedGuid scope1, IScopedGuid scope2)
        {
            _singleton1 = singleton1;
            _singleton2 = singleton2;
            _transient1 = transient1;
            _transient2 = transient2;
            _scope1 = scope1;
            _scope2 = scope2;
            
        }

        public IActionResult Index()
        {
           StringBuilder message = new StringBuilder();
            message.Append($"Transient 1 : {_transient1.GetGuid()} \n");
            message.Append($"Transient 2 : {_transient2.GetGuid()} \n\n");
            message.Append($"Scope 1 : { _scope1.GetGuid()} \n");
            message.Append($"Scope 2 : {_scope2.GetGuid()} \n\n");
            message.Append($"Singleton 1 : {_singleton1.GetGuid()} \n");
            message.Append($"Singleton 2 : {_singleton2.GetGuid()} \n\n");
            return Ok(message.ToString());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
