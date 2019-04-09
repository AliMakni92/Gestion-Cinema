using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCore
{
    public class Film
    {
        protected int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        protected String titre;

        public String Titre
        {
            get { return titre; }
            set { titre = value; }
        }
        protected DateTime datesortie;

        public DateTime DateSortie
        {
            get { return datesortie; }
            set { datesortie = value; }
        }
        protected String realisateur;

        public String Realisateur
        {
            get { return realisateur; }
            set { realisateur = value; }
        }
        protected String genre;

        public String Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        protected Time duree;

        public Time Duree
        {
            get { return duree; }
            set { duree = value; }
        }



        public Film()
        {
            this.id = 0;
            this.titre = "";
            this.datesortie = new DateTime();
            this.realisateur = "";
            this.genre = "";
            this.duree = new Time();
        }
        public Film(int id, String titre, DateTime datesortie, String realisateur, String genre, Time duree)
        {
            this.id = id;
            this.titre = titre;
            this.datesortie = datesortie;
            this.realisateur = realisateur;
            this.genre = genre;
            this.duree = duree;
        }
        public override string ToString()
        {
            return "id :" + id + " titre :" + titre + " Date de sortie : " + datesortie + " Réalisateur :" + realisateur + " Genre : " + genre + " Durée :" + duree.heures + "H" + duree.minutes;
        }






    }
}
