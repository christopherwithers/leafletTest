using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PcAvailabilityTest.Controllers
{
    public class MapsController : Controller
    {
        // GET: Maps
        public ActionResult Leaflet()
        {
            return View();
        }

        public ActionResult LeafletCluster()
        {
            return View();
        }
    }
}