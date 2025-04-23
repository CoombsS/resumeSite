namespace resumeSite.Models
{
    public class ResumeModelMongo
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? GitHub { get; set; }
        public string? Email { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }

        public string? PastExperience1 { get; set; }
        public string? PastExperience2 { get; set; }
        public string? PastExperience3 { get; set; }
        public string? PastExperienceDetails1 { get; set; }
        public string? PastExperienceDetails2 { get; set; }
        public string? PastExperienceDetails3 { get; set; }

        public string? Project1 { get; set; }
        public string? Project2 { get; set; }
        public string? Project3 { get; set; }
        public string? ProjectDetails1 { get; set; }
        public string? ProjectDetails2 { get; set; }
        public string? ProjectDetails3 { get; set; }

        public string? Languages { get; set; }
        public string? Technology { get; set; }
        public string? PersonalSkills { get; set; }
    }
}
