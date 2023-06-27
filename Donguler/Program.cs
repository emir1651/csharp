internal class Program
{
    private static void Main(string[] args)
    {

        string[] kurslar = new string[] { "a", "b", "c" };


        for (int i = 0; i < kurslar.Length; i++)  //İkişer arttırmak için i+=2
        {
            Console.WriteLine(kurslar[i]);
        }
        Console.WriteLine("sayfa sonu");

        foreach (string kurs in kurslar)
        {
            Console.WriteLine(kurs);
        }
    }
}