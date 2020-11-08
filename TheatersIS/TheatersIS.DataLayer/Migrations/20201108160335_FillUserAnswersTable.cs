using Microsoft.EntityFrameworkCore.Migrations;

namespace TheatersIS.DataLayer.Migrations
{
    public partial class FillUserAnswersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
INSERT [dbo].[UserAnswers] ( [UserId], [VariantId]) VALUES (1, 1)
INSERT [dbo].[UserAnswers] ( [UserId], [VariantId]) VALUES (1, 27)
INSERT [dbo].[UserAnswers] ( [UserId], [VariantId]) VALUES (1, 66)
INSERT [dbo].[UserAnswers] ( [UserId], [VariantId]) VALUES (1, 80)
INSERT [dbo].[UserAnswers] ( [UserId], [VariantId]) VALUES (2, 5)
INSERT [dbo].[UserAnswers] ( [UserId], [VariantId]) VALUES (2, 28)
INSERT [dbo].[UserAnswers] ( [UserId], [VariantId]) VALUES (2, 65)
INSERT [dbo].[UserAnswers] ( [UserId], [VariantId]) VALUES (2, 81)
INSERT [dbo].[UserAnswers] ( [UserId], [VariantId]) VALUES (5, 10)
INSERT [dbo].[UserAnswers] ( [UserId], [VariantId]) VALUES (5, 26)
INSERT [dbo].[UserAnswers] ( [UserId], [VariantId]) VALUES (5, 57)
INSERT [dbo].[UserAnswers] ( [UserId], [VariantId]) VALUES (5, 76)
");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
