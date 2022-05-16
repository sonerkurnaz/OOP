using Abstracts.Mobilyalar;
using System;

namespace Abstracts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Gitar yamaha = new Gitar();
            Bateri bateri = new Bateri();
            Piano piano = new Piano();

            Muzisyen muzisyen = new Muzisyen();
            muzisyen.Adi = "Ali";
            muzisyen.Soyadi = "Yılmaz";
            muzisyen.CaldigiEnsturman = yamaha;
            muzisyen.CaldigiEnsturman = bateri;
            muzisyen.CaldigiEnsturman = piano;

            muzisyen.GenelYetenek = new Araba();
            muzisyen.GenelYetenek= DateTime.Now;
            muzisyen.GenelYetenek = "Güzel yetenekleri var.";
            muzisyen.GenelYetenek = 12.8f;

            Kanepe istikbal = new Kanepe();
            istikbal.Bazalimi = true;
            istikbal.Renk = "Beyaz";
            istikbal.KumasTuru = "Tay Tuyu";

            istikbal.OzellikleriYaz();

        }
    }
    public class Araba
    {

    }
}
