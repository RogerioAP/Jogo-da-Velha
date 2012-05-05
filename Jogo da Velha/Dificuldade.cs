using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JogodaVelha
{
    public partial class frmDificuldade : Form
    {
        Form1 f = new Form1();
        Condicoes g = new Condicoes();
        public frmDificuldade()
        {
            InitializeComponent();
        }

        public void Fechar()
        {
            this.Close();
        }

        private void btnMoleza_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSeraquevoceganha_Click(object sender, EventArgs e)
        {

        }

    }
}
