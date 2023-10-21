using EvLibrary;
using System;

namespace EmlakciApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var se = new SatilikEv(2,120,"Satılık Ev",3,150000);
            var se2 = new SatilikEv(3, 140, "Satılık Ev", 4, 200000);
            var ke = new KiralıkEv { Alan = 150, Depozito = 500, Katno = 1, Kira = 600, OdaSayisi = 4, semt = "Kiralık Ev" };
            var ke1 = new KiralıkEv { Alan = 250, Depozito = 800,Katno=4,Kira=900,OdaSayisi=3,semt="Kiralık Ev" };

            Ev[] evler = new Ev[] { se, se2, ke, ke1 };
            for (int i = 0; i < evler.Length; i++)
            {
                if (evler[i] is KiralıkEv)
                {
                    KiralıkEv kev = (KiralıkEv)evler[i];
                    Console.WriteLine( kev.EvBilgileri());

                }
                else
                {
                    SatilikEv sev = (SatilikEv)evler[i];
                    Console.WriteLine(sev.EvBilgileri);
                }
             
            }
         


            

        }
        //class Deneme : ITest
        //{

        //    public void yazdir(string msg)
        //    {

        //    }
        //}
        //interface ITest
        //{
        //    public void yazdir(string msg);

        //}

    }
}
