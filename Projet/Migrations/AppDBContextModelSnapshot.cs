﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Projet.Models;

#nullable disable

namespace Projet.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Projet.Models.Candidat", b =>
                {
                    b.Property<int>("CandidatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CandidatId"));

                    b.Property<string>("Adresse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fonction")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationalité")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("numéro")
                        .HasColumnType("int");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CandidatId");

                    b.ToTable("candidats");
                });

            modelBuilder.Entity("Projet.Models.Congé", b =>
                {
                    b.Property<int>("CongéId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CongéId"));

                    b.Property<DateTime>("DateDeb")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateFin")
                        .HasColumnType("datetime2");

                    b.Property<string>("Execuse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RHId")
                        .HasColumnType("int");

                    b.Property<string>("Statut")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("CongéId");

                    b.HasIndex("RHId");

                    b.HasIndex("UserId");

                    b.ToTable("congés");
                });

            modelBuilder.Entity("Projet.Models.Entretien", b =>
                {
                    b.Property<int>("EntretienId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EntretienId"));

                    b.Property<int?>("JobApplicationId")
                        .HasColumnType("int");

                    b.Property<int>("RHId")
                        .HasColumnType("int");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.HasKey("EntretienId");

                    b.HasIndex("JobApplicationId")
                        .IsUnique()
                        .HasFilter("[JobApplicationId] IS NOT NULL");

                    b.HasIndex("RHId");

                    b.ToTable("entretiens");
                });

            modelBuilder.Entity("Projet.Models.Formation", b =>
                {
                    b.Property<int>("FormationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FormationId"));

                    b.Property<int?>("InstructeurUserId")
                        .HasColumnType("int");

                    b.Property<int>("RHId")
                        .HasColumnType("int");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<string>("durée")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FormationId");

                    b.HasIndex("InstructeurUserId");

                    b.HasIndex("RHId");

                    b.ToTable("formations");
                });

            modelBuilder.Entity("Projet.Models.JobApplication", b =>
                {
                    b.Property<int>("JobApplicationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JobApplicationId"));

                    b.Property<int>("CandidatId")
                        .HasColumnType("int");

                    b.Property<int>("JobPostId")
                        .HasColumnType("int");

                    b.HasKey("JobApplicationId");

                    b.HasIndex("CandidatId");

                    b.HasIndex("JobPostId");

                    b.ToTable("jobApplications");
                });

            modelBuilder.Entity("Projet.Models.JobPost", b =>
                {
                    b.Property<int>("JobPostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JobPostId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RHUserId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("JobPostId");

                    b.HasIndex("RHUserId");

                    b.HasIndex("UserId");

                    b.ToTable("jobPosts");
                });

            modelBuilder.Entity("Projet.Models.Salaire", b =>
                {
                    b.Property<int>("SalaireId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SalaireId"));

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("dateDeb")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("dateFin")
                        .HasColumnType("datetime2");

                    b.Property<int>("nombre_H_plus")
                        .HasColumnType("int");

                    b.Property<int>("salaire_H")
                        .HasColumnType("int");

                    b.Property<int>("salaire_brut")
                        .HasColumnType("int");

                    b.Property<int>("salaire_net")
                        .HasColumnType("int");

                    b.HasKey("SalaireId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("salaire");
                });

            modelBuilder.Entity("Projet.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Adresse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fonction")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationalité")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("numéro")
                        .HasColumnType("int");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("UserType").HasValue("User");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Projet.Models.Employé", b =>
                {
                    b.HasBaseType("Projet.Models.User");

                    b.Property<int?>("FormationConcernéeId")
                        .HasColumnType("int");

                    b.Property<int?>("FormationPrésenteId")
                        .HasColumnType("int");

                    b.HasIndex("FormationConcernéeId");

                    b.HasIndex("FormationPrésenteId");

                    b.HasDiscriminator().HasValue("Employé");
                });

            modelBuilder.Entity("Projet.Models.RH", b =>
                {
                    b.HasBaseType("Projet.Models.User");

                    b.HasDiscriminator().HasValue("RH");
                });

            modelBuilder.Entity("Projet.Models.Congé", b =>
                {
                    b.HasOne("Projet.Models.RH", "RH")
                        .WithMany("CongesAttribues")
                        .HasForeignKey("RHId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("Projet.Models.User", "User")
                        .WithMany("Conges")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("RH");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Projet.Models.Entretien", b =>
                {
                    b.HasOne("Projet.Models.JobApplication", "JobApplication")
                        .WithOne("Entretien")
                        .HasForeignKey("Projet.Models.Entretien", "JobApplicationId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Projet.Models.RH", "RH")
                        .WithMany()
                        .HasForeignKey("RHId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("JobApplication");

                    b.Navigation("RH");
                });

            modelBuilder.Entity("Projet.Models.Formation", b =>
                {
                    b.HasOne("Projet.Models.User", "Instructeur")
                        .WithMany()
                        .HasForeignKey("InstructeurUserId");

                    b.HasOne("Projet.Models.RH", "RH")
                        .WithMany("Formations")
                        .HasForeignKey("RHId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Instructeur");

                    b.Navigation("RH");
                });

            modelBuilder.Entity("Projet.Models.JobApplication", b =>
                {
                    b.HasOne("Projet.Models.Candidat", "candidatInformation")
                        .WithMany("jobs")
                        .HasForeignKey("CandidatId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Projet.Models.JobPost", "jobPostInformation")
                        .WithMany("JobApplications")
                        .HasForeignKey("JobPostId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("candidatInformation");

                    b.Navigation("jobPostInformation");
                });

            modelBuilder.Entity("Projet.Models.JobPost", b =>
                {
                    b.HasOne("Projet.Models.RH", null)
                        .WithMany("Posts")
                        .HasForeignKey("RHUserId");

                    b.HasOne("Projet.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Projet.Models.Salaire", b =>
                {
                    b.HasOne("Projet.Models.User", "User")
                        .WithOne("salaire")
                        .HasForeignKey("Projet.Models.Salaire", "UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Projet.Models.Employé", b =>
                {
                    b.HasOne("Projet.Models.Formation", "FormationConcernée")
                        .WithMany("EmployeConcernés")
                        .HasForeignKey("FormationConcernéeId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Projet.Models.Formation", "FormationPrésente")
                        .WithMany("EmployePrésents")
                        .HasForeignKey("FormationPrésenteId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("FormationConcernée");

                    b.Navigation("FormationPrésente");
                });

            modelBuilder.Entity("Projet.Models.Candidat", b =>
                {
                    b.Navigation("jobs");
                });

            modelBuilder.Entity("Projet.Models.Formation", b =>
                {
                    b.Navigation("EmployeConcernés");

                    b.Navigation("EmployePrésents");
                });

            modelBuilder.Entity("Projet.Models.JobApplication", b =>
                {
                    b.Navigation("Entretien");
                });

            modelBuilder.Entity("Projet.Models.JobPost", b =>
                {
                    b.Navigation("JobApplications");
                });

            modelBuilder.Entity("Projet.Models.User", b =>
                {
                    b.Navigation("Conges");

                    b.Navigation("salaire")
                        .IsRequired();
                });

            modelBuilder.Entity("Projet.Models.RH", b =>
                {
                    b.Navigation("CongesAttribues");

                    b.Navigation("Formations");

                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}
