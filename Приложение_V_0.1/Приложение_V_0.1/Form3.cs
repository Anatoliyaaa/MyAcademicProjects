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
    public partial class Form3 : Form
    {
        int count = 1;

        int i = 0;
        int j = 0;

        double nx = SectorCounting.nx;
        double ny = SectorCounting.ny;

        static int Nrc;

        int A = SectorCounting.A;
        int B = SectorCounting.B;

        List<MyPoint> demopoint = new List<MyPoint>();

        MyPoint mp;

        public Form3(int nRc)
        {
            InitializeComponent();
            Nrc = nRc;
            lN.Text = Convert.ToString(SectorCounting.Ncount());
            lNRC.Text = Convert.ToString(Nrc);
            MyPoint m = new MyPoint(45.113771, 39.133798, 0, true);
            mp = m;
            //demopoint.Add(m);
        }


        private void bExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            MyPoint point = new MyPoint(SectorCounting.d2 - i * ny, SectorCounting.sh1 + j * nx, Convert.ToDouble(textBox1.Text), false);
            demopoint.Add(point);
            j++;
            count++;


            if (j == B && i != A-1)
            {
                i++;
                j = 0;
            }

            if(i == A-1 && j == B) 
            {
                //текущее рц(построенное)
                for (int q = 0; q < demopoint.Count; q++)
                {
                    if (demopoint[q]._x >= mp._x && demopoint[q]._x - nx <= mp._x && demopoint[q]._y <= mp._y && demopoint[q]._y + ny >= mp._y)
                      demopoint[q] = mp;
                }



                MessageBox.Show("Экономические данные для всех возможных мест введены\n\r\nИз всего списка выбраны лучшие точки для размещения");
                MyPoint.DemoSort(demopoint);
                while (demopoint.Count != Nrc)
                {
                    demopoint.RemoveAt(demopoint.Count - 1 );
                }


                FMap f = new FMap(demopoint);
                f.Show();
                this.Close();
                return;
            }
            lpoint.Text = Convert.ToString(count);


        }
    }
}
