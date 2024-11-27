namespace Projet.Models
{
    public class RH :User
    {
        public ICollection<JobPost> Posts { get; set; }
        public ICollection<Congé> CongesAttribues { get; set; }
        public ICollection<Formation> Formations { get; set; }

        public RH() { }
    }
}
