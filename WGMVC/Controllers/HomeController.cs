using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WGMVC.Models;
using System.Net.Mail;
namespace WGMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Contact(ContactInfo info)
        {
            if (ModelState.IsValid)
            {
                MailMessage msg = new MailMessage(
                    "darius@dariusthenerd.com", "dariusclark73@gmail.com", "WG Msg", string.Format("Name: {0}<br/>" +
                    " Email: {1} <br/> Comments: {2}  ", info.Name,info.Email , info.Comments));
                msg.IsBodyHtml = true;

                msg.ReplyToList.Add(info.Email);
                SmtpClient client = new SmtpClient("relay-hosting.secureserver.net");
                try
                {
                    client.Send(msg);
                    //success\
                    ViewBag.MessageSent = true;

                }
                catch 
                {
                    ViewBag.MessageSent = false;
                }
                return View("ContactThanks", info );
            }
            return View();
        }
    
    }
}
