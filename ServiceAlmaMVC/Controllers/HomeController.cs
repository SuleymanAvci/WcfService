using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace ServiceAlmaMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            using (KurServis.KurServiceClient servisClient = new KurServis.KurServiceClient())
            {
                if (TempData["Kurlar"] != null)
                {
                    ViewBag.Kurlar = (List<double>)TempData["Kurlar"];
                }
                else
                {
                    ViewBag.Kurlar=new List<double>();
                }
                var model = servisClient.ParaBirimleriGetir();
                return View(model);
            }
        }

        public ActionResult KurGetir(string paraBirimi)
        {
            using (KurServis.KurServiceClient servisClient = new KurServis.KurServiceClient())
            {
                var model = servisClient.KurlarGetir(paraBirimi).ToList();
                TempData["Kurlar"] = model;
                return RedirectToAction("Index");
            }
        }
    }
}