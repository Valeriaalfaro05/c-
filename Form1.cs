using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica0001
{
    public partial class Form1 : Form
    {
        int vResultado;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

  
        }
        
private void btnsuma_Click(object sender, EventArgs e)
        {
            vResultado = Convert.ToInt32(textnum1.Text) + Convert.ToInt32(textnum2.Text);
            lblresult.Text = vResultado.ToString();
            lblsigno.Text = "+";
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            vResultado = Convert.ToInt32(textnum1.Text) - Convert.ToInt32(textnum2.Text);
            lblresult.Text = vResultado.ToString();
            lblsigno.Text = "-";
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            vResultado = Convert.ToInt32(textnum1.Text) * Convert.ToInt32(textnum2.Text);
            lblresult.Text = vResultado.ToString();
            lblsigno.Text = "x";
        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            vResultado = Convert.ToInt32(textnum1.Text) / Convert.ToInt32(textnum2.Text);
            lblresult.Text = vResultado.ToString();
            lblsigno.Text = "/";
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            textnum1.Text = "";
            lblsigno.Text = "000";
            lblresult.Text = "";
            textnum2.Text = "";
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();        }
    }
        }
    