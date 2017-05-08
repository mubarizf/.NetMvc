using System;
using System.Web.Mvc;


namespace YourProjetName.Controllers
{
    public class ErrorPageController : Controller
    {
        // GET: ErrorPage
        [HttpGet]
        public ActionResult Error(int statusCode, Exception exception)
        {
			
			// You can call your own logging method here if you want
			
            Response.StatusCode = statusCode;
            ViewBag.StatusCode = statusCode + " Error";
            return View();
        }
    }
}