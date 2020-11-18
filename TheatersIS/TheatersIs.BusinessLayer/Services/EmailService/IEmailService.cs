using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TheatersIs.BusinessLayer.DTOs;

namespace TheatersIs.BusinessLayer.Services.EmailService
{
    public interface IEmailService
    {
        Task SendTicketEmail(EmailTicketInfoDTO ticketInfo, UserDTO user);
    }
}
