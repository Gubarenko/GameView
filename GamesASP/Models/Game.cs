using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamesASP.Models
{
    public class Game
    {
        // ID игры
        public int Id { get; set; }
        // название игры
        public string GameName { get; set; }
        // логотип игры
        public string LogGame { get; set; }
        // год выпуска
        public int YearGame { get; set; }
        
        // описание игры
        public string DescriptionGame { get; set; }

        public virtual Developer Developer { get; set; }

        public virtual ICollection<Genres> Genres { get; set; }

        public Game() { Genres = new List<Genres>(); }
    }
}