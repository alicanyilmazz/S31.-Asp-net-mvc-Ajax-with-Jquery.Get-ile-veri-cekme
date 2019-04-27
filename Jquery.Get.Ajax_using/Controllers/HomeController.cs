using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Jquery.Get.Ajax_using.Controllers
{
    public class HomeController : Controller
    {
        private List<string> my_list = new List<string> { "kadir", "murat", "baseren", "kemal", "sunal", "haktan", "yilmaz" }; //Normalde database den cekeceksin biz göstermek amaçlı böyle yaptık!
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult Data_Getter()
        {   
            //veriler database den cekilir.
            System.Threading.Thread.Sleep(3000);

            return PartialView("_DataItemPartial",my_list);
        }
    }
}