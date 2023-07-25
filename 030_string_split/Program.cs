using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// split ayırmak bölmek
class Program
{
    static void Main(string[] args)
    {
        string cumle = "Yeni Firma       Hayırlı,Uğurlu Olsun";
        Console.WriteLine(cumle);
        Console.WriteLine("-------------------");
        var kelimeler = cumle.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (var item in kelimeler)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine(kelimeler.Length + " tane kelime var");

    }
}