using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Yty.Shared.Repository.Master.Data.Migrations.Migrations
{
    public partial class iniRepoMaster : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.CreateTable(
                name: "Entities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EntityStatus = table.Column<int>(type: "int", nullable: false),
                    VersionMasterMaxVersion = table.Column<long>(type: "bigint", nullable: true),
                    VersonMasterIsCheckedOut = table.Column<bool>(type: "bit", nullable: true),
                    VersonMasterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Version = table.Column<long>(type: "bigint", nullable: true),
                    SystemName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Namespace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PolicyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ForeignId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Repository = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pictures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pictures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Wookie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wookie", x => x.Id);
                });
                     

            migrationBuilder.CreateTable(
                name: "Selfie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WookieId = table.Column<int>(type: "int", nullable: false),
                    PictureId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Selfie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Selfie_Pictures_PictureId",
                        column: x => x.PictureId,
                        principalTable: "Pictures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Selfie_Wookie_WookieId",
                        column: x => x.WookieId,
                        principalTable: "Wookie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

         

            migrationBuilder.CreateIndex(
                name: "IX_Selfie_PictureId",
                table: "Selfie",
                column: "PictureId");

            migrationBuilder.CreateIndex(
                name: "IX_Selfie_WookieId",
                table: "Selfie",
                column: "WookieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.DropTable(
                name: "Entities");

            migrationBuilder.DropTable(
                name: "Selfie");

            migrationBuilder.DropTable(
                name: "Pictures");

            migrationBuilder.DropTable(
                name: "Wookie");
        }
    }
}
