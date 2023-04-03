using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Pantalones : Prenda
    {
        public bool chupin = false;

        public int pantalonesChupinesPremium = 750;
        public int pantalonesChupines = 750;
        public int pantalonesChupinesTotales;

        public int pantalonesComunesPremium = 250;
        public int pantalonesComunes = 250;
        public int pantalonesComunesTotales;

        //constructor
        public Pantalones()
        {
            pantalonesChupinesTotales = pantalonesChupinesPremium + pantalonesChupines;
            pantalonesComunesTotales = pantalonesComunesPremium + pantalonesComunes;
            StockTotal = pantalonesChupinesTotales + pantalonesComunesPremium;
        }
    }
}
