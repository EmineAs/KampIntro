using System;

namespace Hafta2Odev6
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.UrunAdi = "Yapışmaz Derin Tencere";
            urun1.UrunFiyati = 229.90;

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Yuvarlak Tart Kabı";
            urun2.UrunFiyati = 89.90;

            Urun urun3 = new Urun();
            urun3.UrunAdi = "Metal Termos        ";
            urun3.UrunFiyati = 339.90;


            //Console.WriteLine(kurs1.KursAdi+" "+kurs1.Egitmeni+" "+kurs1.IzlenmeOrani);

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            Console.WriteLine("foreach döngüsü  ile");

            Console.WriteLine("Urun Adı\t\t\t Urun Fiyatı");

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi + "\t\t " + urun.UrunFiyati);
            }


            Console.WriteLine("\nfor döngüsü ile");

            Console.WriteLine("Urun Adı\t\t\t Urun Fiyatı");


            for (int i = 0; i < urunler.Length; i++)
            {

                Console.WriteLine(urunler[i].UrunAdi + "\t\t " + urunler[i].UrunFiyati);


            }

            Console.WriteLine("\nwhile döngüsü ile");

            Console.WriteLine("Urun Adı\t\t\t Urun Fiyatı");

            int j = 0;
            while (j < urunler.Length)
            {

                Console.WriteLine(urunler[j].UrunAdi + "\t\t " + urunler[j].UrunFiyati);
                j++;


            }
        }
    }

    class Urun
    {
        public string UrunAdi { get; set; }
        public double UrunFiyati { get; set; }



    }
}



