using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TheatersIs.BusinessLayer.DTOs
{
    public class UserDTO
    {
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        public string Email { get; set; }

        public string TelephoneNumber { get; set; }

        public List<OrderDTO> Orders { get; set; }

        public List<UserAnswerDTO> UserAnswers { get; set; }
    }
}
