using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCore
{
    internal class ManageFilms
    {
        public static List<Film> allmovies = new List<Film>();
        public static Film GetFilmByName(string name)
        {
            foreach (var item in allmovies)
            {
                if (item.Titre.Equals(name))
                    return item;
            }
            throw new FilmNotFoundException();
        }
    }
}
