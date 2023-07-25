class Kisi
{
    public int SiraNo { get; set; }
    public string Adi { get; set; }
    public string Soyadi { get; set; }
    public void Hakkinda()
    {
        Console.WriteLine(Adi + " " + Soyadi);
    }
}
class Matematik
{
    public static double PI = 3.14;
    public static int Karesi(int sayi)
    {
        return sayi * sayi;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Kisi kisi1 = new Kisi { Adi = "Özge", Soyadi = "bb" };
        Kisi kisi2 = new Kisi { Adi = "Lizge", Soyadi = "dd" };

        kisi1.Hakkinda();
        kisi2.Hakkinda();

        Console.WriteLine(Matematik.Karesi(5));
        Console.WriteLine(2.5 * Matematik.PI);
    }
}
