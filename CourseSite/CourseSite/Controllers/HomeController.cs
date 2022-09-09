using CourseSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CourseSite.Controllers
{
    public class HomeController : Controller
    {

        DataClasses1DataContext DataBase = new DataClasses1DataContext();

        // GET: Home
        public ActionResult Home()
        {
            List<About> haqqinda = new List<About>();
            ViewBag.About = DataBase.Abouts.ToList();
            haqqinda = DataBase.Abouts.ToList();
            List<OurService> services = new List<OurService>();
            ViewBag.OurService = DataBase.OurServices.ToList();
            services = DataBase.OurServices.ToList();

            List<General> umumi = new List<General>();
            ViewBag.General = DataBase.Generals.ToList();
            umumi = DataBase.Generals.ToList();
            return View(umumi);
        }

        public ActionResult About()
        {
            List<About> haqqinda = new List<About>();
            ViewBag.About = DataBase.Abouts.ToList();
            haqqinda = DataBase.Abouts.ToList();
            List<Team> team = new List<Team>();
            ViewBag.Team = DataBase.Teams.ToList();
            team = DataBase.Teams.ToList();

            List<DetailView> detail = new List<DetailView>();
            ViewBag.DetailView = DataBase.DetailViews.ToList();
            detail = DataBase.DetailViews.ToList();
            return View(detail);
        }

        public ActionResult Services()
        {
            List<OurService> services = new List<OurService>();
            services = DataBase.OurServices.ToList();
            return View(services);
        }

        public ActionResult Contact()
        {
            List<Contact> contact = new List<Contact>();
            ViewBag.Contact = DataBase.Contacts.ToList();
            contact = DataBase.Contacts.ToList();

            List<Info> info = new List<Info>();
            ViewBag.Info = DataBase.Infos.ToList();
            info = DataBase.Infos.ToList();
            return View(info);
        }
        [HttpPost]
        public ActionResult Contact(Contact c)
        {
            if (c.ContactID == 0)
            {
                DataBase.Contacts.InsertOnSubmit(c);
                DataBase.SubmitChanges();
            }
            else
            {
                Contact selectedContact = DataBase.Contacts.SingleOrDefault(x => x.ContactID == x.ContactID);
                selectedContact.ContactName = c.ContactName;
                selectedContact.ContactEmail = c.ContactEmail;
                selectedContact.ContactSubject = c.ContactSubject;
                selectedContact.ContactMessage = c.ContactMessage;

                DataBase.Contacts.InsertOnSubmit(c);
                DataBase.SubmitChanges();

            }
            return View("Contact");
        }
       
    }
}