using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCore
{
    public class FilmClassic : Film
    {
        private String qualitesonore { get; set; }
        public FilmClassic(String qualitesonore, int id, String titre, DateTime datesortie, String realisateur, String genre, Time duree) : base(id, titre, datesortie, realisateur, genre, duree)
        {
            this.qualitesonore = qualitesonore;
        }
        public override string ToString()
        {
            return base.ToString() + " Qualité Sonore : " + qualitesonore + "\n";
        }
    }
}
