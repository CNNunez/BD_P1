//
//    This is the pages Controller for:
//        - Index view (also Home view).
//        - Cuentas view.
//        - Result view.
//


using System.Web.Mvc;
using System.Diagnostics;
using BD_Proyecto1.Models;

namespace BD_Proyecto1.Controllers
{
    public class HomeController : Controller
    {
        // ... to see index view
        public ActionResult Index()
        {
            return View();
        }

        // ... to see Cuentas view
        public ActionResult Cuentas()
        {
            Debug.WriteLine("Cuentas page");
            CuentasModel myModel = new CuentasModel();
            return View(myModel);
        }

        // ... to see Login view
        public ActionResult Login()
        {
            CuentasModel myModel = new CuentasModel();
            return View(myModel);
        }

        // ... to see Usuario view
        public ActionResult Usuario()
        {
            return View();
        }

        // ... to see Edit view
        public ActionResult Edit()
        {
            return View();
        }

        // ... to see Challenge view with the result
        public ActionResult Get_String()
        {
            Debug.WriteLine("Get_String()");
            CuentasModel myModel = new CuentasModel();
            Debug.WriteLine(myModel.Get_Result());
            return View("Cuentas", myModel);
        }
    }
}