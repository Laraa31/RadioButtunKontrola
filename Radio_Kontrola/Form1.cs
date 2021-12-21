using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radio_Kontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonRezerviraj_Click(object sender, EventArgs e)
        {
            if (radioButtonAutobus.Checked)
            {
                textBox1.Text = "Odabrali ste prijevoz autobusom.";

            }

            if (radioButtonAvion.Checked)
            {
                textBox1.Text = "Odabrali ste prijevoz avionom.";
            }

            if (radioButtonVlastiti.Checked){
                textBox1.Text = "Odabrali ste vlastiti prijevoz.";
            }
        }
    }
}
