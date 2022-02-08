using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int unico = 0;
        Color cor = Color.Black;
        public Form1()
        {
            InitializeComponent();
            label1.Text = "(0:0:0)";
        }

        private void cmd_cima_Click(object sender, EventArgs e)
        {
          
        }


        private void cmd_direita_Click(object sender, EventArgs e)
        {

         
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
           

        }
        private void apresentar()
        {
            Color cor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            treeView1.BackColor = cor;
            label1.Text = "(" + trackBar1.Value +":"+ trackBar2.Value +":"+ trackBar3.Value + ")";
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

            apresentar();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            apresentar();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            apresentar();
        }
        private void palheta_cores()
        {
            StreamReader banco_de_dados = new StreamReader(@"C:\Nova pasta\Dados.txt");
           
            while (banco_de_dados.EndOfStream == false)
            {
                listBox1.Items.Add(banco_de_dados.ReadLine());
            }
            banco_de_dados.Dispose();
        }
        private void cmd_pulo_Click(object sender, EventArgs e)
        {
            StreamWriter banco_de_dados = new StreamWriter(@"C:\Nova pasta\Dados.txt", true, Encoding.Default);
            banco_de_dados.WriteLine(label1.Text);
            banco_de_dados.Dispose();
            if (unico == 0 )
            {
                palheta_cores();
                unico += 1;
            }
            else
            {
                listBox1.Items.Add(label1.Text);
            }
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmd_esquerda_Click(object sender, EventArgs e)
        {

        }
    }
}
