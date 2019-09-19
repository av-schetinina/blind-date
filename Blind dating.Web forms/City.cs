using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blind_dating.Web_forms
{
    public class City
    {
        public string id_city  {get;set;}
        public string name { get; set; }

        public City(string id, string n)
        {
            id_city = id;
            name = n;
        }

        public City()
        {
            id_city = "";
            name = "";
        }
    }
}
