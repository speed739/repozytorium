using System;
using System.Text;

namespace zajecia_3
{
    class Program
    {
        static void Main(string[] args)
        {

            StringBuilder builder = new StringBuilder();
            string text = string.Empty;
            float suma = 0;
            float wynik = 0;

            while (text != "stop")
            {
                text = Console.ReadLine();
                builder.Append(text + ";");
            }

            string[] oceny = builder.ToString().Split(new[] { "\r", "\n", "stop", ";" }, StringSplitOptions.RemoveEmptyEntries);
            float[] oce = new float[oceny.Length];

            for (int i = 0; i < oce.Length; i++)
            {
                oce[i] = Convert.ToSingle(oceny[i]);
            }

            foreach (float ocena in oce)
            {
                suma += ocena;
            }

            wynik = suma / oce.Length;
            Console.WriteLine(wynik.ToString("0.00"));

            Console.ReadLine();
        }
    }
}