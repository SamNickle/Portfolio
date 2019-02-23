namespace Portfolio.Models
{
    using System;

    public class WorkExperience
    {
        public int Id { get; set; }
        public string Position { get; set; }
        public string CompanyName { get; set; }
        public string Location { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string WorkDescription { get; set; }
    }
}
