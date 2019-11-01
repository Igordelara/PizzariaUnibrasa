using PizzariaUnibrasa.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaUnibrasa
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inicio frl = new Inicio();
            frl.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {
            if ((TxtUsuario.Text == "igor") && (TxtSenha.Text == "123"))
            {
                Inicio frl = new Inicio();
                frl.Show();


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cadastro frl = new Cadastro();
            frl.Show();
        }
    }
}
