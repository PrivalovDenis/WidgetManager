using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WidgetManager.Controllers
{
    #region Controller
    public class HomeController : Controller
    {
        #region Crud

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Widget()
        {
            ViewBag.Title = "List Of Employees";
            var positions = new List<string> { "Team Leader", "Project Manager", "Software Developer", "Senior Engineer", "Architect", "Network Administrator" };

            var response = new List<Employe>();
            for (int i = 0; i <= 100; i++)
            {
                response.Add(new Employe { Id = i, Name = "UserName " + i, LastName = "LastName " + i, Position = positions.OrderBy(x => Guid.NewGuid()).FirstOrDefault() });
            }

            return View(response as List<Employe>);
        }

        #endregion
    }
    #endregion

    #region Helper Classes
    public class Employe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
    }
    #endregion
}