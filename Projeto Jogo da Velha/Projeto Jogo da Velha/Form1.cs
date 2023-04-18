using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Jogo_da_Velha
{
    public partial class Form1 : Form
    {


        int Xplayer = 0, Oplayer = 0, empatesPontos = 0, rodadas = 0;
        bool turno = true;
        bool jogo_final;
        string[] texto = new string[9];

        public Form1()
        {
            InitializeComponent();
        }

        private void btnResetar_Click(object sender, EventArgs e)
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            rodadas = 0;
            jogo_final = false;
            for (int i = 0; i < 9; i++)
            {
                texto[i] = "";
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int buttonIndex = button.TabIndex;

            if (button.Text == "")
            {
                if (turno)
                {
                    button.Text = "X";
                    texto[buttonIndex] = button.Text; 
                    rodadas++;
                    turno = !turno;
                    Checagem(1);
                }
                else
                {
                    button.Text = "O";
                    texto[buttonIndex] = button.Text;
                    rodadas++;
                    turno = !turno;
                    Checagem(2);
                }
            }

        }

        void Vencedor(int PlayerQueGanhou)
        {
            jogo_final = true;

            if(PlayerQueGanhou == 1)
            {
                Xplayer ++;
                Xpontos.Text = Convert.ToString(Xplayer);
                MessageBox.Show("Jogador X ganhou!");
                turno = true;
            }
            else
            {
                Oplayer++;
                Opontos.Text = Convert.ToString(Oplayer);
                MessageBox.Show("Jogador O ganhou!");
                turno= false;
            }
        }

        void Checagem(int ChecagemPlayer)
        {
            string suporte = "";

            if(ChecagemPlayer == 1)
            {
                suporte = "X";
            }
            else
            {
                suporte = "O";
            }

            for (int horizontal = 0; horizontal < 8; horizontal += 3)
            {
                if(suporte == texto[horizontal])
                {
                    if(texto[horizontal] == texto[horizontal + 1] && texto[horizontal] == texto[horizontal + 2])
                    {
                        Vencedor(ChecagemPlayer);
                        return;
                    }
                }
            }

            for (int vertical = 0; vertical < 3; vertical ++)
            {
                if (suporte == texto[vertical])
                {
                    if (texto[vertical] == texto[vertical + 3] && texto[vertical] == texto[vertical + 6])
                    {
                        Vencedor(ChecagemPlayer);
                        return;
                    }
                }
            }

            if (texto[0] == suporte)
            {
                if (texto[0] == texto[4] && texto[0] == texto[8])
                {
                    Vencedor(ChecagemPlayer);
                    return;
                }
            }

            if (texto[2] == suporte)
            {
                if (texto[2] == texto[4] && texto[2] == texto[6])
                {
                    Vencedor(ChecagemPlayer);
                    return;
                }
            }

            if (rodadas == 9 && jogo_final == false)
            {
                MessageBox.Show("Empate!");
                jogo_final = true;
                return;
            }



        }
    }
}
