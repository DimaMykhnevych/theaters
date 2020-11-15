using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TheatersIS.DataLayer.Entities
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        public string Email { get; set; }

        public string TelephoneNumber { get; set; }

        public List<Order> Orders { get; set; }

        public List<UserAnswer> UserAnswers { get; set; }

    }
}
