using Microsoft.EntityFrameworkCore.Migrations;

namespace TheatersIS.DataLayer.Migrations
{
    public partial class FillTheaterPerformanceTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
INSERT [dbo].[TheaterPerformances] ( [TheaterId], [PerformanceId], [PerformanceDate], [TicketPrice]) VALUES (2, 1, CAST(N'2020-09-24T18:00:00.000' AS DateTime), 100)
INSERT [dbo].[TheaterPerformances] ( [TheaterId], [PerformanceId], [PerformanceDate], [TicketPrice]) VALUES (2, 2, CAST(N'2020-09-01T17:00:00.000' AS DateTime), 120)
INSERT [dbo].[TheaterPerformances] ( [TheaterId], [PerformanceId], [PerformanceDate], [TicketPrice]) VALUES (2, 3, CAST(N'2020-09-02T15:00:00.000' AS DateTime), 70)
INSERT [dbo].[TheaterPerformances] ( [TheaterId], [PerformanceId], [PerformanceDate], [TicketPrice]) VALUES (3, 4, CAST(N'2020-09-03T16:30:00.000' AS DateTime), 80)
INSERT [dbo].[TheaterPerformances] ( [TheaterId], [PerformanceId], [PerformanceDate], [TicketPrice]) VALUES (3, 5, CAST(N'2020-09-04T15:00:00.000' AS DateTime), 90)
INSERT [dbo].[TheaterPerformances] ( [TheaterId], [PerformanceId], [PerformanceDate], [TicketPrice]) VALUES (4, 6, CAST(N'2020-09-05T20:00:00.000' AS DateTime), 110)
INSERT [dbo].[TheaterPerformances] ( [TheaterId], [PerformanceId], [PerformanceDate], [TicketPrice]) VALUES (4, 7, CAST(N'2020-09-06T17:30:00.000' AS DateTime), 120)
INSERT [dbo].[TheaterPerformances] ( [TheaterId], [PerformanceId], [PerformanceDate], [TicketPrice]) VALUES (5, 8, CAST(N'2020-09-07T12:00:00.000' AS DateTime), 140)
INSERT [dbo].[TheaterPerformances] ( [TheaterId], [PerformanceId], [PerformanceDate], [TicketPrice]) VALUES (6, 9, CAST(N'2020-09-08T20:45:00.000' AS DateTime), 50)
INSERT [dbo].[TheaterPerformances] ( [TheaterId], [PerformanceId], [PerformanceDate], [TicketPrice]) VALUES (6, 10, CAST(N'2020-09-09T21:20:00.000' AS DateTime), 60)
INSERT [dbo].[TheaterPerformances] ( [TheaterId], [PerformanceId], [PerformanceDate], [TicketPrice]) VALUES (7, 11, CAST(N'2020-09-10T14:25:00.000' AS DateTime), 80)
INSERT [dbo].[TheaterPerformances] ( [TheaterId], [PerformanceId], [PerformanceDate], [TicketPrice]) VALUES (7, 12, CAST(N'2020-09-11T11:00:00.000' AS DateTime), 40)
INSERT [dbo].[TheaterPerformances] ( [TheaterId], [PerformanceId], [PerformanceDate], [TicketPrice]) VALUES (8, 13, CAST(N'2020-09-12T19:45:00.000' AS DateTime), 95)
INSERT [dbo].[TheaterPerformances] ( [TheaterId], [PerformanceId], [PerformanceDate], [TicketPrice]) VALUES (8, 14, CAST(N'2020-09-13T18:00:00.000' AS DateTime), 55)
INSERT [dbo].[TheaterPerformances] ( [TheaterId], [PerformanceId], [PerformanceDate], [TicketPrice]) VALUES (9, 15, CAST(N'2020-09-11T11:00:00.000' AS DateTime), 70)
INSERT [dbo].[TheaterPerformances] ( [TheaterId], [PerformanceId], [PerformanceDate], [TicketPrice]) VALUES (9, 16, CAST(N'2020-09-15T13:50:00.000' AS DateTime), 120)
INSERT [dbo].[TheaterPerformances] ( [TheaterId], [PerformanceId], [PerformanceDate], [TicketPrice]) VALUES (10, 17, CAST(N'2020-09-16T17:20:00.000' AS DateTime), 150)
INSERT [dbo].[TheaterPerformances] ( [TheaterId], [PerformanceId], [PerformanceDate], [TicketPrice]) VALUES (10, 18, CAST(N'2020-09-17T10:00:00.000' AS DateTime), 200)
INSERT [dbo].[TheaterPerformances] ( [TheaterId], [PerformanceId], [PerformanceDate], [TicketPrice]) VALUES (11, 19, CAST(N'2020-09-18T14:45:00.000' AS DateTime), 220)
INSERT [dbo].[TheaterPerformances] ( [TheaterId], [PerformanceId], [PerformanceDate], [TicketPrice]) VALUES (11, 20, CAST(N'2020-09-19T23:00:00.000' AS DateTime), 180)
INSERT [dbo].[TheaterPerformances] ( [TheaterId], [PerformanceId], [PerformanceDate], [TicketPrice]) VALUES (12, 21, CAST(N'2020-09-20T19:10:00.000' AS DateTime), 100)
INSERT [dbo].[TheaterPerformances] ( [TheaterId], [PerformanceId], [PerformanceDate], [TicketPrice]) VALUES (12, 22, CAST(N'2020-09-21T18:00:00.000' AS DateTime), 120)
INSERT [dbo].[TheaterPerformances] ( [TheaterId], [PerformanceId], [PerformanceDate], [TicketPrice]) VALUES (13, 23, CAST(N'2020-09-22T18:30:00.000' AS DateTime), 140)
INSERT [dbo].[TheaterPerformances] ( [TheaterId], [PerformanceId], [PerformanceDate], [TicketPrice]) VALUES (14, 25, CAST(N'2020-09-23T18:10:00.000' AS DateTime), 85)
INSERT [dbo].[TheaterPerformances] ( [TheaterId], [PerformanceId], [PerformanceDate], [TicketPrice]) VALUES (14, 26, CAST(N'2020-09-24T08:00:00.000' AS DateTime), 75)
INSERT [dbo].[TheaterPerformances] ( [TheaterId], [PerformanceId], [PerformanceDate], [TicketPrice]) VALUES (15, 27, CAST(N'2020-09-25T15:40:00.000' AS DateTime), 45)
INSERT [dbo].[TheaterPerformances] ( [TheaterId], [PerformanceId], [PerformanceDate], [TicketPrice]) VALUES (15, 13, CAST(N'2020-09-26T10:15:00.000' AS DateTime), 110)
INSERT [dbo].[TheaterPerformances] ( [TheaterId], [PerformanceId], [PerformanceDate], [TicketPrice]) VALUES (15, 14, CAST(N'2020-09-27T12:30:00.000' AS DateTime), 105)
INSERT [dbo].[TheaterPerformances] ( [TheaterId], [PerformanceId], [PerformanceDate], [TicketPrice]) VALUES (16, 28, CAST(N'2020-09-28T22:10:00.000' AS DateTime), 75)
INSERT [dbo].[TheaterPerformances] ( [TheaterId], [PerformanceId], [PerformanceDate], [TicketPrice]) VALUES (16, 29, CAST(N'2020-09-29T21:00:00.000' AS DateTime), 90)
INSERT [dbo].[TheaterPerformances] ( [TheaterId], [PerformanceId], [PerformanceDate], [TicketPrice]) VALUES (17, 30, CAST(N'2020-09-30T19:35:00.000' AS DateTime), 80)
INSERT [dbo].[TheaterPerformances] ( [TheaterId], [PerformanceId], [PerformanceDate], [TicketPrice]) VALUES (17, 13, CAST(N'2020-10-01T18:20:00.000' AS DateTime), 110)
INSERT [dbo].[TheaterPerformances] ( [TheaterId], [PerformanceId], [PerformanceDate], [TicketPrice]) VALUES (17, 14, CAST(N'2020-10-02T19:15:00.000' AS DateTime), 105)
INSERT [dbo].[TheaterPerformances] ( [TheaterId], [PerformanceId], [PerformanceDate], [TicketPrice]) VALUES (18, 31, CAST(N'2020-10-03T23:50:00.000' AS DateTime), 115)
INSERT [dbo].[TheaterPerformances] ( [TheaterId], [PerformanceId], [PerformanceDate], [TicketPrice]) VALUES (19, 32, CAST(N'2020-09-02T15:00:00.000' AS DateTime), 90)
INSERT [dbo].[TheaterPerformances] ( [TheaterId], [PerformanceId], [PerformanceDate], [TicketPrice]) VALUES (20, 33, CAST(N'2020-09-23T18:10:00.000' AS DateTime), 85)
INSERT [dbo].[TheaterPerformances] ( [TheaterId], [PerformanceId], [PerformanceDate], [TicketPrice]) VALUES (21, 34, CAST(N'2020-09-22T18:30:00.000' AS DateTime), 140)
INSERT [dbo].[TheaterPerformances] ( [TheaterId], [PerformanceId], [PerformanceDate], [TicketPrice]) VALUES (3, 7, CAST(N'2020-09-08T20:45:00.000' AS DateTime), 190)
INSERT [dbo].[TheaterPerformances] ( [TheaterId], [PerformanceId], [PerformanceDate], [TicketPrice]) VALUES (9, 8, CAST(N'2020-09-06T17:30:00.000' AS DateTime), 290)
INSERT [dbo].[TheaterPerformances] ( [TheaterId], [PerformanceId], [PerformanceDate], [TicketPrice]) VALUES (9, 22, CAST(N'2020-09-26T10:15:00.000' AS DateTime), 100)
INSERT [dbo].[TheaterPerformances] ( [TheaterId], [PerformanceId], [PerformanceDate], [TicketPrice]) VALUES (20, 14, CAST(N'2020-10-01T18:20:00.000' AS DateTime), 120)
INSERT [dbo].[TheaterPerformances] ( [TheaterId], [PerformanceId], [PerformanceDate], [TicketPrice]) VALUES (21, 21, CAST(N'2020-09-12T19:45:00.000' AS DateTime), 110)
INSERT [dbo].[TheaterPerformances] ( [TheaterId], [PerformanceId], [PerformanceDate], [TicketPrice]) VALUES (10, 20, CAST(N'2020-09-04T15:00:00.000' AS DateTime), 95)
INSERT [dbo].[TheaterPerformances] ( [TheaterId], [PerformanceId], [PerformanceDate], [TicketPrice]) VALUES (8, 17, CAST(N'2020-09-01T17:00:00.000' AS DateTime), 80)
INSERT [dbo].[TheaterPerformances] ( [TheaterId], [PerformanceId], [PerformanceDate], [TicketPrice]) VALUES (19, 26, CAST(N'2020-09-01T17:00:00.000' AS DateTime), 70)
");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
