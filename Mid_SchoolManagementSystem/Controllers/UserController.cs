using Mid_SchoolManagementSystem.Models;
using Mid_SchoolManagementSystem.Models.DataAccess;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mid_SchoolManagementSystem.Controllers
{
    public class UserController : Controller
    {
        //Login Get
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        //Login POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Login login)
        {
            string inputID = checkUserID(login.Userid);
            string hashpassword = Crypto.Hash(login.Password);

            using (smsEntities data = new smsEntities())
            {
                if (inputID == "01")
                {
                    var u = data.superadmin.Where(a => a.superadminpassword == hashpassword).FirstOrDefault();
                    if (u != null)
                    {
                        if (string.Compare(Crypto.Hash(login.Password), u.superadminpassword) == 0)
                        {
                            Session["user"] = u.superadminid;
                            return RedirectToAction("SuperIndex", "SuperAdmin");
                        }
                    }
                }
                else if (inputID == "02")
                {
                    var u = data.admin.Where(a => a.adminpassword == hashpassword).FirstOrDefault();
                    if (u != null)
                    {
                        if (string.Compare(Crypto.Hash(login.Password), u.adminpassword) == 0)
                        {
                            Session["user"] = u.adminid;
                            return RedirectToAction("AdminIndex", "Admin");
                        }
                    }
                }
                else if (inputID == "03")
                {
                    var u = data.teacher.Where(a => a.teacherpassword == hashpassword).FirstOrDefault();
                    if (u != null)
                    {
                        if (string.Compare(Crypto.Hash(login.Password), u.teacherpassword) == 0)
                        {
                            Session["user"] = u.teacherid;
                            return RedirectToAction("TeacherIndex", "Teacher");
                        }
                    }
                }
                else if (inputID == "04")
                {
                    var u = data.student.Where(a => a.studentpassword == hashpassword).FirstOrDefault();
                    if (u != null)
                    {
                        if (string.Compare(Crypto.Hash(login.Password), u.studentpassword) == 0)
                        {
                            Session["user"] = u.studentid;
                            return RedirectToAction("StudentIndex", "Student");
                        }
                    }
                }
                else
                {
                    ViewBag.Message = "Invalid credential!!";
                }
                return View();
            }
        }

        //Logout Get
        [HttpGet]
        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Login", "User");
        }

        public string checkUserID(string id)
        {
            Debug.WriteLine(id);
            string[] idList = id.Split('-');
            string id3 = idList[2];
            return id3;
        }
    }
}