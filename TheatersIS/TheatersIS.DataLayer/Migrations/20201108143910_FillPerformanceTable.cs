using Microsoft.EntityFrameworkCore.Migrations;

namespace TheatersIS.DataLayer.Migrations
{
    public partial class FillPerformanceTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            INSERT [dbo].[Performances] ( [Name], [PerformanceStatus], [PerformanceGenre], [Author], [Composer]) VALUES (N'Ромео и Джудьетта', 0, 19, N'Лазарева С. В.', N'Сергей Сергеевич Прокофьев')
INSERT [dbo].[Performances] ( [Name], [PerformanceStatus], [PerformanceGenre], [Author], [Composer]) VALUES (N'Любовь к трем апельсинам', 0, 21, N'Карло Гоцци', N'Сергей Сергеевич Прокофьев')
INSERT [dbo].[Performances] ( [Name], [PerformanceStatus], [PerformanceGenre], [Author], [Composer]) VALUES (N'Севильский цирюльник', 0, 9, N'Пьер Бомарше', N'Джоаккино Россини')
INSERT [dbo].[Performances] ( [Name], [PerformanceStatus], [PerformanceGenre], [Author], [Composer]) VALUES (N'Вальсы в атмосфере балла', 1, 18, NULL, N'Иоганн Штраус')
INSERT [dbo].[Performances] ( [Name], [PerformanceStatus], [PerformanceGenre], [Author], [Composer]) VALUES ( N'Симфоническое шоу', 0, 0, NULL, N'Фридерик Шопен')
INSERT [dbo].[Performances] ( [Name], [PerformanceStatus], [PerformanceGenre], [Author], [Composer]) VALUES (N'Алиса в стране чудес', 0, 15, N'Льюис Кэрролл', N'Дэниел Роберт Эльфман')
INSERT [dbo].[Performances] ( [Name], [PerformanceStatus], [PerformanceGenre], [Author], [Composer]) VALUES (N'Симфонический QUEEN', 1, 4, NULL, N'оркестр GosОrchestra')
INSERT [dbo].[Performances] ( [Name], [PerformanceStatus], [PerformanceGenre], [Author], [Composer]) VALUES (N'Буратино', 0, 7, N'Алекскей Николаевич Толстой', N'Алексей Львович Рыбников')
INSERT [dbo].[Performances] ( [Name], [PerformanceStatus], [PerformanceGenre], [Author], [Composer]) VALUES (N'Королевские игры', 0, 11, N'Григорий Израилевич Горин', N'Шандор Каллош')
INSERT [dbo].[Performances] ( [Name], [PerformanceStatus], [PerformanceGenre], [Author], [Composer]) VALUES (N'Пластилин мира', 0, 20, N'Евгений Васильевич Клюев', NULL)
INSERT [dbo].[Performances] ( [Name], [PerformanceStatus], [PerformanceGenre], [Author], [Composer]) VALUES (N'Любовь по контракту', 1, 6, N'Вера Добрая', N'Жанна Богусевич')
INSERT [dbo].[Performances] ( [Name], [PerformanceStatus], [PerformanceGenre], [Author], [Composer]) VALUES (N'Стакатто', 2, 13, N'Дмитрий Михайлович Липскеров', NULL)
INSERT [dbo].[Performances] ( [Name], [PerformanceStatus], [PerformanceGenre], [Author], [Composer]) VALUES (N'Принцесса цирка', 0, 10, N'Альфред Грюнвальд', N'Имре Кальман')
INSERT [dbo].[Performances] ( [Name], [PerformanceStatus], [PerformanceGenre], [Author], [Composer]) VALUES (N'Цыганский барон', 0, 2, N'Мора Йокаи', N'Иоганн Штраус')
INSERT [dbo].[Performances] ( [Name], [PerformanceStatus], [PerformanceGenre], [Author], [Composer]) VALUES (N'Веселые приключения Незнайки', 2, 16, N'Николай Носов', N'Владимир Шаинский')
INSERT [dbo].[Performances] ( [Name], [PerformanceStatus], [PerformanceGenre], [Author], [Composer]) VALUES (N'Русалочка', 0, 5, N'Ханс Кристиан Андерсен', N'Ирина Губаренко')
INSERT [dbo].[Performances] ( [Name], [PerformanceStatus], [PerformanceGenre], [Author], [Composer]) VALUES (N'Мина Мазайло', 0, 14, N'Николай Гуриевич Кулиш', NULL)
INSERT [dbo].[Performances] ( [Name], [PerformanceStatus], [PerformanceGenre], [Author], [Composer]) VALUES (N'Дон Жуан', 0, 9, N'Мольер', N'Вольфганг Амадей Моцарт')
INSERT [dbo].[Performances] ( [Name], [PerformanceStatus], [PerformanceGenre], [Author], [Composer]) VALUES (N'Эй,  хоть кто-то!', 0, 17, N'Уильям Сароян', NULL)
INSERT [dbo].[Performances] ( [Name], [PerformanceStatus], [PerformanceGenre], [Author], [Composer]) VALUES (N'Украденное счастье', 1, 2, N'Иван Яковлевич Франко', N'Владимир Амброс')
INSERT [dbo].[Performances] ( [Name], [PerformanceStatus], [PerformanceGenre], [Author], [Composer]) VALUES (N'Гамлет', 0, 11, N'Уильям Шекспир', NULL)
INSERT [dbo].[Performances] ( [Name], [PerformanceStatus], [PerformanceGenre], [Author], [Composer]) VALUES (N'Дюймовочка', 0, 15, N'Ханс Кристиан Андерсен', N'Никита Богословский')
INSERT [dbo].[Performances] ( [Name], [PerformanceStatus], [PerformanceGenre], [Author], [Composer]) VALUES (N'20 минут с АНГЕЛОМ', 0, 3, N'Александр Валентинович Вампилов', NULL)
INSERT [dbo].[Performances] ( [Name], [PerformanceStatus], [PerformanceGenre], [Author], [Composer]) VALUES (N'Мышеловка', 0, 1, N'Агата Кристи', N'Вениамин Ефимович Баснер')
INSERT [dbo].[Performances] ( [Name], [PerformanceStatus], [PerformanceGenre], [Author], [Composer]) VALUES (N'Маленький принц', 0, 15, N'Антуан де Сент-Экзюпери', N'Микаэл Лионович Таривердиев')
INSERT [dbo].[Performances] ( [Name], [PerformanceStatus], [PerformanceGenre], [Author], [Composer]) VALUES (N'Оскар и розовая дама', 1, 2, N'Эрик-Эмманюэль Шмитт', N'Антон Танонов')
INSERT [dbo].[Performances] ( [Name], [PerformanceStatus], [PerformanceGenre], [Author], [Composer]) VALUES (N'Вождь краснокожих', 0, 15, N'О.Генри', N'Игорь Гайденко')
INSERT [dbo].[Performances] ( [Name], [PerformanceStatus], [PerformanceGenre], [Author], [Composer]) VALUES (N'Золотая рыбка', 0, 15, N'Александр Сергеевич Пушкин', NULL)
INSERT [dbo].[Performances] ( [Name], [PerformanceStatus], [PerformanceGenre], [Author], [Composer]) VALUES (N'Дракула', 2, 16, N'Брэм Стокер', NULL)
INSERT [dbo].[Performances] ( [Name], [PerformanceStatus], [PerformanceGenre], [Author], [Composer]) VALUES (N'Юнона и Авось', 0, 12, N'Андрей Андреевич Вознесенский', N'Алексей Львович Рыбников')
INSERT [dbo].[Performances] ( [Name], [PerformanceStatus], [PerformanceGenre], [Author], [Composer]) VALUES (N'Великие люди мира', 0, 8, N'Николай Надежин', NULL)
INSERT [dbo].[Performances] ( [Name], [PerformanceStatus], [PerformanceGenre], [Author], [Composer]) VALUES (N'Где-то и около', 0, 16, N'Анна Яблонская', NULL)
INSERT [dbo].[Performances] ( [Name], [PerformanceStatus], [PerformanceGenre], [Author], [Composer]) VALUES (N'Котенок на снегу', 1, 11, N'Николай Васильевич Мешков', NULL)
INSERT [dbo].[Performances] ( [Name], [PerformanceStatus], [PerformanceGenre], [Author], [Composer]) VALUES (N'Монолог о важном', 0, 2, N'Мажена Садох', NULL)
");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
