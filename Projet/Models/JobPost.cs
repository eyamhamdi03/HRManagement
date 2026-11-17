namespace Projet.Models
{
    public class JobPost
    {
        public int JobPostId { get; set; }
        public String Title { get; set; } 
        public String Description { get; set; }

        /*relation ajouter par  RH*/
        public int UserId { get; set; }
        public User User { get; set; }

        /*relation postuler Candidat*/
        public ICollection<JobApplication> JobApplications { get; set; }

        public JobPost() { }    
    }
}
