namespace DentalCLinic.Models
{
    public class ServiceData
    {
        public string Slug { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty; // HTML Content (Deprecated)  Uc@FL6MngSbCa9vGl# DB= KlodaBacka10071980@ FTP= Nome utente:u123423882 PW: KlodaBacka10071980@

        public string DescriptionCol1 { get; set; } = string.Empty;
        public string DescriptionCol2 { get; set; } = string.Empty;
        public string? HeroImage { get; set; }
        public string? BeforeImage { get; set; }
        public string? AfterImage { get; set; }
        public string BeforeImageLabel { get; set; } = "BEFORE";
        public string AfterImageLabel { get; set; } = "AFTER";
    }
}
