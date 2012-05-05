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

            
            /*string dia = DateTime.Now.Day.ToString();  //isso é só para aparecer a data na segunda tela
            string mes = DateTime.Now.Month.ToString();
            string ano = DateTime.Now.Year.ToString();
            lblTempo.Text = dia + "/" + mes + "/"+ ano;*/
        }
        public int B1 = 0; //aqui é para que depois possa compara se o jogador já clicou em algum botão
        public int B2 = 0;
        public int B3 = 0;
        public int B4 = 0;
        public int B5 = 0;
        public int B6 = 0;
        public int B7 = 0;
        public int B8 = 0;
        public int B9 = 0;
        

        int t = 0;
        public void Teste()  //fazendo o teste para saber se alguém ganhou
        {
            if (btnB1.Text == "X" && btnB2.Text == "X" && btnB3.Text == "X" || btnB4.Text == "X" && btnB5.Text == "X" && btnB6.Text == "X" || btnB7.Text == "X" && btnB8.Text == "X" && btnB9.Text == "X" ||/*DIAGONAL*/ btnB3.Text == "X" && btnB5.Text == "X" && btnB7.Text == "X" || btnB1.Text == "X" && btnB5.Text == "X" && btnB9.Text == "X" || /*Vertical*/ btnB1.Text == "X" && btnB4.Text == "X" && btnB7.Text == "X" || btnB2.Text == "X" && btnB5.Text == "X" && btnB8.Text == "X" || btnB3.Text == "X" && btnB6.Text == "X" && btnB9.Text == "X")
            { lblJogador.Text = " "; MessageBox.Show("Jogador 1 ganhou!", "Parabéns!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); t++; }
            if (btnB1.Text == "O" && btnB2.Text == "O" && btnB3.Text == "O" || btnB4.Text == "O" && btnB5.Text == "O" && btnB6.Text == "O" || btnB7.Text == "O" && btnB8.Text == "O" && btnB9.Text == "O" ||/*DIAGONAL*/ btnB3.Text == "O" && btnB5.Text == "O" && btnB7.Text == "O" || btnB1.Text == "O" && btnB5.Text == "O" && btnB9.Text == "O" || /*Vertical*/ btnB1.Text == "O" && btnB4.Text == "O" && btnB7.Text == "O" || btnB2.Text == "O" && btnB5.Text == "O" && btnB8.Text == "O" || btnB3.Text == "O" && btnB6.Text == "O" && btnB9.Text == "O")
            { lblJogador.Text = " "; MessageBox.Show("Jogador 2 ganhou!", "Parabéns!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1); t++; }
        }

        public void Cores() //se existir alguma "trinca" os três botões desta, ficarão coloridos
        {
            //Horizontal
            if (btnB1.Text == "X" && btnB2.Text == "X" && btnB3.Text == "X" || btnB1.Text == "O" && btnB2.Text == "O" && btnB3.Text == "O") { this.btnB1.BackColor = Color.Yellow; this.btnB2.BackColor = Color.Yellow; this.btnB3.BackColor = Color.Yellow; }
            if (btnB4.Text == "X" && btnB5.Text == "X" && btnB6.Text == "X" || btnB4.Text == "O" && btnB5.Text == "O" && btnB6.Text == "O") { this.btnB4.BackColor = Color.Yellow; this.btnB5.BackColor = Color.Yellow; this.btnB6.BackColor = Color.Yellow; }
            if (btnB7.Text == "X" && btnB8.Text == "X" && btnB9.Text == "X" || btnB7.Text == "O" && btnB8.Text == "O" && btnB9.Text == "O") { this.btnB7.BackColor = Color.Yellow; this.btnB8.BackColor = Color.Yellow; this.btnB9.BackColor = Color.Yellow; }
            
            //Vertical
            if (btnB1.Text == "X" && btnB4.Text == "X" && btnB7.Text == "X" || btnB1.Text == "O" && btnB4.Text == "O" && btnB7.Text == "O") { this.btnB1.BackColor = Color.Yellow; this.btnB4.BackColor = Color.Yellow; this.btnB7.BackColor = Color.Yellow; }
            if (btnB2.Text == "X" && btnB5.Text == "X" && btnB8.Text == "X" || btnB2.Text == "O" && btnB5.Text == "O" && btnB8.Text == "O") { this.btnB2.BackColor = Color.Yellow; this.btnB5.BackColor = Color.Yellow; this.btnB8.BackColor = Color.Yellow; }
            if (btnB3.Text == "X" && btnB6.Text == "X" && btnB9.Text == "X" || btnB3.Text == "O" && btnB6.Text == "O" && btnB9.Text == "O") { this.btnB3.BackColor = Color.Yellow; this.btnB6.BackColor = Color.Yellow; this.btnB9.BackColor = Color.Yellow; }
            
            //Diagonal
            if (btnB1.Text == "X" && btnB5.Text == "X" && btnB9.Text == "X" || btnB1.Text == "O" && btnB5.Text == "O" && btnB9.Text == "O") { this.btnB1.BackColor = Color.Yellow; this.btnB5.BackColor = Color.Yellow; this.btnB9.BackColor = Color.Yellow; }
            if (btnB3.Text == "X" && btnB5.Text == "X" && btnB7.Text == "X" || btnB3.Text == "O" && btnB5.Text == "O" && btnB7.Text == "O") { this.btnB3.BackColor = Color.Yellow; this.btnB5.BackColor = Color.Yellow; this.btnB7.BackColor = Color.Yellow; }
        }

        public int A=0, B=0, C=0, D=0, E=0, F=0, G=0, H=0, I=0;

        private int Randomico() //TUDO do aleatorio tem que ficar aqui dentro para executar um botão
        {
            Random er = new Random();
            int numero = int.Parse(er.Next(1, 10).ToString()); // sendo que o 10 não é sorteado (Lembrando que o 1 (ZERO) também é sorteado)
            if (numero == 1) { A = 1; btnB1.Text = "X"; }
            if (numero == 2) { B = 2; }
            if (numero == 3) { B = 3; }
            if (numero == 4) { B = 4; btnB4.Text = "X"; }
            if (numero == 5) { B = 5; }
            if (numero == 6) { B = 6; }
            if (numero == 7) { B = 7; btnB7.Text = "X"; }
            if (numero == 8) { B = 8; }
            if (numero == 9) { B = 9; }

            return numero;
        }

        public void btnB1_Click(object sender, EventArgs e) //BOTÃO 1
        {
            if (B1 == 0) //se for VERDAEIRO esse botão será marcado (isso é para saber se o jogador já tinha selecionado esse botão)
            {
                if (c.Jogador() % 2 == 0) //para marcar o botão e o label(indicando de quem é a vez para jogar)
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
                Teste();
            }
            B1++;  //esse B1 serve para garantir que se a pessoa clique novamente nesse botão, não mudará o que está escrito no botão
        }


        private void btnB2_Click(object sender, EventArgs e)
        {
            if (B2 == 0)
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
                Teste();
            }
            B2++;
        }

        private void btnB3_Click(object sender, EventArgs e)
        {
            if (B3 == 0)
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
                Teste();
            }
            B3++;
        }

        private void btnB4_Click(object sender, EventArgs e)
        {
            if (B4 == 0)
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
                Teste();
            }
            B4++;
        }

        private void btnB5_Click(object sender, EventArgs e)
        {
            if (B5 == 0)
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
                Teste();
            }
            B5++;
        }

        private void btnB6_Click(object sender, EventArgs e)
        {
            if (B6 == 0)
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
                Teste();
            }
            B6++;
        }

        private void btnB7_Click(object sender, EventArgs e)
        {
            if (B7 == 0)
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
                Teste();
            }
            B7++;
        }

        private void btnB8_Click(object sender, EventArgs e)
        {
            if (B8 == 0)
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
                Teste();
            }
            B8++;
        }

        private void btnB9_Click(object sender, EventArgs e)
        {
            if (B9 == 0)
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
                Teste();
            }
            B9++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}