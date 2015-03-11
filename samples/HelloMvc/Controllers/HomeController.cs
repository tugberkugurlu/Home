using Microsoft.AspNet.Mvc;
using MvcSample.Web.Models;

namespace MvcSample.Web
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(CreateUser());
        }

        public User CreateUser()
        {
			var hasCtx = System.Threading.SynchronizationContext.Current == null;
			
            User user = new User()
            {
                Name = $"My name ({hasCtx})",
                Address = "My address"
            };

            return user;
        }
    }
}