namespace Projet.Models
{
    public class Employé : User
    {
        public int? FormationConcernéeId { get; set; }
        public Formation FormationConcernée { get; set; }

        public int? FormationPrésenteId { get; set; }
        public Formation FormationPrésente { get; set; }
        public Employé () { }   
    }
}
