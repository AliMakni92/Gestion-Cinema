using System;
using CinemaCore;
using System.Collections.Generic;

namespace CinemaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Film3D film1 = new Film3D("Lunette 3D", 1, "Batman VS Superman", new DateTime(2016, 03, 20), "Zack Snyder", "Fantastique", new Time(0, 33, 2));
            Film3D film2 = new Film3D("Lunette 3D", 2, "The Martian", new DateTime(2015, 09, 24), "Ridley Scott", "Science-fiction", new Time(0, 24, 2));
            FilmClassic film3 = new FilmClassic("DTS", 3, "Catch me if you can", new DateTime(2014, 12, 25), "Steven Spielberg", "Drame", new Time(0, 21, 2));
            Film3D film4 = new Film3D("Lunette 3D", 1, "Suicide Squad", new DateTime(2016, 08, 03), "David Ayer", "Fantastique", new Time(0, 10, 2));
            FilmClassic film5 = new FilmClassic("DTS", 1, "The GodFather", new DateTime(1972, 03, 15), "Francis Ford Coppola", "Drame", new Time(0, 58, 2));
            List<Film3D> f1 = new List<Film3D>();

            f1.Add(film1);
            f1.Add(film2);
            f1.Add(film4);
            film1.ToString();
          Console.WriteLine("le premier film est : " +film1.ToString());
            Console.WriteLine("le deuxieme film est : " + film2.ToString());
            Console.WriteLine("le troisieme film est : " + film4.ToString());
            List<Film> f11 = new List<Film>();
           //Film f = new Film();
            Time T = new Time(0, 30, 2);
            Console.WriteLine("Les films de durée supérieure à 2h30 : \n");
            foreach (var f in f11)
            {

                if ((f.Duree.heures > T.heures) && (f.Duree.minutes > T.minutes))
                {
                  
                    Console.WriteLine(f);
                }
               
            }
           
            Console.ReadKey();
        }
    }
}
