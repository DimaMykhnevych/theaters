using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using TheatersIs.BusinessLayer.DTOs;

namespace TheatersIs.BusinessLayer.Services.EmailService
{
    public class EmailService : IEmailService
    {
        public async Task SendTicketEmail(EmailTicketInfoDTO ticketInfo, UserDTO user)
        {
            MailAddress addressFrom = new MailAddress("kharkov.theaters@gmail.com", "Kharkov Theaters");
            MailAddress addressTo = new MailAddress(user.Email);
            MailMessage message = new MailMessage(addressFrom, addressTo);
            string url = "http://localhost:4200/printTicket" + $"?orderId={ticketInfo.Order.Id}";

            message.Subject = "Билеты на представление";
            message.IsBodyHtml = true;
            string htmlString = @$"<html>
                      <body>
                      <p>Здравствуйте {user.FullName},</p>
                      <p>Перейдите по ссылке, представленной ниже, чтобы распечатать билеты.</p>
                      <a href={url}>Распечатать билеты</a>
                         <p>С уважением,<br>-Театры Харькова</br></p>
                      </body>
                      </html>
                     ";
            message.Body = htmlString;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential("kharkov.theaters@gmail.com", "Galaxybird07");
            smtp.EnableSsl = true;
            smtp.Send(message);

        }
    }
}
//< form action ={ url}>
   
//                            < input type = 'submit' value = 'Распечатать билеты' />
    
//                          </ form >