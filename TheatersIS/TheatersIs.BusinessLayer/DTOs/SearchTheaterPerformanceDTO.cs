using System;

namespace TheatersIs.BusinessLayer.DTOs
{
    public class SearchTheaterPerformanceDTO
    {
        public string TheaterName { get; set; }
        public string PerformanceName { get; set; }

        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public int? StartPrice { get; set; }
        public int? EndPrice { get; set; }

        public string FieldToSort { get; set; }
        public bool Descending { get; set; }
    }
}
