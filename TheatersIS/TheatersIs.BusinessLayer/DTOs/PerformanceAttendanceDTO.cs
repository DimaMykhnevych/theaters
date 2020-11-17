using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TheatersIS.DataLayer.Entities;

namespace TheatersIs.BusinessLayer.DTOs
{
    public class PerformanceAttendanceDTO
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }


        [Required]
        public PerformanceGenre PerformanceGenre { get; set; }

        public string Author { get; set; }

        public int AttendanceAmount { get; set; }
    }
}
