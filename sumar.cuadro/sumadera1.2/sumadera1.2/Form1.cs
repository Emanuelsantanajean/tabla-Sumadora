using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sumadera1._2
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
      
        private void suma(object sender, EventArgs e)
        {
           
        }

        private void txt_num1_TextChanged(object sender, EventArgs e)
        {
            txt_resultado1.Text = Convert.ToString(int.Parse(txt_num1.Text) + int.Parse (txt_num2.Text) + int.Parse(txt_num3.Text) + int.Parse(txt_num4.Text) + int.Parse(txt_num5.Text));
            txt_resultado4.Text = Convert.ToString(int.Parse(txt_num1.Text) + int.Parse(txt_num6.Text) + int.Parse(txt_num11.Text));
        }

        private void txt_num2_TextChanged(object sender, EventArgs e)
        {
            txt_resultado1.Text = Convert.ToString(int.Parse(txt_num1.Text) + int.Parse(txt_num2.Text) + int.Parse(txt_num3.Text) + int.Parse(txt_num4.Text) + int.Parse(txt_num5.Text));
            txt_resultado4.Text = Convert.ToString(int.Parse(txt_num1.Text) + int.Parse(txt_num6.Text) + int.Parse(txt_num11.Text));
        }

        private void txt_num3_TextChanged(object sender, EventArgs e)
        {
            txt_resultado1.Text = Convert.ToString(int.Parse(txt_num1.Text) + int.Parse(txt_num2.Text) + int.Parse(txt_num3.Text) + int.Parse(txt_num4.Text) + int.Parse(txt_num5.Text));
            txt_resultado4.Text = Convert.ToString(int.Parse(txt_num1.Text) + int.Parse(txt_num6.Text) + int.Parse(txt_num11.Text));
        }

        private void txt_num4_TextChanged(object sender, EventArgs e)
        {
            txt_resultado1.Text = Convert.ToString(int.Parse(txt_num1.Text) + int.Parse(txt_num2.Text) + int.Parse(txt_num3.Text) + int.Parse(txt_num4.Text) + int.Parse(txt_num5.Text));
            txt_resultado4.Text = Convert.ToString(int.Parse(txt_num1.Text) + int.Parse(txt_num6.Text) + int.Parse(txt_num11.Text));
        }

        private void txt_num5_TextChanged(object sender, EventArgs e)
        {
            txt_resultado1.Text = Convert.ToString(int.Parse(txt_num1.Text) + int.Parse(txt_num2.Text) + int.Parse(txt_num3.Text) + int.Parse(txt_num4.Text) + int.Parse(txt_num5.Text));
            txt_resultado4.Text = Convert.ToString(int.Parse(txt_num1.Text) + int.Parse(txt_num6.Text) + int.Parse(txt_num11.Text));

        }

        private void txt_num6_TextChanged(object sender, EventArgs e)
        {
            txt_resultado2.Text = Convert.ToString(int.Parse(txt_num6.Text) + int.Parse(txt_num7.Text) + int.Parse(txt_num8.Text) + int.Parse(txt_num9.Text) + int.Parse(txt_num10.Text));
            txt_resultado4.Text = Convert.ToString(int.Parse(txt_num1.Text) + int.Parse(txt_num6.Text) + int.Parse(txt_num11.Text));
        }

        private void txt_num7_TextChanged(object sender, EventArgs e)
        {
            txt_resultado2.Text = Convert.ToString(int.Parse(txt_num6.Text) + int.Parse(txt_num7.Text) + int.Parse(txt_num8.Text) + int.Parse(txt_num9.Text) + int.Parse(txt_num10.Text));
            txt_resultado4.Text = Convert.ToString(int.Parse(txt_num1.Text) + int.Parse(txt_num6.Text) + int.Parse(txt_num11.Text));
        }

        private void txt_num8_TextChanged(object sender, EventArgs e)
        {
            txt_resultado2.Text = Convert.ToString(int.Parse(txt_num6.Text) + int.Parse(txt_num7.Text) + int.Parse(txt_num8.Text) + int.Parse(txt_num9.Text) + int.Parse(txt_num10.Text));
            txt_resultado4.Text = Convert.ToString(int.Parse(txt_num1.Text) + int.Parse(txt_num6.Text) + int.Parse(txt_num11.Text));
        }

        private void txt_num9_TextChanged(object sender, EventArgs e)
        {
            txt_resultado2.Text = Convert.ToString(int.Parse(txt_num6.Text) + int.Parse(txt_num7.Text) + int.Parse(txt_num8.Text) + int.Parse(txt_num9.Text) + int.Parse(txt_num10.Text));
            txt_resultado4.Text = Convert.ToString(int.Parse(txt_num1.Text) + int.Parse(txt_num6.Text) + int.Parse(txt_num11.Text));
        }

        private void txt_num10_TextChanged(object sender, EventArgs e)
        {
            txt_resultado2.Text = Convert.ToString(int.Parse(txt_num6.Text) + int.Parse(txt_num7.Text) + int.Parse(txt_num8.Text) + int.Parse(txt_num9.Text) + int.Parse(txt_num10.Text));
            txt_resultado4.Text = Convert.ToString(int.Parse(txt_num1.Text) + int.Parse(txt_num6.Text) + int.Parse(txt_num11.Text));
        }

        private void txt_num11_TextChanged(object sender, EventArgs e)
        {
            txt_resultado3.Text = Convert.ToString(int.Parse(txt_num11.Text) + int.Parse(txt_num12.Text) + int.Parse(txt_num13.Text) + int.Parse(txt_num14.Text) + int.Parse(txt_num15.Text));
            txt_resultado4.Text = Convert.ToString(int.Parse(txt_num1.Text) + int.Parse(txt_num6.Text) + int.Parse(txt_num11.Text));
        }

        private void txt_num12_TextChanged(object sender, EventArgs e)
        {
            txt_resultado3.Text = Convert.ToString(int.Parse(txt_num11.Text) + int.Parse(txt_num12.Text) + int.Parse(txt_num13.Text) + int.Parse(txt_num14.Text) + int.Parse(txt_num15.Text));
            txt_resultado4.Text = Convert.ToString(int.Parse(txt_num1.Text) + int.Parse(txt_num6.Text) + int.Parse(txt_num11.Text));
        }

        private void txt_num13_TextChanged(object sender, EventArgs e)
        {
            txt_resultado3.Text = Convert.ToString(int.Parse(txt_num11.Text) + int.Parse(txt_num12.Text) + int.Parse(txt_num13.Text) + int.Parse(txt_num14.Text) + int.Parse(txt_num15.Text));
            txt_resultado4.Text = Convert.ToString(int.Parse(txt_num1.Text) + int.Parse(txt_num6.Text) + int.Parse(txt_num11.Text));
        }

        private void txt_num14_TextChanged(object sender, EventArgs e)
        {
            txt_resultado3.Text = Convert.ToString(int.Parse(txt_num11.Text) + int.Parse(txt_num12.Text) + int.Parse(txt_num13.Text) + int.Parse(txt_num14.Text) + int.Parse(txt_num15.Text));
        }

        private void txt_num15_TextChanged(object sender, EventArgs e)
        {
            txt_resultado3.Text = Convert.ToString(int.Parse(txt_num11.Text) + int.Parse(txt_num12.Text) + int.Parse(txt_num13.Text) + int.Parse(txt_num14.Text) + int.Parse(txt_num15.Text));
        }
    }
}
