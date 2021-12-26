using System;

namespace KampKursu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdı = "C#";
            kurs1.Egitmen = "Enes Kaynar";
            kurs1.IzlenmeOranı = 43;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdı = "Java";
            kurs2.Egitmen = "Engin Demiroğ";
            kurs2.IzlenmeOranı = 78;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdı = "Python";
            kurs3.Egitmen = "Berkay Akyol";
            kurs3.IzlenmeOranı = 67;

            //Console.WriteLine( kurs1.KursAdı +" "+ kurs1.Egitmen);
            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdı + " : " + kurs.Egitmen);
            }


        }
    }
    class Kurs
    {
        public string KursAdı { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOranı { get; set; }

    }
}
