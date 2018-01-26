using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = "ilk satır" + Environment.NewLine;
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            File.WriteAllText(mydocpath + @"\WriteFile.txt", text);
            string[] lines = { "adı soyadı - cinsiyeti - koltuk no" };
            File.AppendAllLines(mydocpath + @"\WriteFile.txt", lines);

            StreamReader sr = new StreamReader(mydocpath + @"\WriteFile.txt");
            string line;
            line = sr.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                line = sr.ReadLine();
            }
            sr.Close();
        }

        private void btbyeniform_Click(object sender, EventArgs e)
        {
            KayıtForm kf = new KayıtForm(this);
            kf.ShowDialog();
        }
        public void datagridekle (string AdSoyad,string cinsiyet,string koltukno,string fiyat)
        {
            dataGridView1.Rows.Add(AdSoyad, cinsiyet, koltukno, fiyat,DateTime.Now.ToShortDateString());
        }
    }
}
