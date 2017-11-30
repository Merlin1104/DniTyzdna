using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DniTyzdna
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            


            DniTyzdna dni = new DniTyzdna();
            dni.VypisDenTyzdna("2");
            dni.VypisDenTyzdna("3", true);
            
            Console.ReadKey();





        }
        
    }
}
