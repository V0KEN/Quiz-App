using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizAPI.Migrations
{
    /// <inheritdoc />
    public partial class testAnswers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
