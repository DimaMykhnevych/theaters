using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using TheatersIs.BusinessLayer.DTOs;
using TheatersIs.BusinessLayer.Mappers;

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

        public async Task SendNewPerformanceEmail(IEnumerable<UserDTO> users, TheaterPerformanceDTO theaterPerformance)
        {
            MailAddress addressFrom = new MailAddress("kharkov.theaters@gmail.com", "Kharkov Theaters");



            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential("kharkov.theaters@gmail.com", "Galaxybird07");
            smtp.EnableSsl = true;

            string perfGenre = PerformanceGenreMapper.GetPerformanceStringGenre
                (theaterPerformance.Performance.PerformanceGenre);
            string theaterType = TheaterTypeMapper.GetTheaterTypeStringGenre
                (theaterPerformance.Theater.TheaterType);
            string author = theaterPerformance.Performance.Author == null
                ? ""
                : $"Автор: {theaterPerformance.Performance.Author}";
            string composer = theaterPerformance.Performance.Composer == null
                ? ""
                : $"Композитор: {theaterPerformance.Performance.Composer}";
            string perfDate = theaterPerformance.PerformanceDate.ToString("g");


            foreach (var user in users)
            {
                MailAddress addressTo = new MailAddress(user.Email);
                MailMessage message = new MailMessage(addressFrom, addressTo);
                string url = "http://localhost:4200/orderReview" + $"?theaterPerformanceId={theaterPerformance.Id}&userId={user.Id}";
                message.Subject = "Выход нового представления";
                message.IsBodyHtml = true;
                string htmlString = @$"<html>
                      <body>
                      <p>Здравствуйте, {user.FullName},</p>
                      <p>В театре {theaterPerformance.Theater.Name} (тип: {theaterType}) выходит новое 
                            представление {theaterPerformance.Performance.Name}.
                            Мы думаем, оно вам понравится)</p>
                      <p>Жанр представления: {perfGenre}</p>
                      <p>{author}</p>
                      <p>{composer}</p>
                      <p>Когда: {perfDate}</p>
                      <p>Цена за билет: {theaterPerformance.TicketPrice} грн</p>
                      <a href={url}>Купить билеты</a>
                      <p>С уважением,<br>-Театры Харькова</br></p>
                      </body>
                      </html>
                     ";
                message.Body = htmlString;
                smtp.Send(message);
            }
        }
    }
}
