using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCore
{
    public class Salle
    {
        private int numsalle { get; set; }
        public int capacite { get; set; }
        private float taillecarant { get; set; }
        private bool disponibilite { get; set; }
        private PlageHoraire seance { get; set; }
        public Salle(int numsalle, int capacite, float tailleecrant, bool disponibilite, PlageHoraire seance)
        {
            this.numsalle = numsalle;
            this.capacite = capacite;
            this.taillecarant = tailleecrant;
            this.disponibilite = disponibilite;
            this.seance = seance;

        }
    }

}

