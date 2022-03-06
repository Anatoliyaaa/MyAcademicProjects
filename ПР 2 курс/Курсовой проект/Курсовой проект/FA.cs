using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Курсовой_проект
{
    public partial class FA : Form
    {
        public FA()
        {
            InitializeComponent();
            tlogin.Text = "Введите логин";
            tlogin.ForeColor = Color.Gray;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string loginuser = tlogin.Text;
            string passwprduser = tpassword.Text;
            int id;

            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();


            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @lu AND `password` = @pu", db.getConnection());
            command.Parameters.Add("@lu", MySqlDbType.VarChar).Value = loginuser;
            command.Parameters.Add("@pu", MySqlDbType.VarChar).Value = passwprduser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                db.openConnection();
                MySqlCommand command1 = new MySqlCommand("SELECT id FROM `users` WHERE `login`= @lu", db.getConnection());
                command1.Parameters.Add("@lu", MySqlDbType.VarChar).Value = loginuser;
                id =Convert.ToInt32( command1.ExecuteScalar().ToString());
                MessageBox.Show("Вход успешно выполнен");
                db.closeConnection();
                this.Close();               
                Fstart fstart = new Fstart(1,id);
                //fstart.Visible = true;
                //fstart.ShowInTaskbar = true;
                fstart.Show();


            }

            else MessageBox.Show("Вы не зарегистрированы");

            

        }

        private void fwho_Load(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(button2, "Показать/скрыть пароль");
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (tpassword.UseSystemPasswordChar == false)
            { tpassword.UseSystemPasswordChar = true; button2.BackgroundImage = Properties.Resources.kiss; }
            else { tpassword.UseSystemPasswordChar = false; button2.BackgroundImage = Properties.Resources.kissb; }
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
            //Fstart fstart = new Fstart();
            //fstart.Visible = false;
            //fstart.ShowInTaskbar = false;
            FR fr = new FR(); /*Form fstart = Application.OpenForms[0]; fstart.Show();*/
            fr.Show();
        }

        private void tlogin_Enter(object sender, EventArgs e)
        {
            if (tlogin.Text == "Введите логин")
            { tlogin.Text = ""; tlogin.ForeColor = Color.Black; }
        }

        private void tlogin_Leave(object sender, EventArgs e)
        {
            if (tlogin.Text == "")
            { tlogin.Text = "Введите логин"; tlogin.ForeColor = Color.Gray; }
        }

        private void bExit_MouseEnter(object sender, EventArgs e)
        {

        }
    }
}
