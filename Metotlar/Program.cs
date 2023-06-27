//Don't repeat yourself - DRY - Clean Code - Best practice
using Metotlar;

internal class Program
{
    private static void Main(string[] args)
    {
        //string urunAdi = "Elma";
        //double fiyati = 15;
        //string aciklama = "Amasya Elması";

        //string[] meyveler = new string[] { };

        Urun urun1 = new Urun();
        urun1.Adi = "Elma";
        urun1.Fiyati = 15;
        urun1.Aciklama = "Amasya Elması";

        Urun urun2 = new Urun();
        urun2.Adi = "Karpuz";
        urun2.Fiyati = 100;
        urun2.Aciklama = "Diyarbakır karpuzu";

        Urun[] urunler = new Urun[] { urun1,urun2};

        foreach (Urun urun in urunler)
        {
            Console.WriteLine(urun.Adi);
            Console.WriteLine(urun.Fiyati); 
            Console.WriteLine(urun.Aciklama);
            Console.WriteLine("------------------------"); 
        }

        Console.WriteLine("---------------Metotlar----------------");
        
        //instance - örnek
        //encapsulation
        SepetManger sepetManager = new SepetManger();
        sepetManager.Ekle(urun1);
        sepetManager.Ekle(urun2);
        //sepetManager.Ekle2("Armut", "Yeşil armut", 12);
        //sepetManager.Ekle2("Elma", "Yeşil Elma", 10);
        //sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 50);

    }
}



 