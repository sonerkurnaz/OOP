using System;

namespace Telefon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefon Iphone = new Telefon();
            Telefon Samsung = new Telefon();
            Samsung.Model = "S6";
            Console.WriteLine(Samsung.Model);
            Iphone.Model = "8 Plus";
            Console.WriteLine(Iphone.Model);
            Iphone.AramaYap();
        }
    }
}
