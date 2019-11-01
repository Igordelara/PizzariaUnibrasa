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
    public partial class Bebidas : Form
    {

        string[] codProd = new string[10];
        string[] nomeProd = new string[10];
        decimal[] valorProd = new decimal[10];
        decimal somaTotal;


        public Bebidas()
        {
            InitializeComponent();
        }

        private void Bebidas_Load(object sender, EventArgs e)
        {
            codProd[1] = "01";
            codProd[2] = "02";
            codProd[3] = "03";
            codProd[4] = "04";
            codProd[5] = "05";
            codProd[6] = "06";
            codProd[7] = "07";
            codProd[8] = "08";
            codProd[9] = "09";

            nomeProd[1] = "Refrigerante Fanta Laranja";
            nomeProd[2] = "Refrigerante Guarana kuat";
            nomeProd[3] = "Refrigerante COCA-COLA";
            nomeProd[4] = "Cerveja HEINEKEN";
            nomeProd[5] = "Cerveja Budweiser";
            nomeProd[6] = "Cerveja Original";
            nomeProd[7] = "Vinho Pérgola";
            nomeProd[8] = "Whisky Jack Daniel's Premium";
            nomeProd[9] = "Energético MONSTER";

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

        private void picProd_Click(object sender, EventArgs e)
        {

        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {
            if (txtCod.Text.Length == 2)
            {
                int ind = 0;

                for (int cp = 1; cp < 10; cp++)
                {
                    if (txtCod.Text == codProd[cp])
                    {
                        ind = cp;
                    }
                }

                if (ind > 0)
                {
                    listProdutos.Items.Add(String.Format("#{0} - {1} - {2:C}", codProd[ind], nomeProd[ind], valorProd[ind]));
                    picProd.ImageLocation = "C:/Users/IGOR DE LARA/Pictures/Imagens pizzaria/" + codProd[ind] + ".jpg";
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
