using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundaOpMDI
{
    public partial class Form2 : Form
    {
        internal static string tb1, tb2, tb3, lb6, cb, dt;

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.SelectedItem = 0;
            dateTimePicker1.ResetText();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label6.Text = radioButton1.Text;
            }
            else if (radioButton2.Checked == true)
            {
                label6.Text=radioButton2.Text;
            }
            else if (radioButton3.Checked == true)
            {
                label6.Text=radioButton3.Text;
            }

            tb1 = textBox1.Text;
            tb2 = textBox2.Text;
            tb3 = textBox3.Text;
            lb6 = label6.Text;
            cb = (String)comboBox1.SelectedItem;
            dt = dateTimePicker1.Text;

            MessageBox.Show("¿Está Seguro Que Desea Guardar?","Guardar", MessageBoxButtons.YesNoCancel);
        }
    }
}
    