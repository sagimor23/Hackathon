using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SmartBook.DAL;
using SmartBook.Models;
using SmartBook.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Website.Models
{
    public class BookController : Controller
    {
        SmartBookWebLogic dal = new SmartBookWebLogic();

        public ActionResult CreateBook(Book cust)
        {
            if (!isAdminUser())
            {
                return RedirectToAction("Index", "Main");
            }
               

            return View();

        }

        [HttpPost]
        // GET:add Book

        public ActionResult Add_Book(Book cust)
        {
            
            if (ModelState.IsValid)
            {
                dal.AddBook(cust);
                dal.SaveChanges();
                return RedirectToAction("BooksList");
                ;

            }
            else
            {
                return View();

            }
        }


        public ActionResult Details(int id)
        {
            return View("Details", dal.GetBookById(id));
        }

        public ActionResult BooksList()
        {
            if (isAdminUser())
            {
                ViewBag.isAdmin = "true";
            }
            return View(dal.GetAllBooks().ToList());
        }

        public ActionResult Delete(int id)
        {
            dal.DeleteBook(dal.GetBookById(id));
            dal.SaveChanges();

            return View("BooksList", dal.GetAllBooks().ToList());
        }


        public ActionResult Edit(int id)
        {
            if (ModelState.IsValid)
            {
                dal.UpdateBook(dal.GetBookById(id));
                dal.SaveChanges();
                return View("BooksList", dal.GetAllBooks().ToList());

            }
            else
            {
                return View("CreateBook");

            }
            //return View(new Book());
        }

        public ActionResult UpdateBook(int id,Book cust)
        {

            if (ModelState.IsValid)
            {
                dal.UpdateBook(dal.GetBookById(id));
                dal.SaveChanges();
                return View("BooksList", dal.GetAllBooks().ToList());

            }
            else
            {
                return View();

            }
        }


        

        //add new comment
        public ActionResult CreataComment(Review commn, Book cust)
        {
            commn.BookId = cust.BookId;
            commn.Book = cust;
            commn.ReviewDate = DateTime.Now;

            //cust.BookId = dal.GetBookById(id);
            return View(commn);
        }

        public ActionResult Add_Comment(Review commn)
        {
            if (ModelState.IsValid)
            {
                dal.AddReview(commn);
                dal.SaveChanges();
                return View("Details", dal.GetBookById(commn.BookId));

            }
            else
            {
                return View();

            }
        }

        public ActionResult Forum(Review commn)
        {

                return View();
            
        }

        public Boolean isAdminUser()
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = User.Identity;
                ApplicationDbContext context = new ApplicationDbContext();
                var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
                var s = UserManager.GetRoles(user.GetUserId());
                if (s[0].ToString() == "Admin")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

    }
}
