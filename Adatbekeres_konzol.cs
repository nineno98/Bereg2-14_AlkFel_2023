using System;
using System.Collections.Generic;

namespace hazifeladat
{
    class MainClass
    {
        public static float getNumber()
        {
            float BekertSzam;
            while (true)
            {
                try
                {
                    Console.WriteLine("Add meg a következő számot!");
                    BekertSzam = (float) Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("##########################################\n" +
                        "Hiba!\n" + ex + "\n Próbáld újra!\n"
                        + "##########################################");
                }
            }
            return BekertSzam;
        }
        public static List<float> getLista()
        {
            float number;    
            List<float> BekertSzamLista = new List<float>();
            do
            {
                number = getNumber();
                if (number != 0)
                    BekertSzamLista.Add(number);

            } while (number != 0);
            return BekertSzamLista;
        }
        public static float Osszeg(List<float> lista)
        {
            float osszeg;
            osszeg = 0;
            foreach (float item in lista)
                osszeg += item;
            return osszeg;
        }
        public static void Main(string[] args)
        {
            List<float> SzamLista = new List<float>();
            SzamLista = getLista();
            Console.WriteLine("A bevitt számok: ");
            Console.WriteLine(string.Join("\n", SzamLista));
            Console.WriteLine("A számok összege:"+ Osszeg(SzamLista));                    
        }
    }
}