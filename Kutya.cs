using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleKutya
{
    internal class Kutya
    {
        int id;
        string fajta;
        string nev;
        int eletkor;
        string datum;

        public Kutya(int id, string fajta, string nev, int eletkor, string datum)
        {
            this.id = id;
            this.fajta = fajta;
            this.nev = nev;
            this.eletkor = eletkor;
            this.datum = datum;
        }


        public int Id { get => id; set => id = value; }
        public string Fajta { get => fajta; set => fajta = value; }
        public string Nev { get => nev; set => nev = value; }
        public int Eletkor { get => eletkor; set => eletkor = value; }
        public string Datum { get => datum; set => datum = value; }
    }
}
