using System;
using System.Collections.Generic;
using System.Text;
using TheatersIS.DataLayer.Entities;

namespace TheatersIs.BusinessLayer.DTOs
{
    public class PopularGenresDTO
    {
        public int Id { get; set; }
        public PerformanceGenre PerformanceGenre { get; set; }
        public int AttendanceAmount { get; set; }
    }
}
