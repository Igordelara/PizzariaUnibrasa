using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaUnibrasa.view
{
    public partial class Caixa : Form

        {
        String[] codprod = new string[10];
        String[] nomeprod = new string[10];
        decimal[] valorProd = new decimal[10];
        decimal somaTotal;

        public Caixa()
        {
            InitializeComponent();
        }

        private void Caixa_Load(object sender, EventArgs e)
        {
            loadProdutos();
            somaTotal = 0;
        }
        private void loadProdutos()
        {
           codprod[1] = "01";
            codprod[2] = "02";
            codprod[3] = "03";
            codprod[4] = "04";
            codprod[5] = "05";
            codprod[6] = "06";
            codprod[7] = "07";
            codprod[8] = "08";
            codprod[9] = "09";

            nomeprod[1] = "Refrigerante Fanta Laranja";
            nomeprod[2] = "Refrigerante Guarana kuat";
            nomeprod[3] = "Refrigerante COCA-COLA";
            nomeprod[4] = "Cerveja HEINEKEN";
            nomeprod[5] = "Cerveja Budweiser";
            nomeprod[6] = "Cerveja Original";
            nomeprod[7] = "Vinho Pérgola";
            nomeprod[8] = "Whisky Jack Daniel's Premium";
            nomeprod[9] = "Energético MONSTER";

            valorProd[1] = 5.50M;
            valorProd[2] = 5.50M;
            valorProd[3] = 6.50M;
            valorProd[4] = 4.50M;
            valorProd[5] = 4.50M;
            valorProd[6] = 8.00M;
            valorProd[7] = 109.00M;
            valorProd[8] = 119.00M;
            valorProd[9] = 8.50M;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtCod.Text.Length == 2)
            {
                int ind = 0;

                for (int cp = 1; cp < 10; cp++)
                {
                    if (txtCod.Text == codprod[cp])
                    {
                        ind = cp;
                    }
                }

                if (ind > 0)
                {
                    listProd.Items.Add(String.Format("#{0} - {1} - {2:C}", codprod[ind], nomeprod[ind], valorProd[ind]));
                    picprod.ImageLocation = "C:/Users/IGOR DE LARA/Pictures/Imagens pizzaria/" + codprod[ind] + ".jpg";
                    somaTotal += valorProd[ind];
                    txtTotal.Text = Convert.ToString("R$" + somaTotal);

                    txtCod.Text = "";
                    txtCod.Focus();


                }
                else
                {
                    MessageBox.Show("Produto não encontrado");
                }
            }
        }
    }
    }

    

