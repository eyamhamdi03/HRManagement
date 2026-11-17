namespace Projet.Models
{
    public class Candidat
    {

        public int CandidatId { get; set; }
        public String FullName { get; set; }
        public String Email { get; set; }
        public String CV { get; set; }
        public String Adresse { get; set; }
        public String Nationalité { get; set; }
        public String Fonction { get; set; }
        public int numéro { get; set; }
        public String login { get; set; }
        public String password { get; set; }

        /*relation*/
        public ICollection<JobApplication> jobs { get; set; }
        public Candidat()
        {


        }

    }
}
