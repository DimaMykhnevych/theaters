using Microsoft.EntityFrameworkCore.Migrations;

namespace TheatersIS.DataLayer.Migrations
{
    public partial class FillUsersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
INSERT [dbo].[Users] ( [FullName], [BirthDate], [Email], [TelephoneNumber]) VALUES (N'Петров И. К.', CAST(N'2000-09-11T00:00:00.000' AS DateTime), N'petrov@gmail.com', N'+380589323457')
INSERT [dbo].[Users] ( [FullName], [BirthDate], [Email], [TelephoneNumber]) VALUES (N'Сидорова А. Ю', CAST(N'1987-09-02T00:00:00.000' AS DateTime), N'sidorova@gmail.com', N'+380554420909')
INSERT [dbo].[Users] ( [FullName], [BirthDate], [Email], [TelephoneNumber]) VALUES (N'Иванова Л.М.', CAST(N'1993-01-15T00:00:00.000' AS DateTime), N'ivanova@gmail.com', N'+380684558276')
INSERT [dbo].[Users] ( [FullName], [BirthDate], [Email], [TelephoneNumber]) VALUES (N'Алексеев К.Н.', CAST(N'2002-12-11T00:00:00.000' AS DateTime), N'alekseev@gmail.com', N'+380969668243')
INSERT [dbo].[Users] ( [FullName], [BirthDate], [Email], [TelephoneNumber]) VALUES (N'Михайлов П.И.', CAST(N'1995-07-27T00:00:00.000' AS DateTime), N'mihailov@gmail.com', N'+380669437812')
INSERT [dbo].[Users] ( [FullName], [BirthDate], [Email], [TelephoneNumber]) VALUES (N'Яковчук Н. М.', CAST(N'1982-03-17T00:00:00.000' AS DateTime), N'yakovchuk@gmail.com', N'+380569112345')
INSERT [dbo].[Users] ( [FullName], [BirthDate], [Email], [TelephoneNumber]) VALUES (N'Соколова И. В.', CAST(N'1974-02-28T00:00:00.000' AS DateTime), N'sokolova@gmail.com', N'+380993448912')
INSERT [dbo].[Users] ( [FullName], [BirthDate], [Email], [TelephoneNumber]) VALUES (N'Селезнев Р. Н.', CAST(N'2020-04-19T00:00:00.000' AS DateTime), N'seleznev@gmail.com', N'+380781284499')
INSERT [dbo].[Users] ( [FullName], [BirthDate], [Email], [TelephoneNumber]) VALUES (N'Лазарева С. В.', CAST(N'2021-06-04T00:00:00.000' AS DateTime), N'lazareva@gmail.com', N'+380963447812')
INSERT [dbo].[Users] ( [FullName], [BirthDate], [Email], [TelephoneNumber]) VALUES (N'Крамар О.П.', CAST(N'2020-05-06T00:00:00.000' AS DateTime), N'kramar@gmail.com', N'+380981998345')
");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
