using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheatersIS.DataLayer.Entities;

namespace TheatersIs.BusinessLayer.Mappers
{
    public static class PerformanceGenreMapper
    {
        private static Dictionary<string, PerformanceGenre> performanceGenreDict =
            new Dictionary<string, PerformanceGenre>()
            {
                {"Балетная сюита", PerformanceGenre.BalletSuite},
                {"Комедия", PerformanceGenre.Comedy},
                {"Концерт", PerformanceGenre.Concert},
                {"Танцевальное шоу", PerformanceGenre.DanceShow},
                {"Детектив", PerformanceGenre.Detective},
                {"Драма", PerformanceGenre.Drama},
                {"Сказка", PerformanceGenre.FairyTale},
                {"Фьяба", PerformanceGenre.Fiaba},
                {"Лиричкская феерия", PerformanceGenre.LyricExtravaganza},
                {"Мелодрама", PerformanceGenre.Melodrama},
                {"Мюзикл", PerformanceGenre.Musical},
                {"Роман", PerformanceGenre.Novel},
                {"Опера", PerformanceGenre.Opera},
                {"Оперетта", PerformanceGenre.Operetta},
                {"Спектакль-притча", PerformanceGenre.PerformanceParable},
                {"Фантасмагория", PerformanceGenre.Phantasmagoria},
                {"Пьеса", PerformanceGenre.Play},
                {"Рок-опера", PerformanceGenre.RockOpera},
                {"Сатирическая комедия", PerformanceGenre.SatiricalComedy},
                {"Научная фантастика", PerformanceGenre.ScienceFiction},
                {"Спектакль", PerformanceGenre.Spectacle},
                {"Трагедия", PerformanceGenre.Tragedy},
            };

        public static PerformanceGenre GetPerformanceGenre(string genre)
        {
            return performanceGenreDict.GetValueOrDefault(genre);
        }

        public static string GetPerformanceStringGenre(PerformanceGenre genre)
        {
            return performanceGenreDict.FirstOrDefault(x => x.Value == genre).Key;
        }
    }
}
