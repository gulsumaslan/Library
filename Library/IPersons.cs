using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    interface IPersons
    {
        public int ID { get; set; }
        public string Name { get; set; }
       

        void Show();
    }
    //interface SurName { 

    //    void surname()
    //    {
    //        Console.WriteLine("enter surname:");
    //    }
    //}





}
