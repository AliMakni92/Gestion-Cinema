using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCore
{
    public class Cinema
    {
        private int id { get; set; }
        private string Nom { get; set; }
        private string address { get; set; }
        public List<Salle> listesalles;

        public Cinema(int id, string nom, string address, List<Salle> listesalles)
        {
            this.id = id;
            this.Nom = nom;
            this.address = address;
            this.listesalles = listesalles;
        }
        public static int operator +(Cinema a)
        {
            int tot = 0;
            foreach (var item in a.listesalles)
            {
                tot += item.capacite;
            }
            return tot;
        }
    }


}
}
