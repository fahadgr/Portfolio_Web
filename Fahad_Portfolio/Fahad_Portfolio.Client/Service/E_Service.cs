using System.Net.Mail;
using System.Net;
using Fahad_Portfolio.Client.Data;

namespace Fahad_Portfolio.Client.Service
{
    public class E_Service
    {
        public async Task<string> SendEmail(ContactUs CObj)
        {
            using (var message = new MailMessage())
            {
                // Sender's credentials
                string To = "fahad.dotnet.developer@gmail.com";
                //string Password = "Helloworld01!";
                string Password = "fannxcdhvfzcxhaa";

                // Receiver's email
                //string receiverEmail = "support@wiperworx.com.au";
                string From = "fahadgr9@gmail.com";

                // Mail message
                message.To.Add(new MailAddress(From, "Trade Order"));
                message.From = new MailAddress(To);
                message.Subject = "Portfolio Web Subject: " + CObj.Subject;
                message.Body = $"Name :{CObj.Name}\n" +
                $"Email:{CObj.Email}\n" +
                $"Subject :{CObj.Subject}\n" +
                $"Message:{CObj.Message}\n";

                // SMTP client
                //SmtpClient client = new SmtpClient("mail.at-tahur.com");
                SmtpClient client = new SmtpClient("smtp.gmail.com");

                client.UseDefaultCredentials = false;
                client.Port = 587; // Port number might change based on your SMTP provider
                client.Credentials = new NetworkCredential(From, Password);
                client.EnableSsl = true; // Set to true if using SSL/TLS


                try
                {
                   
                    //client.Timeout = 40000; //20 seconds
                    await Task.Run(()=> client.Send(message));
                    return "Message Sent";
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
