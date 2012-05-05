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
    public partial class Form1 : Form
    {
        Condicoes c = new Condicoes();

        public Form1()
        {
            InitializeComponent();
        }

        public void Principal() //testes para verificar se alguém ganhou
        {
            if (btnB1.Text == "X" && btnB2.Text == "X" && btnB3.Text == "X" || btnB4.Text == "X" && btnB5.Text == "X" && btnB6.Text == "X" || btnB7.Text == "X" && btnB8.Text == "X" && btnB9.Text == "X" ||/*DIAGONAL*/ btnB3.Text == "X" && btnB5.Text == "X" && btnB7.Text == "X" || btnB1.Text == "X" && btnB5.Text == "X" && btnB9.Text == "X" || /*Vertical*/ btnB1.Text == "X" && btnB4.Text == "X" && btnB7.Text == "X" || btnB2.Text == "X" && btnB5.Text == "X" && btnB8.Text == "X" || btnB3.Text == "X" && btnB6.Text == "X" && btnB9.Text == "X")
            { MessageBox.Show("Jogador 1 ganhou!", "Parabéns!"); }
            if (btnB1.Text == "O" && btnB2.Text == "O" && btnB3.Text == "O" || btnB4.Text == "O" && btnB5.Text == "O" && btnB6.Text == "O" || btnB7.Text == "O" && btnB8.Text == "O" && btnB9.Text == "O" ||/*DIAGONAL*/ btnB3.Text == "O" && btnB5.Text == "O" && btnB7.Text == "O" || btnB1.Text == "O" && btnB5.Text == "O" && btnB9.Text == "O" || /*Vertical*/ btnB1.Text == "O" && btnB4.Text == "O" && btnB7.Text == "O" || btnB2.Text == "O" && btnB5.Text == "O" && btnB8.Text == "O" || btnB3.Text == "O" && btnB6.Text == "O" && btnB9.Text == "O")
            { MessageBox.Show("Jogador 2 ganhou!", "Parabéns!"); }
        }

        public void Cores() //se tais botões formarem uma trinca, ficam COLORIDOS
        {
            //Horizontal
            if (btnB1.Text == "X" && btnB2.Text == "X" && btnB3.Text == "X" || btnB1.Text == "O" && btnB2.Text == "O" && btnB3.Text == "O") { this.btnB1.BackColor = Color.Yellow; this.btnB2.BackColor = Color.Yellow; this.btnB3.BackColor = Color.Yellow; }
            if (btnB4.Text == "X" && btnB5.Text == "X" && btnB6.Text == "X" || btnB4.Text == "O" && btnB5.Text == "O" && btnB6.Text == "O") { this.btnB4.BackColor = Color.Yellow; this.btnB5.BackColor = Color.Yellow; this.btnB6.BackColor = Color.Yellow; }
            if (btnB7.Text == "X" && btnB8.Text == "X" && btnB9.Text == "X" || btnB7.Text == "O" && btnB8.Text == "O" && btnB9.Text == "O") { this.btnB7.BackColor = Color.Yellow; this.btnB8.BackColor = Color.Yellow; this.btnB9.BackColor = Color.Yellow; }
            //DIAGONAL
            if (btnB3.Text == "X" && btnB5.Text == "X" && btnB7.Text == "X" || btnB3.Text == "O" && btnB5.Text == "O" && btnB7.Text == "O") { this.btnB3.BackColor = Color.Yellow; this.btnB5.BackColor = Color.Yellow; this.btnB7.BackColor = Color.Yellow; }
            if (btnB1.Text == "X" && btnB5.Text == "X" && btnB9.Text == "X" || btnB1.Text == "O" && btnB5.Text == "O" && btnB9.Text == "O") { this.btnB1.BackColor = Color.Yellow; this.btnB5.BackColor = Color.Yellow; this.btnB9.BackColor = Color.Yellow; }
            //Vertical
            if (btnB1.Text == "X" && btnB4.Text == "X" && btnB7.Text == "X" || btnB1.Text == "O" && btnB4.Text == "O" && btnB7.Text == "O") { this.btnB1.BackColor = Color.Yellow; this.btnB4.BackColor = Color.Yellow; this.btnB7.BackColor = Color.Yellow; }
            if (btnB2.Text == "X" && btnB5.Text == "X" && btnB8.Text == "X" || btnB2.Text == "O" && btnB5.Text == "O" && btnB8.Text == "O") { this.btnB2.BackColor = Color.Yellow; this.btnB5.BackColor = Color.Yellow; this.btnB8.BackColor = Color.Yellow; }
            if (btnB3.Text == "X" && btnB6.Text == "X" && btnB9.Text == "X" || btnB3.Text == "O" && btnB6.Text == "O" && btnB9.Text == "O") { this.btnB3.BackColor = Color.Yellow; this.btnB6.BackColor = Color.Yellow; this.btnB9.BackColor = Color.Yellow; }
        }


        private void btnB1_Click(object sender, EventArgs e)
        {
            if (c.Jogador() % 2 == 0)
            {
                btnB1.Text = "X";
                lblJogador.Text = "2";
            }
            else
            {
                btnB1.Text = "O";
                lblJogador.Text = "1";
            }
            Cores();
            Principal();
        }

        private void btnB2_Click(object sender, EventArgs e)
        {
            if (c.Jogador() % 2 == 0)
            {
                btnB2.Text = "X";
                lblJogador.Text = "2";
            }
            else
            {
                btnB2.Text = "O";
                lblJogador.Text = "1";
            }
            Cores();
            Principal();
        }

        private void btnB3_Click(object sender, EventArgs e)
        {
            if (c.Jogador() % 2 == 0)
            {
                btnB3.Text = "X";
                lblJogador.Text = "2";
            }
            else
            {
                btnB3.Text = "O";
                lblJogador.Text = "1";
            }
            Cores();
            Principal();
        }

        private void btnB4_Click(object sender, EventArgs e)
        {
            if (c.Jogador() % 2 == 0)
            {
                btnB4.Text = "X";
                lblJogador.Text = "2";
            }
            else
            {
                btnB4.Text = "O";
                lblJogador.Text = "1";
            }
            Cores();
            Principal();
        }

        private void btnB5_Click(object sender, EventArgs e)
        {
            if (c.Jogador() % 2 == 0)
            {
                btnB5.Text = "X";
                lblJogador.Text = "2";
            }
            else
            {
                btnB5.Text = "O";
                lblJogador.Text = "1";
            }
            Cores();
            Principal();
        }

        private void btnB6_Click(object sender, EventArgs e)
        {
            if (c.Jogador() % 2 == 0)
            {
                btnB6.Text = "X";
                lblJogador.Text = "2";
            }
            else
            {
                btnB6.Text = "O";
                lblJogador.Text = "1";
            }
            Cores();
            Principal();
        }

        private void btnB7_Click(object sender, EventArgs e)
        {
            if (c.Jogador() % 2 == 0)
            {
                btnB7.Text = "X";
                lblJogador.Text = "2";
            }
            else
            {
                btnB7.Text = "O";
                lblJogador.Text = "1";
            }
            Cores();
            Principal();
        }

        private void btnB8_Click(object sender, EventArgs e)
        {
            if (c.Jogador() % 2 == 0)
            {
                btnB8.Text = "X";
                lblJogador.Text = "2";
            }
            else
            {
                btnB8.Text = "O";
                lblJogador.Text = "1";
            }
            Cores();
            Principal();
        }

        private void btnB9_Click(object sender, EventArgs e)
        {
            if (c.Jogador() % 2 == 0)
            {
                btnB9.Text = "X";
                lblJogador.Text = "2";
            }
            else
            {
                btnB9.Text = "O";
                lblJogador.Text = "1";
            }
            Cores();
            Principal();
        }

        private void btnNovoJogo_Click(object sender, EventArgs e)
        {
            new Form1().ShowDialog();
            Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void lblJogador_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}