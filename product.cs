using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace save
{
    internal class product
    {
        private static List<product> productList = new List<product>();
        public static List<int> a = new List<int>();
        public string number { get; set; }
        public string date { get; set; }
        public string inventorynumber { get; set; }
        public string objectname { get; set; }
        public string count { get; set; }
        public string price { get; set; }
        public void savee()
        {
            Console.WriteLine("SAVE");
            productList.Add(this);
        }
        public List<product> getall()
        {
            //   modelList.Clear();  
            return productList;
        }


    }
}
