using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestApp.Context;
using TestApp.Models;

namespace TestApp.Controllers
{
    public class QuoteController : Controller

    {
        QuoteContext quoteDb = new QuoteContext();
        public ActionResult Index()
        {
            var quotes = quoteDb.Quotes;
            if(quotes != null)
            {
                return View(quotes.ToList());
            }
            return View();
        }

        public ActionResult Details(int id)
        {
            return View ();
        }

        public ActionResult Create()
        {
            return View ();
        } 

        [HttpPost]
        public ActionResult Create(Quote quote)
        {
                
                quoteDb.Quotes.Add(quote);
                quoteDb.SaveChanges();
                //Console.WriteLine("here");

                return RedirectToAction("Index");
            
        }
        // GET: /Quote/Edit/5
        public ActionResult Edit(int id)
        {
            return View ();
        }
        // POST: /Quote/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try {
                return RedirectToAction ("Index");
            } catch {
                return View ();
            }
        }
        // GET: /Quote/Delete/5
        public ActionResult Delete(int id)
        {
            return View ();
        }
        // POST: /Quote/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try {
                return RedirectToAction ("Index");
            } catch {
                return View ();
            }
        }
    }
}