using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Cotizaciones
    {
        //atributos
        private float calculandoPrecio;
        private int cantidadunidadescotizadas;
        private float resultadoCotizacion;
        public int Fecha { get; set; }
        public int Hora { get; set; }
        public int CantidadUnidades { get; set; }
        public string TipoPrenda { get; set; }
        public string AtributosPrenda { get; set; }

        private float modificadorMangaCorta = 0.1f;
        private float modificadorCuelloMao = 0.03f;
        private float modificadorPremium = 0.3f;
        private float modificadorChupin = 0.12f;

        Camisas prendasCamisas = new Camisas();
        Pantalones prendasPantalones = new Pantalones();
        


        public float CalculandoPrecio { get => calculandoPrecio; set => calculandoPrecio = value; }
        public int Cantidadunidadescotizadas { get => cantidadunidadescotizadas; set => cantidadunidadescotizadas = value; }
        public float ResultadoCotizacion { get => resultadoCotizacion; set => resultadoCotizacion = value; }
        
    


        public void CalcularPrecioCamisas(bool mangaCorta, bool cuelloMao, bool premium, int camisasMangaCortaMaoPremium, int camisasMangaCortaMao, int camisasMangaCortaPremium, int camisasMangaCorta, int camisasLargaMaoPremium, int camisasLargaMao, int camisasLargaPremium, int camisasLarga, float PrecioUnitario)
        {
            //calcular el precio de las mangas cortas
            if (mangaCorta == true)
            {
                CalculandoPrecio = PrecioUnitario - (PrecioUnitario * modificadorMangaCorta);
            }
            else
            {
                CalculandoPrecio = PrecioUnitario;
            }

            //calcular precio del cuello mao
            if (cuelloMao == true)
            {
                CalculandoPrecio = CalculandoPrecio + (CalculandoPrecio * modificadorCuelloMao);
            }
            else 
            {
                CalculandoPrecio = PrecioUnitario;
            }

            if (premium == true)
            {
                ResultadoCotizacion = CalculandoPrecio + (CalculandoPrecio * modificadorPremium);
            }
            else
            {
                ResultadoCotizacion = CalculandoPrecio;
            }

            //definir producto elegido del stock
            if (mangaCorta == true && cuelloMao == true && premium == true)
            {
                camisasMangaCortaMaoPremium = camisasMangaCortaMaoPremium - Cantidadunidadescotizadas;
            }
            else
            {
                if (mangaCorta == true && cuelloMao == true)
                {
                    camisasMangaCortaMao = camisasMangaCortaMao - Cantidadunidadescotizadas;
                }
                else
                {
                    if (mangaCorta == true && premium == true)
                    {
                        camisasMangaCortaPremium = camisasMangaCortaPremium - Cantidadunidadescotizadas;
                    }
                    else
                    {
                        if (mangaCorta == true)
                        {
                            camisasMangaCorta = camisasMangaCorta - Cantidadunidadescotizadas;
                        }
                    }
                }
            }

            if (mangaCorta == false && cuelloMao == true && premium == true)
            {
                camisasLargaMaoPremium = camisasLargaMaoPremium - Cantidadunidadescotizadas;
            }
            else
            {
                if (mangaCorta == false && cuelloMao == true)
                {
                    camisasLargaMao = camisasLargaMao - Cantidadunidadescotizadas;
                }
                else
                {
                    if (mangaCorta == false && premium == true)
                    {
                        camisasLargaPremium = camisasLargaPremium - Cantidadunidadescotizadas;
                    }
                    else
                    {
                        if (mangaCorta == false)
                        {
                            camisasLarga = camisasLarga - Cantidadunidadescotizadas;
                        }
                    }
                }
            }


        }

        public void calculandoPrecioPantalones(bool chupin, bool premium, int pantalonesChupinesPremium, int pantalonesChupines, int pantalonesComunesPremium, int pantalonesComunes, float PrecioUnitario)
        {
            //calcular precio chupines
            if (chupin == true)
            {
                CalculandoPrecio = PrecioUnitario - (PrecioUnitario * modificadorChupin);
            }
            else
            {
                CalculandoPrecio = PrecioUnitario;
            }

            //calcular precio del premium
            if (premium == true)
            {
                ResultadoCotizacion = CalculandoPrecio + (CalculandoPrecio * modificadorPremium);
            }
            else
            {
                ResultadoCotizacion = CalculandoPrecio;
            }

            //definir producto elegido stock
            if (chupin == true && premium == true)
            {
                pantalonesChupinesPremium = pantalonesChupinesPremium - Cantidadunidadescotizadas;
            }
            else
            {
                if (chupin == true)
                {
                    pantalonesChupines = pantalonesChupines - Cantidadunidadescotizadas;
                }
            }

            if (chupin == false && premium == true)
            {
                pantalonesComunesPremium = pantalonesComunesPremium - Cantidadunidadescotizadas;
            }
            else
            {
                if (chupin == false)
                {
                    pantalonesComunes = pantalonesComunes - Cantidadunidadescotizadas;
                }
            }
        }

    }
}
