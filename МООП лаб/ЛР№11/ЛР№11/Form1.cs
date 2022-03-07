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

namespace ЛР_11
{
    public partial class Form1 : Form
    {
        File f;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Только формат .txt");
            Stream myStr = null; 
            OpenFileDialog OpenTags = new OpenFileDialog();
            OpenTags.Filter = "All file + - Text file |*.txt";

            if (OpenTags.ShowDialog() == DialogResult.OK)
            {
                if ((myStr = OpenTags.OpenFile()) != null)
                {
                    f = new TextFile(OpenTags);
                    StreamReader myRead = new StreamReader(myStr, System.Text.Encoding.UTF8);
                    textBox.Text = OpenTags.FileName + "\n" + System.IO.File.GetCreationTime(OpenTags.FileName);
                }
            }


        }

        private void NameBox_CheckedChanged(object sender, EventArgs e)
        {
            File file = f;
            if (NameBox.Checked)
                f = new FileName(f);
            textBox.Text = f.PrintText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File file = f;
            if (NameBox.Checked & DataBox.Checked & NumBox.Checked)
            {
                file = new FileName(file);
                file = new FileData(file);
                file = new FileNumStr(file);
            }
            if (NameBox.Checked & DataBox.Checked & !NumBox.Checked)
            {
                file = new FileName(file);
                file = new FileData(file);
            }
            if (NameBox.Checked & !DataBox.Checked & NumBox.Checked)
            {
                file = new FileName(file);
                file = new FileNumStr(file);
            }
            if (!NameBox.Checked & DataBox.Checked & NumBox.Checked)
            {
                file = new FileData(file);
                file = new FileNumStr(file);
            }
            if (NameBox.Checked & !DataBox.Checked & !NumBox.Checked)
            {
                file = new FileName(file);
            }
            if (!NameBox.Checked & DataBox.Checked & !NumBox.Checked)
            {
                file = new FileData(file);
            }
            if (!NameBox.Checked & !DataBox.Checked & NumBox.Checked)
            {
                file = new FileNumStr(file);
            }
            textBox.Text = file.PrintText();


        }

        private void DataBox_CheckedChanged(object sender, EventArgs e)
        {
            File file = f;
            if (DataBox.Checked)
            {
                f = new FileData(f);
                textBox.Text = f.PrintText();
            }
            else
            {
                textBox.Text = file.PrintText();
            }
             
                
        }
    }
}
