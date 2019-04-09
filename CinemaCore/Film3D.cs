using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCore
{
    public class Film3D : Film
    {
        public string Equipement { get; set; }
        public Film3D()
        {

        }

        public Film3D(int Id, string Titre, DateTime DateSortie, string Realisateur, string Genre, TimeSpan Duree, string equipement) : base(Id, Titre, DateSortie, Realisateur, Genre, Duree)
        {
            Equipement = equipement;
        }

    }
}
