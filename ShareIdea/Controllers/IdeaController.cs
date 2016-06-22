using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShareIdea.Controllers
{
    public class IdeaController : Controller
    {
        //
        // GET: /Idea/

        public ActionResult Index(int id)
        {
            var idea = ShareIdea.Models.IdeaModel.GetIdea(id);
            return View(idea);
        }

        //
        // GET: /Idea/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Idea/Create

        public ActionResult Create()
        {

            return View();
        }

        //
        // POST: /Idea/Create

        [HttpPost]
        public ActionResult Create(ShareIdea.Models.IdeaModel model)
        {
            try
            {
                if (model.Title != null)
                {
                    ShareIdeaDBDataContext cont = new ShareIdeaDBDataContext();
                    Idea idea = new Idea()
                    {
                        title = model.Title,
                        description = model.Description
                    };
                    cont.Ideas.InsertOnSubmit(idea);
                    cont.SubmitChanges();
                }
                return RedirectToAction("Create");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Idea/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Idea/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Idea/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Idea/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
