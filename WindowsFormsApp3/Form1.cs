using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public int aux = 0;
        Cotizaciones Calcular = new Cotizaciones();
        Camisas camisas = new Camisas();
        Pantalones pantalones = new Pantalones();

        public object ListaDeCotizaciones { get; private set; }

        public Form1()
        {
            InitializeComponent();
            radioButtonCamisa.Checked = true;
            radioButtonStandar.Checked = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxMangaCorta_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonStandar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxChupin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonCamisa_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxChupin.Checked = false;
            checkBoxChupin.Enabled = false;
            checkBoxMangaCorta.Enabled = true;
            checkBoxCuelloMao.Enabled = true;

            labelStock.Text = camisas.camisasMangaLarga.ToString();
        }

        private void labelStock_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonPantalon_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxChupin.Enabled = true;
            checkBoxMangaCorta.Enabled = false;
            checkBoxMangaCorta.Checked = false;
            checkBoxCuelloMao.Enabled = false;
            checkBoxCuelloMao.Checked = false;

            labelStock.Text = pantalones.pantalonesComunes.ToString();
        }

        private void buttonCotizar_Click(object sender, EventArgs e)
        {
            try
            {
                int precioUnitario = int.Parse(textBoxPrecioUnitario.Text);

                camisas.mangaCorta = checkBoxMangaCorta.Checked;
                camisas.cuelloMao = checkBoxCuelloMao.Checked;
                camisas.Premium = radioButtonPremium.Checked;
                camisas.PrecioUnitario = precioUnitario;

                pantalones.chupin = checkBoxChupin.Checked;
                pantalones.Premium = radioButtonPremium.Checked;
                pantalones.PrecioUnitario = precioUnitario;

                Calcular.Cantidadunidadescotizadas = int.Parse(textBoxCantidad.Text);

                if (radioButtonCamisa.Checked == true)
                {
                    Calcular.CalcularPrecioCamisas(camisas.mangaCorta, camisas.cuelloMao, camisas.Premium, camisas.camisasMangaCortaMaoPremium, camisas.camisasMangaCortaMao, camisas.camisasMangaCortaPremium, camisas.camisasMangaCorta, camisas.camisasMangaLargaMaoPremium, camisas.camisasMangaLargaMao, camisas.camisasMangaLargaPremium, camisas.camisasMangaLarga, camisas.PrecioUnitario);
                    if (camisas.mangaCorta == true && camisas.cuelloMao == true && camisas.Premium == true)
                    {
                        camisas.camisasMangaCortaMaoPremium = camisas.camisasMangaCortaMaoPremium - Calcular.Cantidadunidadescotizadas;
                        labelStock.Text = camisas.camisasMangaCortaMaoPremium.ToString();
                    }
                    else
                    {
                        if (camisas.mangaCorta == true && camisas.cuelloMao == true)
                        {
                            camisas.camisasMangaCortaMao = camisas.camisasMangaCortaMao - Calcular.Cantidadunidadescotizadas;
                            labelStock.Text = camisas.camisasMangaCortaMao.ToString();
                        }
                        else
                        {
                            if (camisas.mangaCorta == true && camisas.Premium == true)
                            {
                                camisas.camisasMangaCortaPremium = camisas.camisasMangaCortaPremium - Calcular.Cantidadunidadescotizadas;
                                labelStock.Text = camisas.camisasMangaCortaPremium.ToString();
                            }
                            else
                            {
                                if (camisas.mangaCorta == true)
                                {
                                    camisas.camisasMangaCorta = camisas.camisasMangaCorta - Calcular.CantidadUnidades;
                                    labelStock.Text = camisas.camisasMangaCorta.ToString();
                                }
                            }
                        }
                    }
                    if (camisas.mangaCorta == false && camisas.cuelloMao == true && camisas.Premium == true)
                    {
                        camisas.camisasMangaLargaMaoPremium = camisas.camisasMangaLargaMaoPremium - Calcular.Cantidadunidadescotizadas;
                        labelStock.Text = camisas.camisasMangaLargaMaoPremium.ToString();
                    }
                    else
                    {
                        if (camisas.mangaCorta == false && camisas.cuelloMao == true)
                        {
                            camisas.camisasMangaLargaMao = camisas.camisasMangaLargaMao - Calcular.Cantidadunidadescotizadas;
                            labelStock.Text = camisas.camisasMangaLargaMao.ToString();
                        }
                        else
                        {
                            if (camisas.mangaCorta == false && camisas.Premium == true)
                            {
                                camisas.camisasMangaLargaPremium = camisas.camisasMangaLargaPremium - Calcular.Cantidadunidadescotizadas;
                                labelStock.Text = camisas.camisasMangaLargaPremium.ToString();
                            }
                            else
                            {
                                if (camisas.mangaCorta == false)
                                {
                                    camisas.camisasMangaLarga = camisas.camisasMangaLarga - Calcular.Cantidadunidadescotizadas;
                                    labelStock.Text = camisas.camisasMangaLarga.ToString();
                                }
                            }
                        }
                    }
                    camisas.camisasMangaCortaTotales = camisas.camisasMangaCorta + camisas.camisasMangaCortaMao + camisas.camisasMangaCortaMaoPremium + camisas.camisasMangaCortaPremium;
                    camisas.camisasMangaLargaTotales = camisas.camisasMangaLarga + camisas.camisasMangaLargaMao + camisas.camisasMangaLargaMaoPremium + camisas.camisasMangaLargaPremium;
                    camisas.StockTotal = camisas.camisasMangaCortaTotales + camisas.camisasMangaLargaTotales;

                }
                if (radioButtonCamisa.Checked == false)
                {
                    Calcular.calculandoPrecioPantalones(pantalones.chupin, pantalones.Premium, pantalones.pantalonesChupinesPremium, pantalones.pantalonesChupines, pantalones.pantalonesComunesPremium, pantalones.pantalonesComunes, pantalones.PrecioUnitario);
                    if (pantalones.chupin == true && pantalones.Premium == true)
                    {
                        pantalones.pantalonesChupinesPremium = pantalones.pantalonesChupinesPremium - Calcular.Cantidadunidadescotizadas;
                        labelStock.Text = pantalones.pantalonesChupinesPremium.ToString();
                    }
                    else
                    {
                        if (pantalones.chupin == true)
                        {
                            pantalones.pantalonesChupines = pantalones.pantalonesChupines - Calcular.Cantidadunidadescotizadas;
                            labelStock.Text = pantalones.pantalonesChupines.ToString();
                        }
                    }

                    if (pantalones.chupin == false && pantalones.Premium == true)
                    {
                        pantalones.pantalonesComunesPremium = pantalones.pantalonesComunesPremium - Calcular.Cantidadunidadescotizadas;
                    }
                    else
                    {
                        if (pantalones.chupin == false)
                        {
                            pantalones.pantalonesComunes = pantalones.pantalonesComunes - Calcular.Cantidadunidadescotizadas;
                        }
                    }
                    pantalones.pantalonesChupinesTotales = pantalones.pantalonesChupinesPremium + pantalones.pantalonesChupines;
                    pantalones.pantalonesComunesTotales = pantalones.pantalonesComunesPremium + pantalones.pantalonesComunes;
                    pantalones.StockTotal = pantalones.pantalonesChupinesTotales + pantalones.pantalonesComunesPremium;
                }

              
                float resultadoCotizacion = Calcular.ResultadoCotizacion * int.Parse(textBoxCantidad.Text);
                labelPrecioTotal.Text = resultadoCotizacion.ToString("0.0");
            } 
            catch(FormatException ex)
            {
                MessageBox.Show("Datos invalidos, por favor intentelo nuevamente");
            }
           
        }

        private void textBoxPrecioUnitario_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelPrecioTotal_Click(object sender, EventArgs e)
        {

        }

        
    }
}
