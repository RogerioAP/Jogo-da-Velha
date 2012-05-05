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
    public partial class Form2 : Form
    {
        Condicoes c = new Condicoes();

        public Form2()
        {
            InitializeComponent();
            //timer1.Start();
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
            if (btnB1.Text == "X" && btnB2.Text == "X" && btnB3.Text == "X" || btnB4.Text == "X" && btnB5.Text == "X" && btnB6.Text == "X" || btnB7.Text == "X" && btnB8.Text == "X" && btnB9.Text == "X"
                ||/*DIAGONAL*/ btnB3.Text == "X" && btnB5.Text == "X" && btnB7.Text == "X" || btnB1.Text == "X" && btnB5.Text == "X" && btnB9.Text == "X"
                || /*Vertical*/ btnB1.Text == "X" && btnB4.Text == "X" && btnB7.Text == "X" || btnB2.Text == "X" && btnB5.Text == "X" && btnB8.Text == "X" || btnB3.Text == "X" && btnB6.Text == "X" && btnB9.Text == "X")
            {
                lblJogador.Text = " "; MessageBox.Show("Você ganhou!", "Parabéns!", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk); t++;
            }

            if (btnB1.Text == "O" && btnB2.Text == "O" && btnB3.Text == "O" || btnB4.Text == "O" && btnB5.Text == "O" && btnB6.Text == "O" || btnB7.Text == "O" && btnB8.Text == "O" && btnB9.Text == "O"
                ||/*DIAGONAL*/ btnB3.Text == "O" && btnB5.Text == "O" && btnB7.Text == "O" || btnB1.Text == "O" && btnB5.Text == "O" && btnB9.Text == "O"
                || /*Vertical*/ btnB1.Text == "O" && btnB4.Text == "O" && btnB7.Text == "O" || btnB2.Text == "O" && btnB5.Text == "O" && btnB8.Text == "O" || btnB3.Text == "O" && btnB6.Text == "O" && btnB9.Text == "O")
            {
                lblJogador.Text = " "; MessageBox.Show("O PC ganhou hehehe!", "Inteligência Artificial", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1); t++;
            }
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

        public void Sequencia()
        {
            if (btnB1.Text == "O" && btnB2.Text == "O") { }
        }

        public int A = 0, B = 0, C = 0, D = 0, E = 0, F = 0, G = 0, H = 0, I = 0;
        public bool teste = false;
        private int Randomico() //TUDO do aleatorio tem que ficar aqui dentro para executar um botão
        {
            int numero = 0;
            for (int q = 0; teste == false; q++)
            {
                Random er = new Random();
                numero = int.Parse(er.Next(1, 10).ToString()); // sendo que o 10 não é sorteado (Lembrando que o 1 também é sorteado)
                if (numero == 1) { A++; if (A == 1) { teste = true; break; } }
                if (numero == 2) { B++; if (B == 1) { teste = true; break; } }
                if (numero == 3) { C++; if (C == 1) { teste = true; break; } }
                if (numero == 4) { D++; if (D == 1) { teste = true; break; } }
                if (numero == 5) { E++; if (E == 1) { teste = true; break; } }
                if (numero == 6) { F++; if (F == 1) { teste = true; break; } }
                if (numero == 7) { G++; if (G == 1) { teste = true; break; } }
                if (numero == 8) { H++; if (H == 1) { teste = true; break; } }
                if (numero == 9) { I++; if (I == 1) { teste = true; break; } }
                q++;
            }

            return numero;
        }

        public int rf = 0;

        public int Verificador()
        {
            rf++;
            return rf;
            //números ÍMPARES é 
            //números PARES é 
        }

        public void Testa()
        {
            int rand = Randomico();
            if (rand == 1 && B1 == 0) { Botao1(); B1++; }
            if (rand == 2 && B2 == 0) { Botao2(); }
            if (rand == 3 && B3 == 0) { Botao3(); }
            if (rand == 4 && B4 == 0) { Botao4(); }
            if (rand == 5 && B5 == 0) { Botao5(); }
            if (rand == 6 && B6 == 0) { Botao6(); }
            if (rand == 7 && B7 == 0) { Botao7(); }
            if (rand == 8 && B8 == 0) { Botao8(); }
            if (rand == 9 && B9 == 0) { Botao9(); }
        }

        public int a = 1;
        public string jog;

        public int Jogador() //esse Jogador() serve para ficar alternando o label lá emcima, para definir se é jogador 1 ou 2 
        {
            a++;
            return a;
            //números ÍMPARES é do jogador 1
            //números PARES é do jogador 2
        }

        public void Botao1()
        {
            if (B1 == 0) //se for VERDAEIRO esse botão será marcado (isso é para saber se o jogador já tinha selecionado esse botão)
            {
                if (c.Jogador() % 2 == 0) //para marcar o botão e o label(indicando de quem é a vez para jogar)
                {
                    btnB1.Text = "X";
                    lblJogador.Text = "do PC";
                }
                else
                {
                    btnB1.Text = "O";
                    lblJogador.Text = "de você";
                }
                Cores();
                Teste();
            }
        }

        public void Botao2()
        {
            if (B2 == 0)
            {
                if (c.Jogador() % 2 == 0)
                {
                    btnB2.Text = "X";
                    lblJogador.Text = "do PC";
                }
                else
                {
                    btnB2.Text = "O";
                    lblJogador.Text = "de você";
                }
                Cores();
                Teste();
            }
            B2++;
        }

        private void Botao3()
        {
            if (B3 == 0)
            {
                if (c.Jogador() % 2 == 0)
                {
                    btnB3.Text = "X";
                    lblJogador.Text = "do PC";
                }
                else
                {
                    btnB3.Text = "O";
                    lblJogador.Text = "de você";
                }
                Cores();
                Teste();
            }
            B3++;
        }

        private void Botao4()
        {
            if (B4 == 0)
            {
                if (c.Jogador() % 2 == 0)
                {
                    btnB4.Text = "X";
                    lblJogador.Text = "do PC";
                }
                else
                {
                    btnB4.Text = "O";
                    lblJogador.Text = "de você";
                }
                Cores();
                Teste();
            }
            B4++;
        }

        private void Botao5()
        {
            if (B5 == 0)
            {
                if (c.Jogador() % 2 == 0)
                {
                    btnB5.Text = "X";
                    lblJogador.Text = "do PC";
                }
                else
                {
                    btnB5.Text = "O";
                    lblJogador.Text = "de você";
                }
                Cores();
                Teste();
            }
            B5++;
        }

        private void Botao6()
        {
            if (B6 == 0)
            {
                if (c.Jogador() % 2 == 0)
                {
                    btnB6.Text = "X";
                    lblJogador.Text = "do PC";
                }
                else
                {
                    btnB6.Text = "O";
                    lblJogador.Text = "de você";
                }
                Cores();
                Teste();
            }
            B6++;
        }

        private void Botao7()
        {
            if (B7 == 0)
            {
                if (c.Jogador() % 2 == 0)
                {
                    btnB7.Text = "X";
                    lblJogador.Text = "do PC";
                }
                else
                {
                    btnB7.Text = "O";
                    lblJogador.Text = "de você";
                }
                Cores();
                Teste();
            }
            B7++;
        }

        private void Botao8()
        {
            if (B8 == 0)
            {
                if (c.Jogador() % 2 == 0)
                {
                    btnB8.Text = "X";
                    lblJogador.Text = "do PC";
                }
                else
                {
                    btnB8.Text = "O";
                    lblJogador.Text = "de você";
                }
                Cores();
                Teste();
            }
            B8++;
        }

        private void Botao9()
        {
            if (B9 == 0)
            {
                if (c.Jogador() % 2 == 0)
                {
                    btnB9.Text = "X";
                    lblJogador.Text = "do PC";
                }
                else
                {
                    btnB9.Text = "O";
                    lblJogador.Text = "de você";
                }
                Cores();
                Teste();
            }
            B9++;
        }

        private void btnB1_Click(object sender, EventArgs e)
        {
            Botao1();
            B1++;
        }

        private void btnB2_Click(object sender, EventArgs e)
        {
            Botao2();
        }

        private void btnB3_Click(object sender, EventArgs e)
        {
            Botao3();
        }

        private void btnB4_Click(object sender, EventArgs e)
        {
            Botao4();
        }

        private void btnB5_Click(object sender, EventArgs e)
        {
            Botao5();
        }

        private void btnB6_Click(object sender, EventArgs e)
        {
            Botao6();
        }

        private void btnB7_Click(object sender, EventArgs e)
        {
            Botao7();
        }

        private void btnB8_Click(object sender, EventArgs e)
        {
            Botao8();
        }

        private void btnB9_Click(object sender, EventArgs e)
        {
            Botao9();
        }

        public void VerificarBotoes()
        {
            //caso o segundo for == 58 || 59 || 60 fica igual a 0
            int segundo = int.Parse(DateTime.Now.Second.ToString());
            int novo = 0;
            if (segundo == 58 || segundo == 59 || segundo == 60)
            {
                segundo = 0;
            }
            //MessageBox.Show(novo.ToString() + " e " + segundo.ToString());
            for (int i = 0; i == 0; novo = int.Parse(DateTime.Now.Second.ToString()))
            {
                if (novo >= segundo + 3) //após três segundos a tela é fechada
                {
                    i++;
                    Testa();
                    break;
                }
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (B1 > 0) { VerificarBotoes(); B1 = 0; }
            if (B2 > 0) { VerificarBotoes(); B2 = 0; }
            if (B3 > 0) { VerificarBotoes(); B3 = 0; }
            if (B4 > 0) { VerificarBotoes(); B4 = 0; }
            if (B5 > 0) { VerificarBotoes(); B5 = 0; }
            if (B6 > 0) { VerificarBotoes(); B6 = 0; }
            if (B7 > 0) { VerificarBotoes(); B7 = 0; }
            if (B8 > 0) { VerificarBotoes(); B8 = 0; }
            if (B9 > 0) { VerificarBotoes(); B9 = 0; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}