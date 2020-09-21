using Mid_SchoolManagementSystem.Models.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mid_SchoolManagementSystem.Controllers
{
    public class TeacherController : Controller
    {
        smsEntities data = new smsEntities();

        //Teacher landing page or INDEX
        [HttpGet]
        public ActionResult TeacherIndex()
        {
            if ((string)Session["user"] != null)
            {
                return View();
            }
            return RedirectToAction("Login", "User");
        }


        //UploadFile get       
        [HttpGet]
        public ActionResult UploadFile()
        {
            if ((string)Session["user"] != null)
            {
                return View();
            }
            return RedirectToAction("Login", "User");
        }



        //Upload File post
        [HttpPost]
        public ActionResult UploadFile(HttpPostedFileBase file, uploadnote uploadnote, @class classid, section section, teacher teacher)
        {
            if ((string)Session["user"] != null)
            {
                smsEntities data = new smsEntities();
                try
                {
                    if (file.ContentLength > 0)
                    {

                        string FileName = Path.GetFileName(file.FileName);
                        string path = Path.Combine(Server.MapPath("~/UploadedFiles"), FileName);
                        file.SaveAs(path);

                    }
                    ViewBag.Message = "File Uploaded Successfully!!";
                    return View();
                }
                catch
                {
                    ViewBag.Message = "File upload failed!!";
                    return View();
                }
            }
            return RedirectToAction("Login", "User");
        }


        ////UploadFile get       
        //[HttpGet]

        //public ActionResult UploadFile()
        //{
        //    using (smsEntities data = new smsEntities())
        //    {

        //        string id = (string)Session["user"];

        //        teacher teacher = data.teacher.Where(x => x.teacherid == id).FirstOrDefault();

        //        var sec = new SelectList(data.section.ToList(), "sectionid", "sectionname");
        //        ViewData["sectionlist"] = sec;

        //        var sub = new SelectList(data.subject.ToList(), "subjectid", "subjectname");
        //        ViewData["sublistlist"] = sub;
        //    }
        //    return View();
        //}
        ////Upload File post
        //[HttpPost]
        //public ActionResult UploadFile(HttpPostedFileBase file, uploadnote uploadnote)
        //{
        //    smsEntities data = new smsEntities();
        //    try
        //    {
        //        if (file.ContentLength > 0)
        //        {
        //            string FileName = Path.GetFileName(file.FileName);
        //            string path = Path.Combine(Server.MapPath("~/UploadedFiles"), FileName);
        //            file.SaveAs(path);


        //            data.uploadnote.Add(uploadnote);
        //            data.SaveChanges();

        //        }
        //        ViewBag.Message = "File Uploaded Successfully!!";
        //        return View();
        //    }
        //    catch
        //    {
        //        ViewBag.Message = "File upload failed!!";
        //        return View();
        //    }
        //}



        //Edit Teacher GET
        [HttpGet]
        public ActionResult EditTeacherProfile()
        {
            string teacherid = (string)Session["user"];

            teacher t = data.teacher.Where(x => x.teacherid == teacherid).FirstOrDefault();

            t.teacherid = teacherid;
            teacher[] teacher = data.teacher.ToArray();
            ViewData["teacher"] = teacher;

            var fromDatabaseEF = new SelectList(data.@class.ToList(), "classid", "classname");
            var sec = new SelectList(data.section.ToList(), "sectionid", "sectionname");
            var sub = new SelectList(data.subject.ToList(), "subjectid", "subjectname");
            ViewData["classlist"] = fromDatabaseEF;
            ViewData["sectionlist"] = sec;
            ViewData["subjectlist"] = sub;

            return View(t);
        }


        //Edit Teacher POST
        [HttpPost]
        public ActionResult EditTeacherProfile(teacher t, int id)
        {
            teacher teacher = new teacher();


            teacher teachertoupdate = data.teacher.Where(x => x.id == id).FirstOrDefault();
            //Debug.WriteLine(superadmintoupdate);
            //Debug.WriteLine(id);
            //Debug.WriteLine(s.superadminid);
            //Debug.WriteLine(s.superadminname);
            //Debug.WriteLine(s.superadminpassword);
            //Debug.WriteLine(s.superadminconfirmpassword);
            //superadmintoupdate.id = s.id;
            teachertoupdate.teacherid = t.teacherid;
            teachertoupdate.teachername = t.teachername;
            teachertoupdate.teacherphone = t.teacherphone;
            teachertoupdate.teacherbloodgroup = t.teacherbloodgroup;
            teachertoupdate.teacheremail = t.teacheremail;
            teachertoupdate.teacherpassword = Crypto.Hash(t.teacherpassword);
            teachertoupdate.teacherconfirmpassword = Crypto.Hash(t.teacherconfirmpassword);
            teachertoupdate.classid = t.classid;
            teachertoupdate.sectionid = t.sectionid;
            teachertoupdate.subjectid = t.subjectid;



            try
            {
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

            return RedirectToAction("TeacherIndex");

        }

        //Grade Upload Index

        public ActionResult Grades()
        {
            if ((string)Session["user"] != null)
            {
                return View(data.grade);
            }
            return RedirectToAction("Login", "User");
        }

        //Uploda Grades Get

        [HttpGet]

        public ActionResult UploadGrade()
        {

            var cls = new SelectList(data.@class.ToList(), "classname", "classname");
            var stu = new SelectList(data.student.ToList(), "studentname", "studentname");
            var sec = new SelectList(data.section.ToList(), "sectionname", "sectionname");
            var sub = new SelectList(data.subject.ToList(), "subjectname", "subjectname");
            ViewData["classlist"] = cls;
            ViewData["studentlist"] = stu;
            ViewData["sectionlist"] = sec;
            ViewData["subjectlist"] = sub;

            return View();
        }
        
        //Upload Grade Post
        [HttpPost]
        public ActionResult UploadGrade(grade grade)
        {
            if ((string)Session["user"] != null)
            {
                //Debug.WriteLine(grade.quiz2);
                data.grade.Add(grade);
             //   Debug.WriteLine(grade.quiz1);
                data.SaveChanges();
               
            }
            return View("Grades");
        }
        //Edit Grades

        [HttpGet]
        public ActionResult EditGrades(int id)
        {
            if ((string)Session["user"] != null)
            {
                grade s = data.grade.Where(a => a.gradeid == id).FirstOrDefault();
                s.gradeid = id;
               // Debug.WriteLine(s.gradeid);
                grade[] grade = data.grade.ToArray();
                ViewData["grade"] = grade;
                //var cls = new SelectList(data.@class.ToList(), "classname", "classname");
                //var stu = new SelectList(data.student.ToList(), "studentname", "studentname");
                //var sec = new SelectList(data.section.ToList(), "sectionname", "sectionname");
                //var sub = new SelectList(data.subject.ToList(), "subjectname", "subjectname");
                //ViewData["classlist"] = cls;
                //ViewData["studentlist"] = stu;
                //ViewData["sectionlist"] = sec;
                //ViewData["subjectlist"] = sub;

                return View(s);
            }
            return RedirectToAction("Login", "User");

        }

        [HttpPost]

        public ActionResult EditGrades(grade g, int id)
        {
            if ((string)Session["user"] != null)
            {
                grade gradeUpdate = data.grade.Where(a => a.gradeid == id).FirstOrDefault();
                gradeUpdate.gradeid = id;
                gradeUpdate.classname = g.classname;
                gradeUpdate.sectionname = g.sectionname;
                gradeUpdate.subjectname = g.subjectname;
                gradeUpdate.studentname = g.studentname;
                gradeUpdate.quiz1 = g.quiz1;
                gradeUpdate.quiz2 = g.quiz2;
                gradeUpdate.quiz3 = g.quiz3;
                gradeUpdate.quiz4 = g.quiz4;
                gradeUpdate.assignment1 = g.assignment1;
                gradeUpdate.assignment2 = g.assignment2;
                gradeUpdate.halfyearlygrade = g.halfyearlygrade;
                gradeUpdate.finalexamgrade = g.finalexamgrade;
                data.SaveChanges();
                return RedirectToAction("Grades");
            }
            return RedirectToAction("Login", "User");
        }

        //CourseNotice GET       
        [HttpGet]

        public ActionResult CreateCourseNotice()
        {
            if ((string)Session["user"] != null)
            {
               string teacherid = (string)Session["user"];
                Debug.WriteLine(teacherid);
                section[] sec = data.section.ToArray();

                TempData["sectionlist"] = sec;
                subject[] sub = data.subject.ToArray();

                TempData["subjectlist"] = sub;

                return View();
            }
            
            return RedirectToAction("Login", "User");
        }
        //Notice Post
        [HttpPost]

        public ActionResult CreateCourseNotice(coursenotice note)
        {

           
                //Debug.WriteLine(grade.quiz2);
                data.coursenotice.Add(note);
                //   Debug.WriteLine(grade.quiz1);
                data.SaveChanges();


            return View("TeacherIndex");
        }

    }

}


