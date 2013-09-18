using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jogo_da_Velha
{
    public partial class Nickname : Form
    {
       public string J1, J2;

       public int ESCOLHA = 0;

        public Nickname()
        {
            InitializeComponent();
        }

        public string E1, E2;

        public void button1_Click(object sender, EventArgs e)
        {

                if (radioButton1.Checked)
                {
                    ESCOLHA = 1;
                    E1 = "X";
                    E2 = "O";
                    MessageBox.Show("Jogador1: " + J1 + " " + "Jogará com ---> X" + "\n" + "Jogador2: " + J2 + " " + "Jogará com ---> O");
                }
                if (radioButton2.Checked)
                {
                    ESCOLHA = 2;
                    E1 = "O";
                    E2 = "X";
                    MessageBox.Show("Jogador1: " + J1 + " " + "Jogará com ---> O" + "\n" + "Jogador2: " + J2 + " " + "Jogará com ---> X");
                }

          
            
            this.Hide();

           J1 = textBox1.Text; // nome do jogador 1
           J2 = textBox2.Text; // nome do jogador 2

            Multiplayer mathou = new Multiplayer(this);
            mathou.ShowDialog();

        
        }

        private void Nickname_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 minato = new Form1();
            minato.Show();
        }
    }
}
