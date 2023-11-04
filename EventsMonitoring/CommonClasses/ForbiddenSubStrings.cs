﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsMonitoring.CommonClasses
{
    public static class ForbiddenSubStrings
    {
        static List<string> fordiddenSubStringsLine = new List<string>()
        {"Настольный", "Хоккейбол", "ITF", "Шорт-хоккей", "Пляжный волейбол", "Лига Про.", "Фьючерс", "Pro Series", "Арена-футбол", "Тайский бокс", "Хоккей на траве",
         "Бильярд", "Сумо", "Австралийский футбол", "Гэльский футбол", "Американский футбол", "Чемпионат ФХР", "Сквош", "Автогонки", "Стрельба из лука", "FIFA23",
         "Волейбол.Любительский турнир", "Киберспорт", "UTR Pro Tennis", "Гран-при", "Снукер", "Бадминтон", "Дартс", "Боулс", "Армрестлинг", "Пул", "LoL", "NHL Draft",
         "Хоккей. XHL", "Открытый чемпионат Лига ПРО", "Overwatch", "Rainbow Six Siege", "Dota", "Rocket League", "Valorant", "KoG", "Counter-Strike", "Маркетинг",
         "Сравнение игроков", "Игроки", "Сравнение результативности", "Участники", "Показатели игроков", "Специальные ставки", "Дополнительные ставки", "Лучший снайпер",
         "Лучший бомбардир", "Сравнение рез-ти игроков", "Лучший бой Вечера", "Кто выиграет больше геймов", "Кто больше забьет", "Какая сборная забьет больше голов",
         "Какая сборная пропустит больше голов", "Какой игрок забьет больше голов", "Игровой день", "Статистика игрового дня", "Игровые часы", "2 матча", "3 матча",
         "4 матча", "5 матчей", "6 матчей", "7 матчей", "8 матчей", "9 матчей", "10 матчей", "11 матчей", "12 матчей", "Итоги", "итоговое место", "кол-во побед",
         "Статистика серии", "Кто выше", "Статистика", "Пара финалистов", "Кто пройдет дальше", "Кто лучше", "Команда из какой", "Кто наберет больше", "просмотр",
         "голы в бол.", "Голы в большинстве", "Что раньше", "угловые", "фолы", "удары в створ", "Кто забьет больше голов", "количество набранных очков",
         "голы в большинстве", "1-й период", "2-й период", "3-й период", "штр. вр.", "вбрас.", "броски", "1-я заброшенная шайба", "кол-во 2-мин удалений", "вбрасывания",
         "Броски в створ ворот", "Штрафное время", "Сумма штрафных минут", "Первая заброшенная шайба", "Формат первой заброшенной шайбы", "Первое 2-х минутное удаление",
         "1-й тайм", "2-й тайм", "жёлтые карты", "офсайды", "штанги или перекладины", "вброс аутов", "удары от ворот", "удары всего", "замены", "пробег",
         "выход мед. бригады на поле", "четверть", "заб/3-х очковые", "половина", "подборы", "передачи", "блоки", "2-х очковые", "3-х очковые", "блокшоты", "иннинг",
         "хиты", "хоум-раны", "1-й сет", "2-й сет", "3-й сет", "4-й сет", "5-й сет", "эйсы", "ошибки на подаче", "двойные ошибки", "% 1-й подачи", "брейкпойнты", "брейки",
         "Экспресс исходы", "Дабл шанс", "Тройной шанс", "Экспресс дня", "1-я(или 2-я)", "2-я(или 1-я)", "Kто лучше", "Кто больше", "бомбардир", "По итогам плей-офф",
         "Показатели игроков", "Победитель", " Показатели", "Cпециальные ставки", "Call of Duty", "Крикет"};


        static List<string> fordiddenSubStringsLive = new List<string>()
        {"NHL", "NBA", "FIFA", "LoL", "Valorant", "Dota", "Counter-Strike", "Call of Duty", "Киберспорт", "Rocket League",
         "Состязание бросков", "Кто выше", "БАЛТBOOST", "Сравнение результативности", "Статистика"};

        static public bool isAllowed(string name, string lineLive)
        {
            if (lineLive == "line")
            {
                foreach (string subString in fordiddenSubStringsLine)
                {
                    if (name.ToLower().Contains(subString.ToLower()))
                        return false;
                }
                return true;
            }
            else
            {
                foreach (string subString in fordiddenSubStringsLive)
                {
                    if (name.ToLower().Contains(subString.ToLower()))
                        return false;
                }
                return true;
            }
        }
    }
}
