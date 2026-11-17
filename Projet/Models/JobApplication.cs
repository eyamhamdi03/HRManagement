namespace Projet.Models
{
    public class JobApplication
    {
        public int JobApplicationId {  get; set; }

        /*relation*/
        public int JobPostId {  get; set; }
        public JobPost jobPostInformation { get; set; }
        public int CandidatId { get; set; }
        public Candidat candidatInformation { get; set; }
        public Entretien ? Entretien { get; set; } 
        public JobApplication() { }
    }
}
