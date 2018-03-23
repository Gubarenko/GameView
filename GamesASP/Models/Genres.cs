using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GamesASP.Models
{
    public class Genres
    {
        // ID разработчика
        public int Id { get; set; }
        // название компании
        public string Genry { get; set; }
        
        public virtual ICollection<Game> Games { get; set; }
        public Genres()
        {
            Games = new List<Game>();
        }
    }
}