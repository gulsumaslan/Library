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
        public string Name { get; set; }
        public string BookAuthor{ get; set; }
        public string BookPublisher { get; set; }
        public int BookStock { get; set; }
        
        public void Show()
        {
            Console.WriteLine();
        }
    }
}
