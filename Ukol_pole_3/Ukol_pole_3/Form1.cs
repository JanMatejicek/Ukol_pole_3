using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ukol_pole_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            char[] array = text.ToCharArray();
            int velikost = array.Length - 1;
            
            if (array[velikost] >= 48 && array[velikost] <= 57) {
                for (int i = 0; i <= velikost; i++) {
                    if (array[i] >= 48 && array[i] <= 57) { array[i] = 'x'; }
                }
            }
            else {
                int max = array.Max();
                int poz_max = Array.IndexOf(array, Convert.ToChar(max));
                array[poz_max] = array[velikost];
                array[velikost] = Convert.ToChar(max);
            }
            textBox2.Text = new string(array);
        }
    }
}
