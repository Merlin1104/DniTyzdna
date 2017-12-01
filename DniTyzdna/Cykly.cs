using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DniTyzdna
{
    class Cykly
    {
        public static void CyklusWhile()
        {
            int i = 1;
            while (i <= 4)
            {
                Console.WriteLine("Ahoj");
                i++;
            }
        }

        public static void DoWhile()
        {
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;

            } while (i<=4);
        }

        public static void CyklusFor()
        {
            for (int i = 0, j=10; i <= j; i++,j--) //i=i+2 = i+=2
            {
                Console.WriteLine("{0} {1}",i,j);
            }
        }

        public static void CyklusForParameter(int pocetOpakovani)
        {
            
            for (int i = 0; i < pocetOpakovani; i++)
            {
                Console.WriteLine("Vypisujem");
                if (i == 7)
                {
                    break;
                }
            }
        }

        public static void CyklusForContinue()
        {
            for (int i = 0; i <= 10; i++)
            {
                int zbytek = i % 2;
                if (zbytek !=0)
                {
                    continue;
                }

                Console.WriteLine(i);
            }
        }

        public static void HodnotVSReference()
        {
            int hodnota1 = 6;
            int hodnota2;
            hodnota2 = hodnota1;

            hodnota2++;
            Console.WriteLine(hodnota1);
            Console.WriteLine(hodnota2);

            Auto auto1 = new Auto();
            auto1.Barva = "cervena";
            Auto auto2 = auto1;
            auto2.Barva = "cerna";

            Console.WriteLine(auto1.Barva);
            Console.WriteLine(auto2.Barva);
           
        }

        public static void PrefarbiAuto(Auto auto)
        {
            auto.Barva = "biela";
        }
        public static void ZvysOJednicku(ref int a)
        {
            a++;
        }

        public static void ZvysOJednicku(int a)
        {
            a++;
        }
    }
}
