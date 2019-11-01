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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente frl = new Cliente();
            frl.Show();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Pedido frl = new Pedido();
            frl.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Funcionario frl = new Funcionario();
            frl.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bebidas frl = new Bebidas();
            frl.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Fornecedor frl = new Fornecedor();
            frl.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Caixa frl = new Caixa();
            frl.Show();
        }
    }
}
