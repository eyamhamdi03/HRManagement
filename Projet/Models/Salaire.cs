using System.ComponentModel.DataAnnotations.Schema;

namespace Projet.Models
{
    public class Salaire
    {
        public int SalaireId { get; set; }

        public DateTime dateDeb {  get; set; }
        public DateTime dateFin { get; set; }
        public int salaire_H { get; set; }
        public int salaire_brut { get; set; }
        public int salaire_net { get; set; }
        public int nombre_H_plus { get; set; }
        public Salaire() { }

        /*relation 1:1 */
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
