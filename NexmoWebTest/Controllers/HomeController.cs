using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NexmoClient;

namespace NexmoWebTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult CallTest(FormCollection form)
        {
            string message = form["Message"].ToString();
            Nexmo nexmo = new Nexmo("95353d58", "faa38cbb");
            nexmo.Phone = "7407390560";
            nexmo.Message = message;
            NexmoCall call = new NexmoCall();
            var response = call.MakeCall(nexmo);
            return View("Success", response);
        }
    }
}