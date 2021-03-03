using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using SkillCard_CodeFirstEntity.Models.Classes;

namespace SkillCard_CodeFirstEntity.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context context = new Context();
        public ActionResult Index()
        {
            Context content = new Context();
            var values = content.Skills.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult NewSkill()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewSkill(Skill y)
        {
            context.Skills.Add(y);
            context.SaveChanges();
            return View();
        }
        public ActionResult DeleteSkill(int id)
        {
            var value = context.Skills.Find(id);
            context.Skills.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult BringSkill(int id)
        {
            var value = context.Skills.Find(id);

            return View("BringSkill", value);
        }
        [HttpPost]
        public ActionResult BringSkill(Skill y)
        {
            var x = context.Skills.Find(y.Id);
            x.Explanation = y.Explanation;
            x.Value = y.Value;
            context.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}