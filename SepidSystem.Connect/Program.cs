using System;

namespace SepidSystem.Connect
{
    class Program
    {
        static void Main(string[] args)
        {
            void PrintInfo(IScan coffee) => Console.WriteLine("Card: " + coffee.GetCard() + "; Tag: " + coffee.GetTag());

            IScan s = new SimpleScan();
            PrintInfo(s);

            s = new ScanWithTag(s);
            PrintInfo(s);

            s = new ScanWithBioMini(s);
            PrintInfo(s);



            var scanWithFace = new ScanWithFace(new SimpleScan());
            PrintInfo(scanWithFace);


        }
    }
}
