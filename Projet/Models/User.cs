
namespace Projet.Models
{
    public class User
    {
        public int UserId { get; set; }
        public String FullName { get; set; }
        public String Email { get; set; }
        public String CV { get; set; }
        public String Adresse { get; set; }
        public String Nationalité { get; set; }
        public String Fonction { get; set; }
        public int numéro { get; set; }
        public String login { get; set; }
        public String password { get; set; }
        
        public User() { }
        /*relation conge*/
        public ICollection<Congé> Conges { get; set; }

        /*relation 1:1*/
        public Salaire salaire { get; set; }
    }
}
