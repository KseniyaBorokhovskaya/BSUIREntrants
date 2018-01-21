using BSUIREntrantsWebSite.Concrete;
using BSUIREntrantsWebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BSUIREntrantsWebSite.Controllers
{
    public class UniversityTreeController : Controller
    {
        static private UniversityContext treeDb = new UniversityContext();
        // GET: UniversityTree
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetRoot()
        {
            var items = treeDb.Nodes.Where(el => el.ParentId == "#").Select(element => new
            {
                id = element.Id,
                text = element.Data.Text + "(" + element.TypeAndDepth + ")",
                children = element.Children
            }).ToList();

            return new JsonResult { Data = items, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public JsonResult GetChildren(string id)
        {
            var items = treeDb.Nodes.Where(el => el.ParentId == id).Select(element => new
            {
                id = element.Id,
                text = element.Data.Text + "(" + element.TypeAndDepth + ")",
                children = element.Children
            }).ToList();

            return new JsonResult { Data = items, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        [HttpPost]
        public int GetAmountOfStudents(string[] ids)
        {
            int amountOfStudent = 0;
            foreach(string id in ids)
            {
                amountOfStudent += treeDb.Entranst.Where(enrolle => enrolle.ApplyInfoId == id).Count();
            }
            return amountOfStudent;
        }
    }
}