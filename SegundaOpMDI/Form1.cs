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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newMDIChild = new Form2();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 newMDIChild = new Form3();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            Clipboard.SetText(string.Format("{0}{1}\n{2}{3}\n{4}{5}\n{6}{7}\n{8}{9}\n{10}{11}",
                form2.label1.Text, Form2.tb1, form2.label2.Text, Form2.tb2, form2.label3.Text,
                Form2.tb3, form2.label4.Text, Form2.cb, form2.label5.Text, Form2.dt,
                "Sexo: ",Form2.lb6));
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            if (activeChild != null)
            {
                try
                {
                    RichTextBox theBox = (RichTextBox)activeChild.ActiveControl;
                    if (theBox != null)
                    {
                        IDataObject data = Clipboard.GetDataObject();
                        if (data.GetDataPresent(DataFormats.Text))
                        {
                            theBox.SelectedText = data.GetData(DataFormats.Text).ToString();
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Necesitas Seleccionar Un RichTextBox");
                }
            }
        }

        private void registrarseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newMDIChild = new Form2();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void reporteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 newMDIChild = new Form3();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }
    }
}
