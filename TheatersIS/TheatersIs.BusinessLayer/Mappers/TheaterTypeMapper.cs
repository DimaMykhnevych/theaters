using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheatersIS.DataLayer.Entities;

namespace TheatersIs.BusinessLayer.Mappers
{
    public static class TheaterTypeMapper
    {
        private static Dictionary<string, TheaterTypes> theaterTypesDict = new Dictionary<string, TheaterTypes>()
        {
            { "Театр оперы и балета", TheaterTypes.OperaAndBallet},
            { "Музыкальный", TheaterTypes.Musical},
            { "Филармония", TheaterTypes.Philharmonic},
            { "Молодежный", TheaterTypes.Youth},
            { "Драматический", TheaterTypes.Dramatic },
            { "Авторский", TheaterTypes.Authors },
            { "Детский", TheaterTypes.Childish },
            { "Кукольный", TheaterTypes.Puppet },
            { "Школа-театр", TheaterTypes.TheaterSchool },
            { "Комедийный", TheaterTypes.Comedy},
            { "Театр-кафе", TheaterTypes.TheaterSchool },
            { "Сценической анимаци", TheaterTypes.StageAnimation },
            { "Театр-студия", TheaterTypes.TheaterStudio },
        };

        public static TheaterTypes GetTheaterType(string stringType)
        {
            return theaterTypesDict.GetValueOrDefault(stringType);
        }

        public static string GetTheaterTypeStringGenre(TheaterTypes type)
        {
            return theaterTypesDict.FirstOrDefault(x => x.Value == type).Key;
        }
    }
}
