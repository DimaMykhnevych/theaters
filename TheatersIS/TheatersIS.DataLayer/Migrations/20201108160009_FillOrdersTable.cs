using Microsoft.EntityFrameworkCore.Migrations;

namespace TheatersIS.DataLayer.Migrations
{
    public partial class FillOrdersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
INSERT [dbo].[Orders] ( [UserId], [TheaterPerformanceId], [TicketsAmount]) VALUES (1, 50, 1)
INSERT [dbo].[Orders] ( [UserId], [TheaterPerformanceId], [TicketsAmount]) VALUES (2, 59, 1)
INSERT [dbo].[Orders] ( [UserId], [TheaterPerformanceId], [TicketsAmount]) VALUES (3, 66, 2)
INSERT [dbo].[Orders] ( [UserId], [TheaterPerformanceId], [TicketsAmount]) VALUES (4, 53, 2)
INSERT [dbo].[Orders] ( [UserId], [TheaterPerformanceId], [TicketsAmount]) VALUES (5, 54, 1)
INSERT [dbo].[Orders] ( [UserId], [TheaterPerformanceId], [TicketsAmount]) VALUES (6, 58, 2)
INSERT [dbo].[Orders] ( [UserId], [TheaterPerformanceId], [TicketsAmount]) VALUES (7, 69, 4)
INSERT [dbo].[Orders] ( [UserId], [TheaterPerformanceId], [TicketsAmount]) VALUES (8, 46, 3)
INSERT [dbo].[Orders] ( [UserId], [TheaterPerformanceId], [TicketsAmount]) VALUES (9, 49, 2)
INSERT [dbo].[Orders] ( [UserId], [TheaterPerformanceId], [TicketsAmount]) VALUES (10, 60, 1)
INSERT [dbo].[Orders] ( [UserId], [TheaterPerformanceId], [TicketsAmount]) VALUES (1, 55, 5)
INSERT [dbo].[Orders] ( [UserId], [TheaterPerformanceId], [TicketsAmount]) VALUES (2, 46, 2)
INSERT [dbo].[Orders] ( [UserId], [TheaterPerformanceId], [TicketsAmount]) VALUES (7, 56, 2)
INSERT [dbo].[Orders] ( [UserId], [TheaterPerformanceId], [TicketsAmount]) VALUES (10, 56, 4)
");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
