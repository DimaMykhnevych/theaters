using Microsoft.EntityFrameworkCore.Migrations;

namespace TheatersIS.DataLayer.Migrations
{
    public partial class FillingDatabaseWithData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
INSERT [dbo].[Addresses] ([HouseNumber], [StreetName]) VALUES (25, N'Сумская')
INSERT [dbo].[Addresses] ([HouseNumber], [StreetName]) VALUES (11, N'Университетская')
INSERT [dbo].[Addresses] ([HouseNumber], [StreetName]) VALUES (21, N'Рымарская')
INSERT [dbo].[Addresses] ([HouseNumber], [StreetName]) VALUES (132, N'Сумская')
INSERT [dbo].[Addresses] ([HouseNumber], [StreetName]) VALUES (41, N'Астрономическая')
INSERT [dbo].[Addresses] ([HouseNumber], [StreetName]) VALUES (3, N'Красина')
INSERT [dbo].[Addresses] ([HouseNumber], [StreetName]) VALUES (4, N'Красина')
INSERT [dbo].[Addresses] ([HouseNumber], [StreetName]) VALUES (18, N'Полтавский шлях')
INSERT [dbo].[Addresses] ([HouseNumber], [StreetName]) VALUES (9, N'Сумская')
INSERT [dbo].[Addresses] ([HouseNumber], [StreetName]) VALUES (16, N'Гиршмана')
INSERT [dbo].[Addresses] ([HouseNumber], [StreetName]) VALUES (24, N'пл. Конституции')
INSERT [dbo].[Addresses] ([HouseNumber], [StreetName]) VALUES (11, N'Чернышевского')
INSERT [dbo].[Addresses] ([HouseNumber], [StreetName]) VALUES (126, N'Плехановская')
INSERT [dbo].[Addresses] ([HouseNumber], [StreetName]) VALUES (124, N'Плехановская')
INSERT [dbo].[Addresses] ([HouseNumber], [StreetName]) VALUES (7, N'Скрипника')
INSERT [dbo].[Addresses] ([HouseNumber], [StreetName]) VALUES (3, N'Манизера')
INSERT [dbo].[Addresses] ([HouseNumber], [StreetName]) VALUES (30, N'Ярослава Мудрого')
INSERT [dbo].[Addresses] ([HouseNumber], [StreetName]) VALUES (11, N'Искусств')
INSERT [dbo].[Addresses] ([HouseNumber], [StreetName]) VALUES (26, N'Данилевского')
INSERT [dbo].[Addresses] ([HouseNumber], [StreetName]) VALUES (25, N'Харьковская набережная')
");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
