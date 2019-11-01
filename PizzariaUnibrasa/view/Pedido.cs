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
    public partial class Pedido : Form
    {
        public Pedido()
        {
            InitializeComponent();
        }

        private void btnFinalizarPedido_Click(object sender, EventArgs e)
        {
            F_Pagamento Forma_Pagamento = new F_Pagamento();
            Forma_Pagamento.ShowDialog();
        }
    }
}
