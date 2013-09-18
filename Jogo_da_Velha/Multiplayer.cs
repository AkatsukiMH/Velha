using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Jogo_da_Velha
{
    public partial class Multiplayer : Form
    {  // cont --> verificará a vez de cada jogador; Velha e H --> servirão de contadores para identificar se houve Velha
        public int cont = 0, Velha = 0, H = 0;
        public string BT1, BT2, BT3, BT4, BT5, BT6, BT7, BT8, BT9; // variaveis que pegarão o text dos botoes
        public int VJ1 = 0, VJ2 = 0, Empatou = 0; // Verifica vitorias e empates 
        public int npartidas = 0; // contador para mostrar o numero de partidas realizadas

        public Multiplayer()
        {
            InitializeComponent();
        }

        Nickname jogadores; // variavel do tipo Nickname

        public Multiplayer(Nickname player) // Metodo Construtor
        {
            InitializeComponent();
            jogadores = player;
        }

        

        public void partidas(int npartidas) // Metodo para saber o numero de partidas
        {
            label9.Text = npartidas.ToString();
        }

        public void n_empate(int empatou)
        {
            label7.Text = Empatou.ToString();
        }


        public void Winner(string BT1, string BT2, string BT3, string BT4, string BT5, string BT6, string BT7, string BT8, string BT9) // Método que verifica o vencedor
        {
            Nickname radio = new Nickname();

            // Verifica todas as Colunas 
                if ((BT1 == "X" && BT2 == "X" && BT3 == "X") ||
                    (BT4 == "X" && BT5 == "X" && BT6 == "X") ||
                    (BT7 == "X" && BT8 == "X" && BT9 == "X"))
                {
                    MessageBox.Show("X Venceu!!!");
                    Desabilita_Botao();
                    H += 1;


                    // Analisa quem venceu de acordo com o radio.button escolhido
                    if (jogadores.ESCOLHA == 1)
                    {
                        VJ1 += 1;
                        label4.Text = VJ1.ToString();
                    }
                       
                    if (jogadores.ESCOLHA == 2)
                        {
                            VJ2 += 1;
                            label5.Text = VJ2.ToString();
                        }
                
                }
                else
                    if ((BT1 == "O" && BT2 == "O" && BT3 == "O") ||
                        (BT4 == "O" && BT5 == "O" && BT6 == "O") ||
                        (BT7 == "O" && BT8 == "O" && BT9 == "O"))
                    {
                        MessageBox.Show("O Venceu!!!");
                        Desabilita_Botao();
                        H += 1;


                        // Analisa quem venceu de acordo com o radio.button escolhido
                        if (jogadores.ESCOLHA == 1)
                        {
                            VJ2 += 1;
                            label5.Text = VJ2.ToString();
                        }
                                                 
                        
                        if (jogadores.ESCOLHA == 2)
                            {                               
                                VJ1 += 1;
                                label4.Text = VJ1.ToString();
                            }
                    
                    }


                // Verifica todas as Linhas 
                if ((BT1 == "X" && BT4 == "X" && BT7 == "X") ||
                    (BT2 == "X" && BT5 == "X" && BT8 == "X") ||
                    (BT3 == "X" && BT6 == "X" && BT9 == "X"))
                {
                    MessageBox.Show("X Venceu!!!");
                    Desabilita_Botao();
                    H += 1;
                    
                    
                    // Analisa quem venceu de acordo com o radio.button escolhido
                    if (jogadores.ESCOLHA == 1)
                    {
                        VJ1 += 1;
                        label4.Text = VJ1.ToString();
                    }


                    if (jogadores.ESCOLHA == 2)
                    {
                        VJ2 += 1;
                        label5.Text = VJ2.ToString();
                    }
                
                
                }
                else
                    if ((BT1 == "O" && BT4 == "O" && BT7 == "O") ||
                        (BT2 == "O" && BT5 == "O" && BT8 == "O") ||
                        (BT3 == "O" && BT6 == "O" && BT9 == "O"))
                    {
                        MessageBox.Show("O Venceu!!!");
                        Desabilita_Botao();
                        H += 1;
                        
                        
                        // Analisa quem venceu de acordo com o radio.button escolhido
                        if (jogadores.ESCOLHA == 1)
                        {
                            VJ2 += 1;
                            label5.Text = VJ2.ToString();
                        }
                        
              
                        if (jogadores.ESCOLHA == 2)
                            {
                                VJ1 += 1;
                                label4.Text = VJ1.ToString();
                            }
                    
                    }


                // Verifica todas as diagonais
                if ((BT1 == "X" && BT5 == "X" && BT9 == "X") ||
                    (BT3 == "X" && BT5 == "X" && BT7 == "X"))
                {
                    MessageBox.Show("X Venceu!!!");
                    Desabilita_Botao();
                    H += 1;

                    if (jogadores.ESCOLHA == 1)
                    {
                        VJ1 += 1;
                        label4.Text = VJ1.ToString();
                    }
                    else
                        if (jogadores.ESCOLHA == 2)
                        {
                            VJ2 += 1;
                            label5.Text = VJ2.ToString();
                        }
                }
                else
                    if ((BT1 == "O" && BT5 == "O" && BT9 == "O") ||
                            (BT3 == "O" && BT5 == "O" && BT7 == "O"))
                    {
                        MessageBox.Show("O Venceu!!!");
                        Desabilita_Botao();
                        H += 1;

                      
                        // Analisa quem venceu de acordo com o radio.button escolhido
                        if (jogadores.ESCOLHA == 1)
                        {
                            VJ2 += 1;
                            label5.Text = VJ2.ToString();
                        }
 
 
                        if (jogadores.ESCOLHA == 2)
                            {
                                VJ1 += 1;
                                label4.Text = VJ1.ToString();
                            }
                    
                    
                    }
           
        }
   
        
        
        
        public void Empate(int Velha) // Metodo que verifica se deu Empate
        {
            if (Velha >=9 && H < 1)
            {
                MessageBox.Show("O jogo deu Velha!!!");
                Desabilita_Botao();

                Empatou += 1;
                n_empate(Empatou);
            }
        }

        
        
        public void Desabilita_Botao()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        public void Habilita_Botao()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }
        
        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Multiplayer_Load(object sender, EventArgs e)
        {
            Habilita_Botao();

            if (jogadores.J1 != "" || jogadores.J2 != "")
            {
                label2.Text = jogadores.J1;
                label3.Text = jogadores.J2;
                label10.Text = "-->  " + jogadores.E1;
                label11.Text = "-->  " + jogadores.E2;
            }
            else
            {
                label2.Text = "Jogador1";
                label3.Text = "Jogador2";
                label10.Text = "--->  " + jogadores.E1;
                label11.Text = "--->  " + jogadores.E2;

            }
            
            
            /* SoundPlayer Mozart = new SoundPlayer(@"C:\Users\mathou\Videos\Akatsuki Theme 2 (with choir) BETTER.wav");
            Mozart.Play(); */

            

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cont ++;
            Velha = Velha + 1;
            
            if (cont % 2 == 0) // Contador para verificar a Vez
            {
                button1.Text = "X";
            }
            else
            {
                button1.Text = "O";
            }

            button1.Enabled = false;
            BT1 = button1.Text;
            Winner(BT1, BT2, BT3, BT4, BT5, BT6, BT7, BT8, BT9);

            Empate(Velha);
        }


        private void button11_Click(object sender, EventArgs e)
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

            BT1 = "";
            BT2 = "";
            BT3 = "";
            BT4 = "";
            BT5 = "";
            BT6 = "";
            BT7 = "";
            BT8 = "";
            BT9 = "";

            Velha = 0;
            H = 0;
            npartidas += 1;
           
            partidas(npartidas);

            Habilita_Botao();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 main = new Form1();
            main.ShowDialog();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Velha = Velha + 1;
            cont++;

            if (cont % 2 == 0)
            {
                button2.Text = "X";
            }
            else
            {
                button2.Text = "O";
            }

            button2.Enabled = false;
            BT2 = button2.Text;
            Winner(BT1, BT2, BT3, BT4, BT5, BT6, BT7, BT8, BT9);

            Empate(Velha); 
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Velha = Velha + 1;
            cont++;

            if (cont % 2 == 0)
            {
                button3.Text = "X";
            }
            else
            {
                button3.Text = "O";
            }

            button3.Enabled = false;
            BT3 = button3.Text;
            Winner(BT1, BT2, BT3, BT4, BT5, BT6, BT7, BT8, BT9);

            Empate(Velha); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Velha = Velha + 1;
            cont++;

            if (cont % 2 == 0)
            {
                button4.Text = "X";
            }
            else
            {
                button4.Text = "O";
            }

            button4.Enabled = false;
            BT4 = button4.Text;
            Winner(BT1, BT2, BT3, BT4, BT5, BT6, BT7, BT8, BT9);

            Empate(Velha);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Velha = Velha + 1;
            cont++;

            if (cont % 2 == 0)
            {
                button5.Text = "X";
            }
            else
            {
                button5.Text = "O";
            }

            button5.Enabled = false;
            BT5 = button5.Text;
            Winner(BT1, BT2, BT3, BT4, BT5, BT6, BT7, BT8, BT9);

            Empate(Velha); 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Velha = Velha + 1;
            cont++;

            if (cont % 2 == 0)
            {
                button6.Text = "X";
            }
            else
            {
                button6.Text = "O";
            }

            button6.Enabled = false;
            BT6 = button6.Text;
            Winner(BT1, BT2, BT3, BT4, BT5, BT6, BT7, BT8, BT9);

            Empate(Velha); 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Velha = Velha + 1;
            cont++;

            if (cont % 2 == 0)
            {
                button7.Text = "X";
            }
            else
            {
                button7.Text = "O";
            }

            button7.Enabled = false;
            BT7 = button7.Text;
            Winner(BT1, BT2, BT3, BT4, BT5, BT6, BT7, BT8, BT9);

            Empate(Velha); 
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Velha = Velha + 1;
            cont++;

            if (cont % 2 == 0)
            {
                button8.Text = "X";
            }
            else
            {
                button8.Text = "O";
            }

            button8.Enabled = false;
            BT8 = button8.Text;
            Winner(BT1, BT2, BT3, BT4, BT5, BT6, BT7, BT8, BT9);

            Empate(Velha); 
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Velha = Velha + 1;
            cont++;

            if (cont % 2 == 0)
            {
                button9.Text = "X";
            }
            else
            {
                button9.Text = "O";
            }
            
            
            BT9 = button9.Text;
            Winner(BT1, BT2, BT3, BT4, BT5, BT6, BT7, BT8, BT9);
            button9.Enabled = false;
            Empate(Velha);

        }


    }
}
