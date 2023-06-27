using System.ComponentModel.Design;
using System.Security.Authentication.ExtendedProtection;

internal class Program
{
    private static void Main(string[] args)
    {
        //type safety - tip güvenliği
        string kategoriEtiketi = "Kategori";
        Console.WriteLine(kategoriEtiketi);
        double faizOrani = 1.45;
        bool sistemeGirisYapmismi = false; // = true

        if (sistemeGirisYapmismi == false)
        {
            Console.WriteLine("Kullanıcı ayarları butonu");
        }

        else
        {
            Console.WriteLine("Giriş yap butınu");
        }
        
    }
}