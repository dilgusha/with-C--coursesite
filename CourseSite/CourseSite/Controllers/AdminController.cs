using CourseSite.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CourseSite.Controllers
{
    public class AdminController : Controller
    {
        DataClasses1DataContext DataBase = new DataClasses1DataContext();

        // GET: Admin
        public ActionResult AboutAdmin()
        {
            List<About> haqqinda = new List<About>();
            haqqinda = DataBase.Abouts.ToList();
            return View(haqqinda);
        }

        [HttpPost]
        public ActionResult AboutAdmin(About a, HttpPostedFileBase AboutPhoto)
        {
            if (a.AboutID == 0)
            {
                DataBase.Abouts.InsertOnSubmit(a);
                DataBase.SubmitChanges();
            }
            else
            {
                About selectedAbout = DataBase.Abouts.SingleOrDefault(x => x.AboutID == a.AboutID);
                selectedAbout.AboutSolution = a.AboutSolution;
                selectedAbout.AboutContent = a.AboutContent;

                string PhotoName = "AboutPhoto" + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour +
               DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Millisecond + Path.GetExtension(AboutPhoto.FileName);
                AboutPhoto.SaveAs(Server.MapPath("~/assets/images/" + PhotoName));
                a.AboutPhoto = PhotoName;
                DataBase.Abouts.InsertOnSubmit(a);
                DataBase.SubmitChanges();
            }
            return RedirectToAction("AboutList");
        }
        public ActionResult AboutList()
        {
            List<About> haqqinda = new List<About>();
            ViewBag.About = DataBase.Abouts.ToList();
            haqqinda = DataBase.Abouts.ToList();
            return View(haqqinda);
        }

        public ActionResult AboutDelete(int id)
        {
            DataBase.Abouts.DeleteOnSubmit(DataBase.Abouts.SingleOrDefault(x => x.AboutID == id));
            DataBase.SubmitChanges();
            return RedirectToAction("AboutList");
        }

        public ActionResult AboutEdit(int id)
        {
            List<About> haqqinda = new List<About>();
            ViewBag.About = DataBase.Abouts.ToList();
            haqqinda = DataBase.Abouts.ToList();
            About a = DataBase.Abouts.Where(x => x.AboutID == id).SingleOrDefault();
            return View(haqqinda);
        }
        [HttpPost]
        public ActionResult AboutEdit(int id, About a, HttpPostedFileBase AboutPhoto)
        {
            string PhotoName = "AboutPhoto" + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour +
                 DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Millisecond + Path.GetExtension(AboutPhoto.FileName);
            AboutPhoto.SaveAs(Server.MapPath("~/assets/images/" + PhotoName));
            About update = DataBase.Abouts.SingleOrDefault(x => x.AboutID == id);
            update.AboutSolution = a.AboutSolution;
            update.AboutContent = a.AboutContent;
            update.AboutPhoto = PhotoName;
            DataBase.SubmitChanges();
            return RedirectToAction("AboutList");
        }


        public ActionResult ServicesAdmin()
        {
            List<OurService> services = new List<OurService>();
            services = DataBase.OurServices.ToList();
            return View(services);
        }
        [HttpPost]
        public ActionResult ServicesAdmin(OurService s, HttpPostedFileBase OurServicePhoto)
        {
            if (s.OurServiceID == 0)
            {
                DataBase.OurServices.InsertOnSubmit(s);
                DataBase.SubmitChanges();
            }
            else
            {
                OurService selectedOurService = DataBase.OurServices.SingleOrDefault(x => x.OurServiceID == s.OurServiceID);
                selectedOurService.OurServiceName = s.OurServiceName;
                selectedOurService.OurServiceAbout = s.OurServiceAbout;

                string PhotoName = "OurServicePhoto" + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour +
                DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Millisecond + Path.GetExtension(OurServicePhoto.FileName);
                OurServicePhoto.SaveAs(Server.MapPath("~/assets/images/" + PhotoName));
                s.OurServicePhoto = PhotoName;

                DataBase.OurServices.InsertOnSubmit(s);
                DataBase.SubmitChanges();
            }
            return RedirectToAction("ServicesList");
        }
        public ActionResult ServicesList()
        {
            List<OurService> services = new List<OurService>();
            ViewBag.OurService = DataBase.OurServices.ToList();
            services = DataBase.OurServices.ToList();
            return View(services);
        }
        public ActionResult ServicesDelete(int id)
        {
            DataBase.OurServices.DeleteOnSubmit(DataBase.OurServices.SingleOrDefault(x => x.OurServiceID == id));
            DataBase.SubmitChanges();
            return RedirectToAction("ServicesList");
        }

        public ActionResult ServicesEdit(int id)
        {
            List<OurService> services = new List<OurService>();
            ViewBag.OurService = DataBase.OurServices.ToList();
            services = DataBase.OurServices.ToList();
            OurService s = DataBase.OurServices.Where(x => x.OurServiceID == id).SingleOrDefault();
            return View(services);
        }
        [HttpPost]
        public ActionResult ServicesEdit(int id, OurService s, HttpPostedFileBase OurServicePhoto)
        {
            string PhotoName = "OurServicePhoto" + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour +
            DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Millisecond + Path.GetExtension(OurServicePhoto.FileName);
            OurServicePhoto.SaveAs(Server.MapPath("~/assets/images/" + PhotoName));
            OurService update = DataBase.OurServices.SingleOrDefault(x => x.OurServiceID == id);
            update.OurServiceName = s.OurServiceName;
            update.OurServiceAbout = s.OurServiceAbout;
            update.OurServicePhoto = PhotoName;
            DataBase.SubmitChanges();
            return RedirectToAction("ServicesList");
        }

        public ActionResult TeamAdmin()
        {
            List<Team> team = new List<Team>();
            team = DataBase.Teams.ToList();
            return View(team);
        }
        [HttpPost]
        public ActionResult TeamAdmin(Team t, HttpPostedFileBase TeamPhoto)
        {
            if (t.TeamID == 0)
            {
                DataBase.Teams.InsertOnSubmit(t);
                DataBase.SubmitChanges();
            }
            else
            {
                Team selectedTeam = DataBase.Teams.SingleOrDefault(x => x.TeamID == t.TeamID);
                selectedTeam.TeamName = t.TeamName;
                selectedTeam.TeamPosition = t.TeamPosition;

                string PhotoName = "TeamPhoto" + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour +
                DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Millisecond + Path.GetExtension(TeamPhoto.FileName);
                TeamPhoto.SaveAs(Server.MapPath("~/assets/images/" + PhotoName));
                t.TeamPhoto = PhotoName;
                DataBase.Teams.InsertOnSubmit(t);
                DataBase.SubmitChanges();
            }
            return RedirectToAction("TeamList");
        }
        public ActionResult TeamList()
        {
            List<Team> team = new List<Team>();
            ViewBag.Team = DataBase.Teams.ToList();
            team = DataBase.Teams.ToList();
            return View(team);
        }
        public ActionResult TeamDelete(int id)
        {
            DataBase.Teams.DeleteOnSubmit(DataBase.Teams.SingleOrDefault(x => x.TeamID == id));
            DataBase.SubmitChanges();
            return RedirectToAction("TeamList");
        }


        public ActionResult InfoAdmin()
        {
            List<Info> info = new List<Info>();
            info = DataBase.Infos.ToList();
            return View(info);
        }
        [HttpPost]
        public ActionResult InfoAdmin(Info i)
        {
            if (i.InfoID == 0)
            {
                DataBase.Infos.InsertOnSubmit(i);
                DataBase.SubmitChanges();
            }
            else
            {
                Info selectedInfo = DataBase.Infos.SingleOrDefault(x => x.InfoID == i.InfoID);
                selectedInfo.InfoPhone = i.InfoPhone;
                selectedInfo.InfoEmail = i.InfoEmail;
                selectedInfo.InfoLocation = i.InfoLocation;
                selectedInfo.InfoPlace = i.InfoPlace;
                selectedInfo.InfoFace = i.InfoFace;
                selectedInfo.InfoTwitter = i.InfoTwitter;
                selectedInfo.infoLink = i.infoLink;

                DataBase.Infos.InsertOnSubmit(i);
                DataBase.SubmitChanges();
            }
            return RedirectToAction("InfoList");
        }
        public ActionResult InfoList()
        {
            List<Info> info = new List<Info>();
            ViewBag.Info = DataBase.Infos.ToList();
            info = DataBase.Infos.ToList();
            return View(info);
        }
        public ActionResult InfoDelete(int id)
        {
            DataBase.Infos.DeleteOnSubmit(DataBase.Infos.SingleOrDefault(x => x.InfoID == id));
            DataBase.SubmitChanges();
            return RedirectToAction("InfoList");
        }

        public ActionResult ContactList()
        {
            List<Contact> contact = new List<Contact>();
            ViewBag.Contact = DataBase.Contacts.ToList();
            contact = DataBase.Contacts.ToList();
            return View(contact);
        }
    }

}