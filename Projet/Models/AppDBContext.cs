using Microsoft.EntityFrameworkCore;

namespace Projet.Models
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options)
            : base(options)
        {
        }

        public DbSet<Candidat>? candidats { get; set; }
        public DbSet<Congé>? congés { get; set; }
        public DbSet<Employé>? employés { get; set; }
        public DbSet<Entretien>? entretiens { get; set; }
        public DbSet<Formation>? formations { get; set; }
        public DbSet<JobApplication>? jobApplications { get; set; }
        public DbSet<JobPost>? jobPosts { get; set; }
        public DbSet<RH>? RH { get; set; }
        public DbSet<Salaire>? salaire { get; set; }
        public DbSet<User>? Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Formation -> Employé Relationships
            modelBuilder.Entity<Employé>()
                .HasOne(e => e.FormationConcernée)
                .WithMany(f => f.EmployeConcernés)
                .HasForeignKey(e => e.FormationConcernéeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Employé>()
                .HasOne(e => e.FormationPrésente)
                .WithMany(f => f.EmployePrésents)
                .HasForeignKey(e => e.FormationPrésenteId)
                .OnDelete(DeleteBehavior.Restrict);

            // JobApplication -> Entretien (One-to-One)
            modelBuilder.Entity<JobApplication>()
                .HasOne(j => j.Entretien)
                .WithOne(e => e.JobApplication)
                .HasForeignKey<Entretien>(e => e.JobApplicationId)
                .OnDelete(DeleteBehavior.Restrict);

            // JobApplication -> JobPost
            modelBuilder.Entity<JobApplication>()
                .HasOne(j => j.jobPostInformation)
                .WithMany(jp => jp.JobApplications) // Use JobApplications
                .HasForeignKey(j => j.JobPostId)
                .OnDelete(DeleteBehavior.Restrict);

            // JobApplication -> Candidat
            modelBuilder.Entity<JobApplication>()
                .HasOne(j => j.candidatInformation)
                .WithMany(c => c.jobs)
                .HasForeignKey(j => j.CandidatId)
                .OnDelete(DeleteBehavior.Restrict);

            // Entretien -> RH
            modelBuilder.Entity<Entretien>()
                .HasOne(e => e.RH)
                .WithMany() // Assuming no navigation property in RH
                .HasForeignKey(e => e.RHId)
                .OnDelete(DeleteBehavior.Restrict);

            // Congé -> User
            modelBuilder.Entity<Congé>()
                .HasOne(c => c.User)
                .WithMany(u => u.Conges)
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            // Congé -> RH
            modelBuilder.Entity<Congé>()
                .HasOne(c => c.RH)
                .WithMany(r => r.CongesAttribues)
                .HasForeignKey(c => c.RHId)
                .OnDelete(DeleteBehavior.SetNull); // RH can be null if deleted

            // Salaire -> User
            modelBuilder.Entity<Salaire>()
                .HasOne(s => s.User)
                .WithOne(u => u.salaire)
                .HasForeignKey<Salaire>(s => s.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            // Discriminator for User types (Employé, RH, User)
            modelBuilder.Entity<User>().HasDiscriminator<string>("UserType")
                .HasValue<User>("User")
                .HasValue<Employé>("Employé")
                .HasValue<RH>("RH");
        }



    }
}
