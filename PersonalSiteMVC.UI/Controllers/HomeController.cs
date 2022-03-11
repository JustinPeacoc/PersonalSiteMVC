using PersonalSiteMVC.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace PersonalSiteMVC.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult ContactAjax(ContactViewModel cvm)
        {
            string body = $"You have received an email from <strong>{cvm.Name}</strong>. The email address given was <strong>{cvm.Email}</strong>.<br/><strong>The following message was sent:</strong> {cvm.Message}";

            MailMessage mm = new MailMessage();
            mm.From = new MailAddress("administrator@projectpeacock.net");
            mm.To.Add(new MailAddress("justinpeacock30@outlook.com"));
            mm.Subject = cvm.Subject;
            mm.Body = body;

            mm.IsBodyHtml = true;
            mm.ReplyToList.Add(cvm.Email);

            SmtpClient smtp = new SmtpClient("mail.projectpeacock.net");
            NetworkCredential cred = new NetworkCredential("administrator@projectpeacock.net", "P@ssw0rd");

            smtp.Credentials = cred;
            smtp.Send(mm);
            return Json(cvm);
                
        }

        public PartialViewResult ContactConfirmation(string name, string email)
        {
            ViewBag.Name = name;
            ViewBag.Email = email;
            return PartialView("ContactConfirmation");
        }
    }
}