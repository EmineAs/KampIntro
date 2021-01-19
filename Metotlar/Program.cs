using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };
            Console.WriteLine("Urun Adı\tUrun Fiyatı\tUrun Açıklaması");
            Console.WriteLine("-------------------------------------------------------------");

            foreach (Urun urun in urunler)
            {

                Console.Write(urun.Adi + "\t\t" + urun.Fiyati + "\t\t" + urun.Aciklama + "\n");

            }

            Console.WriteLine("-------------------Metotlar ---------------------------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, 10);
            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12, 8);

        }
    }
}
