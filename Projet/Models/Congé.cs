namespace Projet.Models
{
    public class Congé
    {
        public int CongéId { get; set; }
        public DateTime DateDeb { get; set; }
        public DateTime DateFin { get; set; }
        public string Execuse { get; set; }
        public string Statut { get; set; }
        /*relation*/
        public int? UserId { get; set; }
        public User User { get; set; }


        // RH ayant attribué le congé
        public int? RHId { get; set; } 
        public RH RH { get; set; }

    }
}
