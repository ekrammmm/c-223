using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory
{
    internal class model
    {
        public string num { set; get; }
        public string count { set; get; }
        public String invontarynum { set; get; }
        public double price { set; get; }
        public string object_name { set; get; }
        public string date { set; get; }
        public void save()
        {
            Console.WriteLine("saved successfully");
        }

    }
}
