using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RC_comparison_method_options;

namespace Приложение_V_0._1
{
    public partial class FPCRC : Form
    {
        string _RName;

        public FPCRC(string r)
        {
            InitializeComponent();
            _RName = r;
            lR.Text = "Выбранный регион: " + _RName;

            RC rc = new RC(10,10 , 10, 10);
            CMO_RC.Add(rc);
            lCRC.Text =Convert.ToString( CMO_RC.CountRC());


        }

        private void FPCRC_Load(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs E)
        {

            try
            {
                double k = Convert.ToDouble(textBoxK.Text);
                double e = Convert.ToDouble(textBoxE.Text);
                double isi = Convert.ToDouble(textBoxIs.Text);
                double it = Convert.ToDouble(textBoxIt.Text);
                RC rc = new RC(k,e,isi,it);

                if (CMO_RC.IsYetRC(rc))
                {
                    lTF.Text = "Нужно";

                }
                else
                {
                    lTF.Text = "Не нужно";
                }
                lCRC.Text = Convert.ToString(CMO_RC.CountRC());
            }
            catch
            {

            }
}

        private void bExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int n = CMO_RC.CountRC();
            Form3 f3 = new Form3(CMO_RC.CountRC());
            f3.Show();
            this.Close();
        }
    }
}
