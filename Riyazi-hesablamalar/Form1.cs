using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Riyazi_hesablamalar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int birteref, sahe, cevre;

            birteref = Convert.ToInt32(textBox1.Text);
            sahe = birteref * birteref;
            cevre = birteref * 4;

            label4.Text = sahe.ToString();
            label6.Text = cevre.ToString();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label7.Visible = false;
            textBox2.Visible = false;
            button2.Visible = false;
            label1.Text = "Kvadrat";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label1.Text = "Düzbucaqlı";
            button2.Visible = true;
            button4.Visible = false;
            label7.Visible = true;
            textBox2.Visible = true;


           




        }

        private void button2_Click(object sender, EventArgs e)
        {
            int uzunteref, qisateref, sahe, cevre;
            uzunteref = Convert.ToInt32(textBox2.Text);
            qisateref = Convert.ToInt32(textBox1.Text);

            sahe = uzunteref * qisateref;
            cevre = (uzunteref * 2) + (qisateref * 2);

            label4.Text = sahe.ToString();
            label6.Text = cevre.ToString();
        }
    }
}
