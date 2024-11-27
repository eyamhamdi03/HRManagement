using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projet.Migrations
{
    /// <inheritdoc />
    public partial class m75 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "candidats",
                columns: table => new
                {
                    CandidatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adresse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nationalité = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fonction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numéro = table.Column<int>(type: "int", nullable: false),
                    login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_candidats", x => x.CandidatId);
                });

            migrationBuilder.CreateTable(
                name: "congés",
                columns: table => new
                {
                    CongéId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateDeb = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateFin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Execuse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Statut = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    RHId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_congés", x => x.CongéId);
                });

            migrationBuilder.CreateTable(
                name: "entretiens",
                columns: table => new
                {
                    EntretienId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobApplicationId = table.Column<int>(type: "int", nullable: true),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RHId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_entretiens", x => x.EntretienId);
                });

            migrationBuilder.CreateTable(
                name: "formations",
                columns: table => new
                {
                    FormationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InstructeurUserId = table.Column<int>(type: "int", nullable: true),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    durée = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RHId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_formations", x => x.FormationId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adresse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nationalité = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fonction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numéro = table.Column<int>(type: "int", nullable: false),
                    login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserType = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    FormationConcernéeId = table.Column<int>(type: "int", nullable: true),
                    FormationPrésenteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_formations_FormationConcernéeId",
                        column: x => x.FormationConcernéeId,
                        principalTable: "formations",
                        principalColumn: "FormationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_formations_FormationPrésenteId",
                        column: x => x.FormationPrésenteId,
                        principalTable: "formations",
                        principalColumn: "FormationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "jobPosts",
                columns: table => new
                {
                    JobPostId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RHUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jobPosts", x => x.JobPostId);
                    table.ForeignKey(
                        name: "FK_jobPosts_Users_RHUserId",
                        column: x => x.RHUserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_jobPosts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "salaire",
                columns: table => new
                {
                    SalaireId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dateDeb = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dateFin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    salaire_H = table.Column<int>(type: "int", nullable: false),
                    salaire_brut = table.Column<int>(type: "int", nullable: false),
                    salaire_net = table.Column<int>(type: "int", nullable: false),
                    nombre_H_plus = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_salaire", x => x.SalaireId);
                    table.ForeignKey(
                        name: "FK_salaire_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "jobApplications",
                columns: table => new
                {
                    JobApplicationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobPostId = table.Column<int>(type: "int", nullable: false),
                    CandidatId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jobApplications", x => x.JobApplicationId);
                    table.ForeignKey(
                        name: "FK_jobApplications_candidats_CandidatId",
                        column: x => x.CandidatId,
                        principalTable: "candidats",
                        principalColumn: "CandidatId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_jobApplications_jobPosts_JobPostId",
                        column: x => x.JobPostId,
                        principalTable: "jobPosts",
                        principalColumn: "JobPostId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_congés_RHId",
                table: "congés",
                column: "RHId");

            migrationBuilder.CreateIndex(
                name: "IX_congés_UserId",
                table: "congés",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_entretiens_JobApplicationId",
                table: "entretiens",
                column: "JobApplicationId",
                unique: true,
                filter: "[JobApplicationId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_entretiens_RHId",
                table: "entretiens",
                column: "RHId");

            migrationBuilder.CreateIndex(
                name: "IX_formations_InstructeurUserId",
                table: "formations",
                column: "InstructeurUserId");

            migrationBuilder.CreateIndex(
                name: "IX_formations_RHId",
                table: "formations",
                column: "RHId");

            migrationBuilder.CreateIndex(
                name: "IX_jobApplications_CandidatId",
                table: "jobApplications",
                column: "CandidatId");

            migrationBuilder.CreateIndex(
                name: "IX_jobApplications_JobPostId",
                table: "jobApplications",
                column: "JobPostId");

            migrationBuilder.CreateIndex(
                name: "IX_jobPosts_RHUserId",
                table: "jobPosts",
                column: "RHUserId");

            migrationBuilder.CreateIndex(
                name: "IX_jobPosts_UserId",
                table: "jobPosts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_salaire_UserId",
                table: "salaire",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_FormationConcernéeId",
                table: "Users",
                column: "FormationConcernéeId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_FormationPrésenteId",
                table: "Users",
                column: "FormationPrésenteId");

            migrationBuilder.AddForeignKey(
                name: "FK_congés_Users_RHId",
                table: "congés",
                column: "RHId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_congés_Users_UserId",
                table: "congés",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_entretiens_Users_RHId",
                table: "entretiens",
                column: "RHId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_entretiens_jobApplications_JobApplicationId",
                table: "entretiens",
                column: "JobApplicationId",
                principalTable: "jobApplications",
                principalColumn: "JobApplicationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_formations_Users_InstructeurUserId",
                table: "formations",
                column: "InstructeurUserId",
                principalTable: "Users",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_formations_Users_RHId",
                table: "formations",
                column: "RHId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_formations_Users_InstructeurUserId",
                table: "formations");

            migrationBuilder.DropForeignKey(
                name: "FK_formations_Users_RHId",
                table: "formations");

            migrationBuilder.DropTable(
                name: "congés");

            migrationBuilder.DropTable(
                name: "entretiens");

            migrationBuilder.DropTable(
                name: "salaire");

            migrationBuilder.DropTable(
                name: "jobApplications");

            migrationBuilder.DropTable(
                name: "candidats");

            migrationBuilder.DropTable(
                name: "jobPosts");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "formations");
        }
    }
}
