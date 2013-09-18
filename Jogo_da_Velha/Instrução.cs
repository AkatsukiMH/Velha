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
    public partial class Instrução : Form
    {
        public Instrução()
        {
            InitializeComponent();
        }

        private void Instrução_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 madara = new Form1();
            madara.Show();
        }

        private void mm(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27 || e.KeyChar == 13)
            {
                this.Visible = false;
            }
        }
        }
    }

