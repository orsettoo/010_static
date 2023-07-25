enum Gunler
{
    pazartesi,
    sali,
    çarşamba,
    perşembe,
    cuma,
}
enum Mevsim
{
    Ilkbahar = 10,
    yaz = 11,
    Sonbahar = 12,
    Kıs = 13,
}

class Program
{
    static void Main(string[] args)
    {
        Gunler gun = Gunler.cuma;
        if (gun == Gunler.cuma)
        {
            Console.WriteLine("Bu gün =" + gun);
        }

        Mevsim mevsim = Mevsim.Ilkbahar;
        switch (mevsim)
        {
            case Mevsim.Ilkbahar:
                break;
            case Mevsim.yaz:
                break;
            case Mevsim.Sonbahar:
                break;
            case Mevsim Kıs:
                break;
        }
    }
}
