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
                new Books{ID=1,Ad=Messages.Adi1,KitapYazar=Messages.Yazar1,KitapYayinevi=Messages.Yayinevi1,KitapStok=100},
                new Books{ID=1,Ad=Messages.Adi2,KitapYazar=Messages.Yazar2,KitapYayinevi=Messages.Yayinevi2,KitapStok=1000},
                new Books{ID=1,Ad=Messages.Adi3,KitapYazar=Messages.Yazar2,KitapYayinevi=Messages.Yayinevi2,KitapStok=500},
                new Books{ID=1,Ad=Messages.Adi4,KitapYazar=Messages.Yazar2,KitapYayinevi=Messages.Yayinevi2,KitapStok=100},
                new Books{ID=1,Ad=Messages.Adi5,KitapYazar=Messages.Yazar3,KitapYayinevi=Messages.Yayinevi3,KitapStok=100},

            };

            var results = book.Where(b => b.ID == 1 && b.KitapYazar ==Messages.Yazar2);
            foreach (var result in results)
            {
                Console.WriteLine(result.Ad);

            }

           

            List<Publisher> publishers = new List<Publisher>
            {
                new Publisher{YazarID=1,YayineviID=2,YayineviAd=Messages.Yayinevi4, YazarAD=Messages.Yazar3},
                new Publisher{YazarID=1,YayineviID=2,YayineviAd=Messages.Yayinevi4, YazarAD=Messages.Yazar4},
                new Publisher{YazarID=1,YayineviID=2,YayineviAd=Messages.Yayinevi3, YazarAD=Messages.Yazar4},
                new Publisher{YazarID=1,YayineviID=2,YayineviAd=Messages.Yayinevi1, YazarAD=Messages.Yazar5},
                new Publisher{YazarID=1,YayineviID=2,YayineviAd=Messages.Yayinevi1, YazarAD=Messages.Yazar5},

            };
            var results2 = publishers.Where(p => p.YayineviAd == Messages.Yayinevi1);
            foreach (var result2 in results2)
            {
                Console.WriteLine(result2.YayineviID);
            }


            List<BookType> bookTypes = new List<BookType>
            {
                new BookType{TurID=3,TurAD=Messages.tur1},
                new BookType{TurID=3,TurAD=Messages.tur2},
                new BookType{TurID=2,TurAD=Messages.tur3},
                new BookType{TurID=1,TurAD=Messages.tur4},

            };

            var results4 = bookTypes.Where(b => b.TurID > 2);
            foreach (var result4 in results4)
            {
                Console.WriteLine(result4.TurAD);

            }

            //List<IPersons> persons = new List<IPersons> { Books, BookType, };


        }
    }

    public static class Messages
    {
        public static string Adi1 = "Sırlar kitabi";
        public static string Adi2 = "Bin Muhteşem güneş";
        public static string Adi3 = "Uçurtma Avcısı";
        public static string Adi4 = "Deniz Duası";
        public static string Adi5 = "Kader Kuyusu";

        public static string Yayinevi1= "Omega Yayınevi";
        public static string Yayinevi2 = "Everest Yayınevi";
        public static string Yayinevi3 = "İthaki Yayınevi";
        public static string Yayinevi4 = "Yeni nesil Yayınevi";

        public static string Yazar1 = "Osho";
        public static string Yazar2 = "Khaled Hosseini";
        public static string Yazar3= "Mehmet Uzun";
        public static string Yazar4 = "Ahmet Arif";
        public static string Yazar5 = "Cemal Süreyya";

        public static string tur1 = "Roman";
        public static string tur2 = "Hikaye";
        public static string tur3 = "Makale";
        public static string tur4 = "Şiir";

    }
}
