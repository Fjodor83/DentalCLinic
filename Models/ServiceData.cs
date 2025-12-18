namespace DentalCLinic.Models
{
    public class ServiceData
    {
        public string Slug { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty; // HTML Content
        public string? HeroImage { get; set; }
        public string? BeforeImage { get; set; }
        public string? AfterImage { get; set; }
    }
}
