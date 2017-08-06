using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;


using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var developer = GetDeveloper();
            var allSeniority = GetAllSeniority();

            ViewData["AllSeniority"] = allSeniority;

            return View("Index", developer);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult EditingCustom_Update([DataSourceRequest] DataSourceRequest request,
            [Bind(Prefix = "models")]IEnumerable<Skill> products)
        {
            //if (products != null && ModelState.IsValid)
            //{
            //    foreach (var product in products)
            //    {
            //        productService.Update(product);
            //    }
            //}

            return Json(products.ToDataSourceResult(request, ModelState));
        }

        [HttpPost]
        public ActionResult Save(Developer developer)
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        #region Get data

        private Developer GetDeveloper()
        {
            var developer = new Developer()
            {
                Id = 1,
                Age = 28,
                Name = "John Doe",
                AllSkill = GetAllSkill()
            };

            return developer;
        }

        private List<Skill> GetAllSkill()
        {
            var skillCSharp = new Skill()
            {
                Id = 1,
                Description = "C#",
                Enabled = true,
                SeniorityId = 1
            };

            var skillNodeJs = new Skill()
            {
                Id = 2,
                Description = "Node js",
                Enabled = true,
                SeniorityId = 1
            };

            var skillJQuery = new Skill()
            {
                Id = 3,
                Description = "jQuery",
                Enabled = true,
                SeniorityId = 1
            };

            var skillNHibernate = new Skill()
            {
                Id = 4,
                Description = "nHibernate",
                Enabled = false,
                SeniorityId = 1
            };

            var skillEntityFramework = new Skill()
            {
                Id = 5,
                Description = "Entity framework",
                Enabled = false,
                SeniorityId = 1
            };

            var allSkill = new List<Skill>
            {
                skillCSharp,
                skillNodeJs,
                skillJQuery,
                skillNHibernate,
                skillEntityFramework
            };

            return allSkill;
        }

        private List<Seniority> GetAllSeniority()
        {
            var allSeniority = new List<Seniority>();
            allSeniority.Add(new Seniority() { Id = 1, Description = "Junior", Enabled = true });
            allSeniority.Add(new Seniority() { Id = 2, Description = "Semi Sr", Enabled = true });
            allSeniority.Add(new Seniority() { Id = 3, Description = "Senior", Enabled = true });

            return allSeniority;
        }

        public ActionResult ReadSkills([DataSourceRequest] DataSourceRequest request, Developer developer)
        {
            // clientData.Data = 1
            return View("Index", developer);
        }

        #endregion Get data
    }
}