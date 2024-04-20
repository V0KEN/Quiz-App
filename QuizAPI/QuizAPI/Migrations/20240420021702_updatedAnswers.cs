using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizAPI.Migrations
{
    /// <inheritdoc />
    public partial class updatedAnswers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "QnInWords",
                table: "Questions",
                type: "nvarchar(250)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)");

            migrationBuilder.AlterColumn<string>(
                name: "Option4",
                table: "Questions",
                type: "nvarchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "Option3",
                table: "Questions",
                type: "nvarchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "Option2",
                table: "Questions",
                type: "nvarchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "Option1",
                table: "Questions",
                type: "nvarchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Participants",
                type: "nvarchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Participants",
                type: "nvarchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QnId",
                keyValue: 1,
                column: "Answer",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QnId",
                keyValue: 2,
                column: "Answer",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QnId",
                keyValue: 3,
                column: "Answer",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QnId",
                keyValue: 4,
                column: "Answer",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QnId",
                keyValue: 5,
                column: "Answer",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QnId",
                keyValue: 6,
                column: "Answer",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QnId",
                keyValue: 7,
                column: "Answer",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QnId",
                keyValue: 8,
                column: "Answer",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QnId",
                keyValue: 9,
                column: "Answer",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QnId",
                keyValue: 10,
                column: "Answer",
                value: 2);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "QnInWords",
                table: "Questions",
                type: "nvarchar(250)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Option4",
                table: "Questions",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Option3",
                table: "Questions",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Option2",
                table: "Questions",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Option1",
                table: "Questions",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Participants",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Participants",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QnId",
                keyValue: 1,
                column: "Answer",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QnId",
                keyValue: 2,
                column: "Answer",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QnId",
                keyValue: 3,
                column: "Answer",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QnId",
                keyValue: 4,
                column: "Answer",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QnId",
                keyValue: 5,
                column: "Answer",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QnId",
                keyValue: 6,
                column: "Answer",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QnId",
                keyValue: 7,
                column: "Answer",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QnId",
                keyValue: 8,
                column: "Answer",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QnId",
                keyValue: 9,
                column: "Answer",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QnId",
                keyValue: 10,
                column: "Answer",
                value: 3);
        }
    }
}
