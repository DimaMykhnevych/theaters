using Microsoft.EntityFrameworkCore.Migrations;

namespace TheatersIS.DataLayer.Migrations
{
    public partial class FillTheaters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
INSERT [dbo].[Theaters] ( [Name], [TheaterType], [AddressId]) VALUES (N'ХНАТОБ', 0, 1)
INSERT [dbo].[Theaters] ( [Name], [TheaterType], [AddressId]) VALUES (N'Дом Органной и Камерной Музыки', 1, 2)
INSERT [dbo].[Theaters] ( [Name], [TheaterType], [AddressId]) VALUES (N'Харьковская филармония', 2, 3)
INSERT [dbo].[Theaters] ( [Name], [TheaterType], [AddressId]) VALUES (N'Молодежный Театр Мадригал', 3, 4)
INSERT [dbo].[Theaters] ( [Name], [TheaterType], [AddressId]) VALUES (N'Театр На жуках', 4, 5)
INSERT [dbo].[Theaters] ( [Name], [TheaterType], [AddressId]) VALUES (N'Дом Актера им. Леся Сердюка', 5, 6)
INSERT [dbo].[Theaters] ( [Name], [TheaterType], [AddressId]) VALUES (N'Харьковский театр «Котелок»', 5, 7)
INSERT [dbo].[Theaters] ( [Name], [TheaterType], [AddressId]) VALUES (N'Театр юного зрителя', 6, 8)
INSERT [dbo].[Theaters] ( [Name], [TheaterType], [AddressId]) VALUES (N'Академический драматический театр имени Тараса Шевченко', 4, 9)
INSERT [dbo].[Theaters] ( [Name], [TheaterType], [AddressId]) VALUES (N'Харьковский театр «Post Scriptum»', 4, 10)
INSERT [dbo].[Theaters] ( [Name], [TheaterType], [AddressId]) VALUES (N'Театр кукол', 7, 11)
INSERT [dbo].[Theaters] ( [Name], [TheaterType], [AddressId]) VALUES (N'Академический русский драматический театр им. А. С. Пушкина',4, 12)
INSERT [dbo].[Theaters] ( [Name], [TheaterType], [AddressId]) VALUES (N'Театр «Лукоморье»', 8, 13)
INSERT [dbo].[Theaters] ( [Name], [TheaterType], [AddressId]) VALUES (N'Театр музыкальной комедии', 9, 14)
INSERT [dbo].[Theaters] ( [Name], [TheaterType], [AddressId]) VALUES (N'Молодежный театр «Винора»',3, 15)
INSERT [dbo].[Theaters] ( [Name], [TheaterType], [AddressId]) VALUES (N'Театр «Котелок»', 5, 16)
INSERT [dbo].[Theaters] ( [Name], [TheaterType], [AddressId]) VALUES (N'Кинотеатр «Пари-комик»', 10, 17)
INSERT [dbo].[Theaters] ( [Name], [TheaterType], [AddressId]) VALUES (N'Театр «Публицист»', 4, 18)
INSERT [dbo].[Theaters] ( [Name], [TheaterType], [AddressId]) VALUES (N'Театр «ПТАХ»', 11, 19)
INSERT [dbo].[Theaters] ( [Name], [TheaterType], [AddressId]) VALUES (N'Театр «Арабески»', 12, 20)
");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
