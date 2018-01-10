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
        static private UniversitiesTreeContext treeDb = new UniversitiesTreeContext();
        // GET: UniversityTree
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetRoot()
        {
            List<UniversityNode> items = GetTree();

            return new JsonResult { Data = items, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public JsonResult GetChildren(string id)
        {
            List<UniversityNode> items = GetTree(id);

            return new JsonResult { Data = items, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        static List<UniversityNode> GetTree()
        {
            var items = new List<UniversityNode>();
            items = treeDb.UniversityNodes.Where(uni => uni.parentId == "#").ToList();
            return items;
        }

        static List<UniversityNode> GetTree(string id)
        {
            var items = new List<UniversityNode>();
            items = treeDb.UniversityNodes.Where(uni => uni.parentId == id).ToList();
            return items;
        }
    }
}