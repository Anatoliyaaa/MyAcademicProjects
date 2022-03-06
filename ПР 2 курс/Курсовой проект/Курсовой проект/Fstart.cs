using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static Курсовой_проект.Program;


namespace Курсовой_проект
{
    public partial class Fstart : Form
    {
       
        public Fstart(int q, int id)
        {
            n = q;
            ID = id;
            InitializeComponent();

            if (ID!=0)
            {
                DB db = new DB();
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();



                db.openConnection();
                MySqlCommand command = new MySqlCommand("SELECT name FROM `users` WHERE `id`=@id", db.getConnection());
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = ID;
                if (ID == 1)
                    lname.Text ="Здраствуйте, Администратор " + command.ExecuteScalar().ToString();
                else
                    lname.Text =  command.ExecuteScalar().ToString();
                db.closeConnection();
            }
            

        }
        int n ;
        int ID;
        private void Fstart_Load(object sender, EventArgs e)
        {

            if (n == 0)
            {
                this.Visible = false;
                this.ShowInTaskbar = false;
                FA fa = new FA();
                fa.ShowDialog();
                n++;
            }
            else
            {
                this.Visible = true;
                this.ShowInTaskbar = true;
            }
            


        }

        private void bExit_Click(object sender, EventArgs e)
        {
            

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.google.com/search?tbs=lf:1,lf_ui:2&tbm=lcl&sxsrf=ALeKk011NQlTJFJlHM9d47CYCclkiznxsQ:1607705400292&q=%D1%81%D0%BF%D0%BE%D1%80%D1%82%D0%B7%D0%B0%D0%BB&rflfq=1&num=10&ved=2ahUKEwifoaaqscbtAhVSw4sKHUK_BA4QtgN6BAgCEAc#rlfi=hd:;si:6585044915610633280,l,ChDRgdC_0L7RgNGC0LfQsNC7WiQKENGB0L_QvtGA0YLQt9Cw0LsiENGB0L_QvtGA0YLQt9Cw0Ls;mv:[[45.2464817,34.180439799999995],[44.5492693,33.2914356]]");

        }

        private void bpl_Click(object sender, EventArgs e)
        {

            if (c1.Text == "1")
            {
                p1.BackgroundImage = Properties.Resources.ф5;
                p2.BackgroundImage = Properties.Resources.ф1;
                p3.BackgroundImage = Properties.Resources.ф2;
                c1.Text = "5";
            }
            else if (c1.Text == "2")
            {
                p1.BackgroundImage = Properties.Resources.ф1;
                p2.BackgroundImage = Properties.Resources.ф2;
                p3.BackgroundImage = Properties.Resources.ф3;
                c1.Text = "1";
            }
            else if (c1.Text == "3")
            {
                p1.BackgroundImage = Properties.Resources.ф2;
                p2.BackgroundImage = Properties.Resources.ф3;
                p3.BackgroundImage = Properties.Resources.ф4;
                c1.Text = "2";
            }
            else if (c1.Text == "4")
            {
                p1.BackgroundImage = Properties.Resources.ф3;
                p2.BackgroundImage = Properties.Resources.ф4;
                p3.BackgroundImage = Properties.Resources.ф5;
                c1.Text = "3";
            }
            else if (c1.Text == "5")
            {
                p1.BackgroundImage = Properties.Resources.ф4;
                p2.BackgroundImage = Properties.Resources.ф5;
                p3.BackgroundImage = Properties.Resources.ф1;
                c1.Text = "4";
            }

        }

        private void bpr_Click(object sender, EventArgs e)
        {
            if (c1.Text == "1")
            {
                p1.BackgroundImage = Properties.Resources.ф2;
                p2.BackgroundImage = Properties.Resources.ф3;
                p3.BackgroundImage = Properties.Resources.ф4;
                c1.Text = "2";
            }
            else if (c1.Text == "2")
            {
                p1.BackgroundImage = Properties.Resources.ф3;
                p2.BackgroundImage = Properties.Resources.ф4;
                p3.BackgroundImage = Properties.Resources.ф5;
                c1.Text = "3";
            }
            else if (c1.Text == "3")
            {
                p1.BackgroundImage = Properties.Resources.ф4;
                p2.BackgroundImage = Properties.Resources.ф5;
                p3.BackgroundImage = Properties.Resources.ф1;
                c1.Text = "4";
            }
            else if (c1.Text == "4")
            {
                p1.BackgroundImage = Properties.Resources.ф5;
                p2.BackgroundImage = Properties.Resources.ф1;
                p3.BackgroundImage = Properties.Resources.ф2;
                c1.Text = "5";
            }
            else if (c1.Text == "5")
            {
                p1.BackgroundImage = Properties.Resources.ф1;
                p2.BackgroundImage = Properties.Resources.ф2;
                p3.BackgroundImage = Properties.Resources.ф3;
                c1.Text = "1";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel3.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.google.com/search?tbs=lf:1,lf_ui:2&tbm=lcl&sxsrf=ALeKk011NQlTJFJlHM9d47CYCclkiznxsQ:1607705400292&q=%D1%81%D0%BF%D0%BE%D1%80%D1%82%D0%B7%D0%B0%D0%BB&rflfq=1&num=10&ved=2ahUKEwifoaaqscbtAhVSw4sKHUK_BA4QtgN6BAgCEAc#rlfi=hd:;si:6585044915610633280,l,ChDRgdC_0L7RgNGC0LfQsNC7WiQKENGB0L_QvtGA0YLQt9Cw0LsiENGB0L_QvtGA0YLQt9Cw0Ls;mv:[[45.2464817,34.180439799999995],[44.5492693,33.2914356]]");

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel2.LinkVisited = true;
            System.Diagnostics.Process.Start("https://striga.me/");

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            FVT fVT = new FVT(ID);
            fVT.Show();
        }

        private void lname_Click(object sender, EventArgs e)
        {

        }
    }
}
