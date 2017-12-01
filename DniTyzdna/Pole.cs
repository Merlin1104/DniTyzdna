using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DniTyzdna
{
    class Pole
    {
        public int[] VnutornePole = new int[4] { 10, 4, 5, 6};

        public void VypisPole()
        {
            for (int i=0; i < VnutornePole.Length; i++)
            {
                Console.WriteLine(VnutornePole[i]);
            }
        }

        public void NaplnPole()
        {
            Random r = new Random();
            
            for (int i = 0; i < VnutornePole.Length; i++)
            {
                VnutornePole[i] = r.Next(100);
            }
        }

        

    }
}
