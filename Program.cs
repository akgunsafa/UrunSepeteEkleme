using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adı = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adı = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2};

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adı);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------");

            }

            Console.WriteLine("------Metotlar---------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);


            //aşağıdakiler gibi yapma,class oluştur
            sepetManager.Ekle2("Armut", "Yeşil armut", 12,10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 5,9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 30,8);



        }
    }
}
