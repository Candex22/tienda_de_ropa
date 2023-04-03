using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Prenda
    {
        //atributos
        protected bool premium = false;

        protected float precioUnitario;
        protected int stockTotal;

        //propiedades
        public float PrecioUnitario
        {
            get
            {
                return precioUnitario;
            }
            set
            {
                precioUnitario = value;
            }
        }

        public int StockTotal
        {
            get
            {
                return stockTotal;
            }
            set
            {
                stockTotal = value;
            }
        }

        public bool Premium
        {
            get
            {
                return premium;
            }
            set
            {
                premium = value;
            }
        }
    }
}

