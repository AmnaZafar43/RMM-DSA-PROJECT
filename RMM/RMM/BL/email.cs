using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMM.BL
{
    internal class email
    {
        public static bool SendMail(string mail, string body)
        {
            try
            {
                string fromMail = "amnazafar052@gmail.com";
                string pass = "pmkztmwsppcjtbzr";
                MailMessage message = new MailMessage();
                message.From = new MailAddress(fromMail);
                message.Subject = "testing ";
                message.To.Add(new MailAddress(mail));
                message.Body = "<html><body>" + body + " </body></html>";
                message.IsBodyHtml = true;
                message.IsBodyHtml = true;

                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromMail, pass),
                    EnableSsl = true,
                };
                smtpClient.Send(message);
                Console.WriteLine("trying");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.ToString(), "warn");
            }
            return true;
        }
    }
}