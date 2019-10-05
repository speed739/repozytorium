using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int odl = -1, suma = 0, i = 0;
            float srd;

            while(odl!=0)
            {
                string odp = Console.ReadLine();
                odl = Convert.ToInt32(odp);

                suma += odl;
                i++;
            }
            srd = (float)suma / (i - 1);
            Console.WriteLine("Srednia odleglosc - " + srd);
        }
    }
}
