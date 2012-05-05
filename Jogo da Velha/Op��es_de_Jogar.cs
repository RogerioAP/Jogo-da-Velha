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
    public partial class frmOpcoesdejogar : Form
    {
        Form1 sd = new Form1();
        Condicoes c = new Condicoes();
        public frmOpcoesdejogar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form1().ShowDialog();
        }



        public void Computador()
        {
            Random B1 = new Random();
            Random B2 = new Random();
            Random B3 = new Random();
            Random B4 = new Random();
            Random B5 = new Random();
            Random B6 = new Random();
            Random B7 = new Random();
            Random B8 = new Random();
            Random B9 = new Random();


        }

        public void button1_Click(object sender, EventArgs e)
        {
            new frmDificuldade().ShowDialog();
            //MessageBox.Show("MessageBox customizado!", "Atenção!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
        }
        int g = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //string segundo = DateTime.Now.Second.ToString();
            //int r = int.Parse(segundo);
            //string R = r.ToString();
            //if (g > 0)
            //{
            //    this.Opacity = Opacity - 0.1;
            //}

            /*for (int y = 0; y <= 1000000; y++ )
            {
                Opacity += -0.00001;
            }*/
        }

        private void frmOpcoesdejogar_MouseEnter(object sender, EventArgs e)
        {
            /*timer1.Start();
            g++;
            Refresh();*/
        }

        private void frmOpcoesdejogar_Load(object sender, EventArgs e)
        {

        }
    }
}
