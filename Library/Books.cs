using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
   class Books:IPersons
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string KitapYazar { get; set; }
        public string KitapYayinevi { get; set; }
        public int KitapStok { get; set; }
        
        public void Show()
        {
            Console.WriteLine();
        }
    }
}
