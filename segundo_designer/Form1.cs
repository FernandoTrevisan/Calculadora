using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace segundo_designer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(textBox1.Text);

            int n2 = int.Parse(textBox2.Text);

            int resultado = n1 + n2;

            textBox3.Text = resultado.ToString();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }

        

        private void btnFechar_Click_1(object sender, EventArgs e)
        {

            Application.Exit();
        }
    }
}
