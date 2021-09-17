//
//    This is the pages Controller for:
//        - Index view (also Home view).
//        - Challenge view.
//        - Result view.
//


using System.Web.Mvc;
using System.Diagnostics;
using BD_P1.Models;

namespace BD_P1.Controllers
{
    public class HomeController : Controller
    {

        // ... to see index view
        public ActionResult Index()
        {
            return View();
        }

        // ... to see Challenge view
        public ActionResult Challenge()
        {
            Debug.WriteLine("Challenge page");
            ChallengeModel myModel = new ChallengeModel();
            return View(myModel);
        }

        // ... to see Challenge view with the result
        public ActionResult Get_String()
        {
            Debug.WriteLine("Get_String()");
            ChallengeModel myModel = new ChallengeModel();
            Debug.WriteLine(myModel.Get_Result());
            return View("Challenge", myModel);
        }
    }
}