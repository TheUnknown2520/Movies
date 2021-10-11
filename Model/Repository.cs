using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Model
{
    public class Repository
    {
        public static readonly List<Studio> studios = new List<Studio>
        {
            new Studio(1, "LA studio", "LA", 6),
            new Studio(2, "CPH Studio", "Copenhagen", 4),
            new Studio(3, "Svenska Duller", "Sverige", 42)
        };

        public static readonly List<Movie> movies = new List<Movie>
        {
            new Movie(1, "Titanic", 1997, 03.14, 1),
            new Movie(2, "Avatar", 2008, 02.42, 2),
            new Movie(3, "Ringenes Herre", 2001, 02.58, 3)
        };

        public static List<Studio> GetStudios()
        {
            return studios;
        }
    }
}
