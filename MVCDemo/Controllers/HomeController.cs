using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.IISServiceReference;


namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
	        using (var client = new CalculatorServiceClient())
	        {
		        return client.Add(3, 5).ToString();

	        }
	        return "Error";
        }
    }
}