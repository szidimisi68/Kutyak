using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Kutya
    {
        int id;
        string fajta;
        string nev;
        int eletkor;
        string datum;

        public Kutya(string adatsor)
        {
            string[] felbontottAdatsor = adatsor.Split(";");
            this.id = int.Parse(felbontottAdatsor[0]);
            this.fajta = felbontottAdatsor[1];
            this.nev = felbontottAdatsor[2];
            this.eletkor = int.Parse(felbontottAdatsor[3]);
            this.datum = felbontottAdatsor[4];
        }


        public int Id { get => id; set => id = value; }
        public string Fajta { get => fajta; set => fajta = value; }
        public string Nev { get => nev; set => nev = value; }
        public int Eletkor { get => eletkor; set => eletkor = value; }
        public string Datum { get => datum; set => datum = value; }
    }
}
