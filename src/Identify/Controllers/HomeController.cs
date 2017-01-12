using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Authentication;


namespace Identify.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        public ViewResult Index() =>
            View(new Dictionary<string, object>
            { ["Placeholder"] = "Placeholder" });
    }
}