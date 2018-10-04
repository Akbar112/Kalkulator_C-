using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        double value = 0;
        string operasi = "";
        bool operasi_pressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (operasi_pressed))
                result.Clear();

            operasi_pressed = false;
            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void operasi_tombol(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operasi = b.Text;
            value = double.Parse(result.Text);
            operasi_pressed = true;
            equation.Text = value + "" + operasi;
            equation.Text = value + "" + operasi;
        }

        private void button16_Click(object sender, EventArgs e)
        {
          
            equation.Text = "";
            switch (operasi)
            {
                case "+":
                    result.Text = (value + double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;

            }//switch selesai
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            result.Clear();
            value = 0;
        }
    }
}
