using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DniTyzdna
{
    class DniTyzdna
    {
        public static void VypisDenTyzdna(string den)
        {
            int denTyzdna = int.Parse(den);
            if (SkontrolujVstup(denTyzdna))
            {
                switch (denTyzdna)
                {
                    case 0:
                    case 7: Console.WriteLine("Nedela"); break;  //pre 0 a 7 bere nedelu
                    case 1: Console.WriteLine("Pondelok"); break;
                    case 2: Console.WriteLine("Utorok"); break;
                    case 3: Console.WriteLine("Streda"); break;
                    case 4: Console.WriteLine("Stvrtok"); break;
                    case 5: Console.WriteLine("Piatok"); break;
                    case 6: Console.WriteLine("Sobota"); break;

                    default:
                        Console.WriteLine("Zadali ste nespravne cislo");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Spatny vstup");
            }

            
        }
        
        

        
        public static void VypisDenTyzdna(string den, bool nedeleJePrvni)
        {
            int denTyzdna = int.Parse(den);
            if (SkontrolujVstup(denTyzdna))
            {
                if (nedeleJePrvni)
                {
                    denTyzdna--;
                }
                VypisDenTyzdna(denTyzdna.ToString());
            }
            
            else
            {
                Console.WriteLine("Spatny vstup");
            }

            
            /*
            switch (denTyzdna)
            {
                case 1: Console.WriteLine("Pondelok"); break;
                case 2: Console.WriteLine("Utorok"); break;
                case 3: Console.WriteLine("Streda"); break;
                case 4: Console.WriteLine("Stvrtok"); break;
                case 5: Console.WriteLine("Piatok"); break;
                case 6: Console.WriteLine("Sobota"); break;
                case 7: Console.WriteLine("Nedela"); break;
                default:
                    Console.WriteLine("Zadali ste nespravne cislo");
                    break;
            }
            */
            /*
            if (nedeleJePrvni == true)
            {
                Console.WriteLine("Prvy den je nedela");
            }
            else
            {
                Console.WriteLine("Prvy den je pondelok");
            }*/
        }
        public static bool SkontrolujVstup(int cisloDna) // ak je podmienka true tak ju vrati, ten vyraz v zatvorke je true
        {

            return (cisloDna >= 1 && cisloDna <= 7);
            
        }


    }
}
