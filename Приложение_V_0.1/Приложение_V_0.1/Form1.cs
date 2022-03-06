using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Приложение_V_0._1
{
    public partial class FVR : Form
    {
        public FVR()
        {
            InitializeComponent();
            comboBoxR.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxR.Text != "")
            {
                FPCRC fPCRC = new FPCRC(comboBoxR.Text);
                this.Visible = false;
                this.ShowInTaskbar = false;
                fPCRC.ShowDialog();
            }
            else
            {
                MessageBox.Show("Регион не выбран");
            }

        }

        private void comboBoxR_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
