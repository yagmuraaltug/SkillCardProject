using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using SkillCard_CodeFirstEntity.Models.Classes;


namespace SkillCard_CodeFirstEntity.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            Context context = new Context();
            var values = context.Skills.ToList();
            return View(values);
        }
    }
}