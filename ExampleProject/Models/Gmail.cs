using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace ExampleProject.Models
{
    public static class Gmail
    {
        public static void SendMail(string body)
        {
            var fromAddress = new MailAddress("yasin.baran@bil.omu.edu.tr", "Sunucu Yönetim Paneli Geribildirim");
            var toAddress = new MailAddress("yasin.baran@bil.omu.edu.tr");
            const string subject = "Sunucu Yönetim Paneli Geribildirim";
            using (var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, "sinbar19@")
                //trololol kısmı e-posta adresinin şifresi
            })
            {
                using (var message = new MailMessage(fromAddress, toAddress) { Subject = subject, Body = body })
                {
                    smtp.Send(message);
                }
            }
        }
    }
}