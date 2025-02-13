using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnconvertir1_Click(object sender, EventArgs e)
        {
            float cent = float.Parse(this.textBox1.Text);
            float fair = (cent * 9 / 5) + 32;
            this.convertir.Text = fair.ToString();


        }

        private void btnconvertir_Click(object sender, EventArgs e)
        {
            float cent = float.Parse(this.textBox2.Text);
            float fair = (cent -32) * 5/9;
            this.convertir1.Text = fair.ToString();

        }

        private void CERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
