using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using UniFipMoc.Models;

namespace UniFipMoc.Controllers
{
    public class AcademicoesController : Controller
    {
        private contexto db = new contexto();

        // GET: Academicoes
        public ActionResult Index()
        {
            return View(db.Academicos.ToList());
        }

        // GET: Academicoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Academico academico = db.Academicos.Find(id);
            if (academico == null)
            {
                return HttpNotFound();
            }
            return View(academico);
        }

        // GET: Academicoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Academicoes/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,CPF,Nome,Data_nascimento,Telefone,Email")] Academico academico)
        {
            if (ModelState.IsValid)
            {
                db.Academicos.Add(academico);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(academico);
        }

        // GET: Academicoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Academico academico = db.Academicos.Find(id);
            if (academico == null)
            {
                return HttpNotFound();
            }
            return View(academico);
        }

        // POST: Academicoes/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CPF,Nome,Data_nascimento,Telefone,Email")] Academico academico)
        {
            if (ModelState.IsValid)
            {
                db.Entry(academico).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(academico);
        }

        // GET: Academicoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Academico academico = db.Academicos.Find(id);
            if (academico == null)
            {
                return HttpNotFound();
            }
            return View(academico);
        }

        // POST: Academicoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Academico academico = db.Academicos.Find(id);
            db.Academicos.Remove(academico);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
