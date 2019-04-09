using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCore
{
    public class FilmNotFoundException : Exception
    {
        public FilmNotFoundException() : base("Exception : Le film n'existe pas dans la liste")
        {

        }
    }
}
