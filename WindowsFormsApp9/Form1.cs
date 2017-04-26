using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            double result=0;
            string numeric = new String(textBox1.Text.ToCharArray().Where(c => Char.IsDigit(c)).ToArray());
            label1.Text = numeric;
           for (int i=0; i<numeric.Length; i++)
            {
                result = result + Char.GetNumericValue(numeric[i]);
            }
            result = result / numeric.Length;
            label1.Text = result.ToString();
        }
    }
}
