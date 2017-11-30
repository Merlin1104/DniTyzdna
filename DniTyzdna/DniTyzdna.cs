using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DniTyzdna
{
    class DniTyzdna
    {
        public void VypisDenTyzdna(string den)
        {
            int a = int.Parse(den);
            

            switch (a)
            {
                case 1: Console.WriteLine("Pondelok"); break;
                case 2: Console.WriteLine("Utorok"); break;
                case 3: Console.WriteLine("Streda"); break;
                case 4: Console.WriteLine("Stvrtok"); break;
                case 5: Console.WriteLine("Piatok"); break;
                case 6: Console.WriteLine("Sobota"); break;
                case 7: Console.WriteLine("Nedela"); break;
                default: Console.WriteLine("Zadali ste nespravne cislo");
                    break;
            }
        }
        public void VypisDenTyzdna(string den, bool nedeleJePrvni)
        {
            int a = int.Parse(den);


            switch (a)
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

            if (nedeleJePrvni == true)
            {
                Console.WriteLine("Prvy den je nedela");
            }
            else
            {
                Console.WriteLine("Prvy den je pondelok");
            }
        }

        
    }
}
