using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class KayıtForm : Form
    {
        Form1 Frm;
        public KayıtForm(Form1 frm)
        {
            InitializeComponent();
            comboBox1.Items.Add("Erkek");
            comboBox1.Items.Add("Kadın");
            Frm = frm;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm.datagridekle(txtad.Text,comboBox1.Text,txtkoltukno.Text,txtfiyat.Text);
        }
    }
}
