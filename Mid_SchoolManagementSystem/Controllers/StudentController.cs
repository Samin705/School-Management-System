using Mid_SchoolManagementSystem.Models.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mid_SchoolManagementSystem.Controllers
{
    public class StudentController : Controller
    {
        smsEntities data = new smsEntities();
        //Student landing page or INDEX
        [HttpGet]
        public ActionResult StudentIndex()
        {
            if ((string)Session["user"] != null)
            {
                return View();
            }
            return RedirectToAction("Login", "User");
        }

        //Edit Student GET
        [HttpGet]
        public ActionResult EditStudentProfile()
        {
            if ((string)Session["user"] != null)
            {
                string studentid = (string)Session["user"];

                student s = data.student.Where(x => x.studentid == studentid).FirstOrDefault();
                Debug.WriteLine(s);
                s.studentid = studentid;
                student[] student = data.student.ToArray();
                ViewData["student"] = student;
                var fromDatabaseEF = new SelectList(data.@class.ToList(), "classid", "classname");
                var sec = new SelectList(data.section.ToList(), "sectionid", "sectionname");
                ViewData["classlist"] = fromDatabaseEF;
                ViewData["sectionlist"] = sec;
                return View(s);
            }
            return RedirectToAction("Login", "User");
        }

        //Edit Student POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditStudentProfile(student s, int id)
        {
            if ((string)Session["user"] != null)
            {
                student studenttoupdate = data.student.Where(x => x.id == id).FirstOrDefault();
                // Debug.WriteLine(studenttoupdate);
                //  Debug.WriteLine(id);
                // Debug.WriteLine(s.studentid);
                // Debug.WriteLine(s.studentname);
                // Debug.WriteLine(s.studentpassword);
                // Debug.WriteLine(s.studentconfirmpassword);

                studenttoupdate.studentid = s.studentid;
                studenttoupdate.studentname = s.studentname;
                studenttoupdate.studentpassword = Crypto.Hash(s.studentpassword);
                studenttoupdate.studentconfirmpassword = Crypto.Hash(s.studentconfirmpassword);
                studenttoupdate.studentdob = s.studentdob;
                studenttoupdate.studentphone = s.studentphone;
                studenttoupdate.studentaddress = s.studentaddress;
                studenttoupdate.studentemail = s.studentemail;
                studenttoupdate.studentbloodgroup = s.studentbloodgroup;
                studenttoupdate.studentfees = s.studentfees;
                studenttoupdate.classid = s.classid;
                studenttoupdate.sectionid = s.sectionid;

                try
                {
                    data.Entry(studenttoupdate).State = EntityState.Modified;
                    data.SaveChanges();
                }
                catch (DbEntityValidationException e)
                {
                    foreach (var eve in e.EntityValidationErrors)
                    {
                        Debug.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Debug.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                                ve.PropertyName, ve.ErrorMessage);
                        }
                    }
                    throw;
                }

                return RedirectToAction("StudentIndex");
            }
            return RedirectToAction("Login", "User");
        }

        public ActionResult CheckGrades()
        {
            if ((string)Session["user"] != null)
            {
                return View(data.grade);
            }
            return RedirectToAction("Login", "User");
        }

    }
}