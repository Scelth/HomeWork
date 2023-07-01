using System;
using System.Collections.Generic;

namespace Download.Data
{
    public class Games
    {
        public static List<Game> Game { get; set; }

        static Games()
        {
            // Инициализируем список игр в статическом конструкторе
            // Initialize the list of games in the static constructor
            Game = new List<Game>
            {
                new Game()
                {
                   Name = "Elden Ring",
                   Studio = "FromSoftware Inc.",
                   ReleaseDate = DateOnly.Parse("2022-02-22"),
                   Description = "Arise, extinguished soul! The intermarriage is waiting for its master. May grace lead you to the Elden Ring.",
                   Genre = new List<string>(){"Action","RPG"}
                },

               new Game()
               {
                   Name = "The Witcher 3: Wild Hunt",
                   ReleaseDate = DateOnly.Parse("2015-05-15"),
                   Description = "You are Geralt of Rivia, a hired monster killer. You are traveling through a world where war is raging and monsters are lurking at every step. You have to fulfill the order and find Ciri — the Child of Destiny, a living weapon that can change the face of this world.",
                   Genre = new List<string>(){"Action","RPG"}
               },
            };
        }
    }
}
