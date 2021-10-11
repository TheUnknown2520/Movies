using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Model
{
    public class Movie
    {
        public int _id { get; set; }
        public string _title { get; set; }
        public int _year { get; set; }
        public double _filmDuration { get; set; }
        public int _studioId { get; set; }

        public Movie(int id, string title, int year, double filmDuration, int studioId)
        {
            _id = id;
            _title = title;
            _year = year;
            _filmDuration = filmDuration;
            _studioId = studioId;
        }
    }
}
