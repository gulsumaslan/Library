using System;
using System.Collections.Generic;
using System.Linq;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Books> book = new List<Books>
            {
                new Books{ID=1,Name=Messages.Name1,BookAuthor=Messages.Author1,BookPublisher=Messages.Publisher1,BookStock=100},
                new Books{ID=1,Name=Messages.Name2,BookAuthor=Messages.Author2,BookPublisher=Messages.Publisher2,BookStock=1000},
                new Books{ID=1,Name=Messages.Name3,BookAuthor=Messages.Author2,BookPublisher=Messages.Publisher2,BookStock=500},
                new Books{ID=1,Name=Messages.Name4,BookAuthor=Messages.Author2,BookPublisher=Messages.Publisher2,BookStock=100},
                new Books{ID=1,Name=Messages.Name5,BookAuthor=Messages.Author3,BookPublisher=Messages.Publisher3,BookStock=100},

            };

            var results = book.Where(b => b.ID == 1 && b.KitapYazar ==Messages.Author2);
            foreach (var result in results)
            {
                Console.WriteLine(result.Name);

            }

           

            List<Publisher> publishers = new List<Publisher>
            {
                new Publisher{AuthorID=1,PublisherID=2,PublisherName=Messages.Publisher4, AuthorName=Messages.Author3},
                new Publisher{AuthorID=1,PublisherID=2,PublisherName=Messages.Publisher4, AuthorName=Messages.Author4},
                new Publisher{AuthorID=1,PublisherID=2,PublisherName=Messages.Publisher3, AuthorName=Messages.Author4},
                new Publisher{AuthorID=1,YPublisherID=2,PublisherName=Messages.Publisher1, AuthorName=Messages.Author5},
                new Publisher{AuthorID=1,PublisherID=2,PublisherName=Messages.Publisher1, AuthorName=Messages.Author5},

            };
            var results2 = publishers.Where(p => p.PublisherName == Messages.Publisher1);
            foreach (var result2 in results2)
            {
                Console.WriteLine(result2.PublisherID);
            }


            List<BookType> bookTypes = new List<BookType>
            {
                new BookType{GenusID=3,GenusName=Messages.genus1},
                new BookType{GenusID=3,GenusName=Messages.genus2},
                new BookType{GenusID=2,GenusName=Messages.genus3},
                new BookType{GenusID=1,GenusName=Messages.genus4},

            };

            var results4 = bookTypes.Where(b => b.GenusID > 2);
            foreach (var result4 in results4)
            {
                Console.WriteLine(result4.GenusName);

            }

            //List<IPersons> persons = new List<IPersons> { Books, BookType, };


        }
    }

    public static class Messages
    {
        public static string Name1 = "Sırlar kitabi";
        public static string Name2 = "Bin Muhteşem güneş";
        public static string Name3 = "Uçurtma Avcısı";
        public static string Name4 = "Deniz Duası";
        public static string Name5 = "Kader Kuyusu";

        public static string Publisher1= "Omega Yayınevi";
        public static string Publisher2 = "Everest Yayınevi";
        public static string Publisher3 = "İthaki Yayınevi";
        public static string Publisher4 = "Yeni nesil Yayınevi";

        public static string Author1 = "Osho";
        public static string Author2 = "Khaled Hosseini";
        public static string Author3= "Mehmet Uzun";
        public static string Author4 = "Ahmet Arif";
        public static string Author5 = "Cemal Süreyya";

        public static string genus1 = "Roman";
        public static string genus2 = "Hikaye";
        public static string genus3 = "Makale";
        public static string genus4 = "Şiir";

    }
}
