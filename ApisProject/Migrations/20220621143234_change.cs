using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApisProject.Migrations
{
    public partial class change : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Camps_Location_LocationId",
                table: "Camps");

            migrationBuilder.AlterColumn<int>(
                name: "LocationId",
                table: "Camps",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Camps_Location_LocationId",
                table: "Camps",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Camps_Location_LocationId",
                table: "Camps");

            migrationBuilder.AlterColumn<int>(
                name: "LocationId",
                table: "Camps",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Camps_Location_LocationId",
                table: "Camps",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "LocationId");
        }
    }
}
