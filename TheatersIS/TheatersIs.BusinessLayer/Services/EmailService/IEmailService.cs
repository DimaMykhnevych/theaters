using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TheatersIs.BusinessLayer.DTOs;
using TheatersIS.DataLayer.Entities;

namespace TheatersIs.BusinessLayer.Services.EmailService
{
    public interface IEmailService
    {
        Task SendTicketEmail(EmailTicketInfoDTO ticketInfo, UserDTO user);

        Task SendNewPerformanceEmail(IEnumerable<UserDTO> users, TheaterPerformanceDTO theaterPerformance);
    }
}
