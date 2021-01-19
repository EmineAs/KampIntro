using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad = "Emine";
            int yas = 41;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.Egitmeni = "Engin Demiro";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmeni = "Kerem    ";
            kurs2.IzlenmeOrani = 75;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Phyton";
            kurs3.Egitmeni = "Berkay   ";
            kurs3.IzlenmeOrani = 80;

            //Console.WriteLine(kurs1.KursAdi+" "+kurs1.Egitmeni+" "+kurs1.IzlenmeOrani);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            Console.WriteLine("Kurs Adı\t Kurs Eğitmeni\t Kurs IzlenmeOrani");

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + "\t\t " + kurs.Egitmeni + "\t\t " + kurs.IzlenmeOrani);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmeni { get; set; }
        public int IzlenmeOrani { get; set; }



    }
}
