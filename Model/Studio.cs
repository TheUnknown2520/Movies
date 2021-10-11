using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Model
{
    public class Studio
    {
        public int _id { get; set; }
        public string _name { get; set; }
        public string _hqCity { get; set; }
        public int _noOfEmployees { get; set;   }

        public Studio(int id, string name, string hqCity, int noOfEmployees)
        {
            _id = id;
            _name = name;
            _hqCity = hqCity;
            _noOfEmployees = noOfEmployees;
        }


    }
}
