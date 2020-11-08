using Microsoft.EntityFrameworkCore.Migrations;

namespace TheatersIS.DataLayer.Migrations
{
    public partial class FillQuestionsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
INSERT [dbo].[Questions] ( [Text]) VALUES (N'Какой жанр вам нравится больше всего?')
INSERT [dbo].[Questions] ( [Text]) VALUES (N'Какой ваш любимый автор?')
INSERT [dbo].[Questions] ( [Text]) VALUES (N'Какой ваш любимый композитор?')
INSERT [dbo].[Questions] ( [Text]) VALUES (N'Какой тип театра вам нравится больше всего?')
");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
