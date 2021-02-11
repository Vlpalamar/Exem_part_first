using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp25.Models.RelationShip
{
    public class DiscGeners
    {

        public int discId { get; set; }
        public Disc disc { get; set; }

        public int genreId { get; set; }
        public Genre genre { get; set; }
    }
}
