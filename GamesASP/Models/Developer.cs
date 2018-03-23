using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GamesASP.Models
{
    public class Developer
    {
        // ID разработчика
        public int Id { get; set; }
        // название компании
        public string DevName { get; set; }
        // логотип компании
        public string LogDev { get; set; }
        // год основания
        public int YearDev { get; set; }
        // описание компании
        public string DescriptionDev { get; set; }
        public virtual ICollection<Game> Games { get; set; }

        public Developer() { Games = new List<Game>(); }
    }
}