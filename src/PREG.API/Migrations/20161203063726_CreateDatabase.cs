using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PREG.API.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                "ApprovalProcedures",
                table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Created = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 75, nullable: false),
                    Updated = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_ApprovalProcedures", x => x.Id); });

            migrationBuilder.CreateTable(
                "Distributors",
                table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Created = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 75, nullable: false),
                    Updated = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_Distributors", x => x.Id); });

            migrationBuilder.CreateTable(
                "DosageForms",
                table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Created = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 75, nullable: false),
                    Updated = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_DosageForms", x => x.Id); });

            migrationBuilder.CreateTable(
                "ErrandTypeGroups",
                table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Created = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 75, nullable: false),
                    Updated = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_ErrandTypeGroups", x => x.Id); });

            migrationBuilder.CreateTable(
                "Manufacturers",
                table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Created = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 75, nullable: false),
                    Updated = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_Manufacturers", x => x.Id); });

            migrationBuilder.CreateTable(
                "Permissions",
                table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Created = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 75, nullable: false),
                    Updated = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_Permissions", x => x.Id); });

            migrationBuilder.CreateTable(
                "PhaseGroups",
                table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Created = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 75, nullable: false),
                    Updated = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_PhaseGroups", x => x.Id); });

            migrationBuilder.CreateTable(
                "ErrandTypes",
                table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Created = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    ErrandTypeGroupId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 75, nullable: false),
                    Updated = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ErrandTypes", x => x.Id);
                    table.ForeignKey(
                        "FK_ErrandTypes_ErrandTypeGroups_ErrandTypeGroupId",
                        x => x.ErrandTypeGroupId,
                        "ErrandTypeGroups",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "Phases",
                table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Created = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 75, nullable: false),
                    PhaseGroupId = table.Column<int>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phases", x => x.Id);
                    table.ForeignKey(
                        "FK_Phases_PhaseGroups_PhaseGroupId",
                        x => x.PhaseGroupId,
                        "PhaseGroups",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                "IX_ErrandTypes_ErrandTypeGroupId",
                "ErrandTypes",
                "ErrandTypeGroupId");

            migrationBuilder.CreateIndex(
                "IX_Phases_PhaseGroupId",
                "Phases",
                "PhaseGroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                "ApprovalProcedures");

            migrationBuilder.DropTable(
                "Distributors");

            migrationBuilder.DropTable(
                "DosageForms");

            migrationBuilder.DropTable(
                "ErrandTypes");

            migrationBuilder.DropTable(
                "Manufacturers");

            migrationBuilder.DropTable(
                "Permissions");

            migrationBuilder.DropTable(
                "Phases");

            migrationBuilder.DropTable(
                "ErrandTypeGroups");

            migrationBuilder.DropTable(
                "PhaseGroups");
        }
    }
}