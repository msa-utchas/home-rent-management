using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace ToLetSearvice_v1.Bussiness_Logic_Layer
{
    class emailSearvice
    {
        public void send_email(string subject, string messege, string reciever)
        {
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("group.project.a1b2c3@gmail.com");
            mailMessage.To.Add(reciever);
            mailMessage.Subject = subject;
            mailMessage.Body = messege;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            System.Net.NetworkCredential ntcd = new NetworkCredential();
            ntcd.UserName = "group.project.a1b2c3@gmail.com";
            ntcd.Password = "groupproject123";
            smtp.Credentials = ntcd;
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.Send(mailMessage);

        }
    }
}
