using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GEMSRegistration.Migrations
{
    public partial class INITIAL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LocationName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationID);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FName = table.Column<string>(maxLength: 15, nullable: false),
                    LName = table.Column<string>(maxLength: 20, nullable: false),
                    Phone = table.Column<string>(maxLength: 11, nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    Affiliation = table.Column<string>(nullable: true),
                    ContactFName = table.Column<string>(maxLength: 15, nullable: true),
                    ContactLName = table.Column<string>(maxLength: 15, nullable: true),
                    Age = table.Column<int>(nullable: true),
                    RegistrationDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Workshops",
                columns: table => new
                {
                    WorkshopID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    WorkshopName = table.Column<string>(nullable: false),
                    WorkshopDescription = table.Column<string>(nullable: false),
                    FacilitatorID = table.Column<int>(nullable: true),
                    ParticipantID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workshops", x => x.WorkshopID);
                    table.ForeignKey(
                        name: "FK_Workshops_Persons_FacilitatorID",
                        column: x => x.FacilitatorID,
                        principalTable: "Persons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Workshops_Persons_ParticipantID",
                        column: x => x.ParticipantID,
                        principalTable: "Persons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Attendees",
                columns: table => new
                {
                    AttendeeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Quantity = table.Column<int>(nullable: false),
                    WorkshopID = table.Column<int>(nullable: true),
                    LocationID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendees", x => x.AttendeeID);
                    table.ForeignKey(
                        name: "FK_Attendees_Locations_LocationID",
                        column: x => x.LocationID,
                        principalTable: "Locations",
                        principalColumn: "LocationID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Attendees_Workshops_WorkshopID",
                        column: x => x.WorkshopID,
                        principalTable: "Workshops",
                        principalColumn: "WorkshopID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attendees_LocationID",
                table: "Attendees",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_Attendees_WorkshopID",
                table: "Attendees",
                column: "WorkshopID");

            migrationBuilder.CreateIndex(
                name: "IX_Workshops_FacilitatorID",
                table: "Workshops",
                column: "FacilitatorID");

            migrationBuilder.CreateIndex(
                name: "IX_Workshops_ParticipantID",
                table: "Workshops",
                column: "ParticipantID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attendees");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Workshops");

            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
