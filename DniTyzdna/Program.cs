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


            //DniTyzdna.VypisDenTyzdna("1");
            //DniTyzdna.VypisDenTyzdna("1", true);

            //Cykly.CyklusWhile();
            //Cykly.DoWhile();

            //Cykly.CyklusFor();
            //Cykly.CyklusForParameter(100);
            //Cykly.CyklusForContinue();
            //Cykly.HodnotVSReference();

            //Auto autoPovodne = new Auto();
            //autoPovodne.Barva = "cerna";
            //Cykly.PrefarbiAuto(autoPovodne);



            //Console.WriteLine(autoPovodne.Barva);

            //int aPovodne = 10;
            //Cykly.ZvysOJednicku(ref aPovodne);
            ////Cykly.ZvysOJednicku(aPovodne);
            //Console.WriteLine(aPovodne);

            Pole pole = new Pole();
            pole.NaplnPole();
            pole.VypisPole();

            Console.ReadLine();





        }
        
    }
}
