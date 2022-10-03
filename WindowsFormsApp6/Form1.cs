using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(@"C:\Users\t.student\Desktop\Новая папка\", "*.*");
            int qt = files.Length;
            progressBar1.Maximum = qt;
            while ( qt > 0)
            {
                File.Delete(files[qt - 1]);
                label1.Text = files[qt - 1];
                progressBar1.Value++;
                qt--;
                await Task.Delay(100);
            }
       label1.Text = (numericUpDown1.Value / numericUpDown2.Value).ToString(); 
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
            
        {
          
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {


        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void chtotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Устал? Иди спать...";
        }
    }
}
