using System;
using System.Collections.Generic;
using System.Text;
using TheatersIS.DataLayer.Entities;

namespace TheatersIs.BusinessLayer.DTOs
{
    public class SearchPerformanceDTO
    {
        public string Name { get; set; }
        public string Author { get; set; }

        public string Composer { get; set; }
        public PerformanceStatus? Status { get; set; }
        public  PerformanceGenre? Genre { get; set; }
        public string FieldToSort { get; set; }
        public bool Descending { get; set; }
    }
}
