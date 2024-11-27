using System.ComponentModel.DataAnnotations.Schema;

namespace Projet.Models
{
    public class Entretien
    {

        public int EntretienId { get; set; }

        [ForeignKey("JobApplication")]
        public int? JobApplicationId  { get; set; }
        public JobApplication JobApplication { get; set; }
        public DateTime date { get; set; }
        /*relation*/

        public int RHId { get; set; }
        public RH RH { get; set; }
       public Entretien() { }
    }
}
