using TheatersIS.DataLayer.Entities;

namespace TheatersIs.BusinessLayer.DTOs
{
    public class SearchTheraterDTO
    {
        public string Name { get; set; }
        public TheaterTypes? Type { get; set; }
        public string FieldToSort { get; set; }
        public bool Descending { get; set; }
    }
}
