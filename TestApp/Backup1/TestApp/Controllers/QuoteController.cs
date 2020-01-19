using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestApp.Context;
using TestApp.Models;
using System.Data.Entity;

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
                ViewBag.error = "";
                if(quote.body == null || quote.authorName == null){
                    ViewBag.error = "Please fill all fields on the form";
                }
                
                try{
                
                quoteDb.Quotes.Add(quote);
                quoteDb.SaveChanges();

                return RedirectToAction("Index");
                }
                catch{
                    return View();
                }
            
        }
        // GET: /Quote/Edit/5
        public ActionResult Edit(int id)
        {
            var quote = quoteDb.Quotes.Find(id);
            return View(quote);
        }
        // POST: /Quote/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include="QuoteId,body,authorName,entryDate")]Quote quote)
        {
            
            if(ModelState.IsValid){
                quoteDb.Entry(quote).State = EntityState.Modified;
                quoteDb.SaveChanges();
                return RedirectToAction("Index");
            }
            
            return View ();
            
        }
       
       
        [HttpGet]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try {
                var quote = quoteDb.Quotes.Find(id);
                if(quote != null) quoteDb.Quotes.Remove(quote);
                quoteDb.SaveChanges();
                return RedirectToAction ("Index");
            } catch {
                return View();
            }
        }
    }
}