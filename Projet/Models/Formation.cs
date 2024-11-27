namespace Projet.Models
{
    public class Formation
    {
        public int FormationId {get; set;}
        public User? Instructeur {get; set;}
        public DateTime date { get; set;}
        public String durée { get; set;}
        public ICollection<Employé> EmployeConcernés {get; set;}
        public  ICollection<Employé> EmployePrésents {get; set;}

        /*relation*/
        public int RHId { get; set;}
        public RH RH { get; set;}
    }
}
