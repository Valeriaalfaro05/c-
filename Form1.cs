using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnarea_Click(object sender, EventArgs e)
        {
            if
                (double.TryParse(textBox2.Text, out
                double radio
                ))
            {
                double area = Math.PI * Math.Pow(radio, 2);
                txtarea.Text = area.ToString("F2");
            }

            else
            {
                MessageBox.Show("ingrese un " +
                    "numero valido para el radio.", "error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnperi_Click(object sender, EventArgs e)
        {
            if
               (double.TryParse(textBox2.Text, out
               double radio
               ))
            {
                double perimetro = 2 * Math.PI * radio;
                txtperi.Text = perimetro.ToString("F2");
            }

            else
            {
                MessageBox.Show("ingrese un " +
                    "numero valido para el radio.", "error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
           
        }
    }

}
