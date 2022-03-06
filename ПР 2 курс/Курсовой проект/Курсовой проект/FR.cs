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
    public partial class FR : Form
    {
        public FR()
        {
            InitializeComponent();
            tname.Text = "Введите имя";
            tph.Text = "Введите фамилию";
            tlogin.Text = "Введите логин";
            tlogin.ForeColor = Color.Gray;
            tname.ForeColor = Color.Gray;
            tph.ForeColor = Color.Gray;
        }
        public Boolean isloginuse()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();


            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @lu", db.getConnection());
            command.Parameters.Add("@lu", MySqlDbType.VarChar).Value = tlogin.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {

                MessageBox.Show("Логин уже занят");
                return true;
            }
            else
            {
 
                return false;
            }

        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (tpassword.UseSystemPasswordChar == false)
            { tpassword.UseSystemPasswordChar = true; button2.BackgroundImage = Properties.Resources.kiss; }
            else { tpassword.UseSystemPasswordChar = false; button2.BackgroundImage = Properties.Resources.kissb; }
        }
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if(tname.Text== "Введите имя" || tph.Text == "Введите фамилию" || tpassword.Text=="")
            {
                MessageBox.Show("Не все обязательные поля были введены");
                return;

            }

            if (isloginuse())
                return;


            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `name`, `ph`) VALUES (@login, @password, @name, @ph)", db.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = tlogin.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = tpassword.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = tname.Text;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = tph.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Аккаунт был создан");
            else
                MessageBox.Show("Аккаунт не был создан");

            db.closeConnection();
        }


        private void bExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FR_Load(object sender, EventArgs e)
        {

        }

        private void labelR_Click(object sender, EventArgs e)
        {
            this.Close();
            FA fa = new FA();
            fa.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tname_Enter(object sender, EventArgs e)
        {
            if (tname.Text == "Введите имя")
            { tname.Text = ""; tname.ForeColor = Color.Black; }
        }

        private void tph_Enter(object sender, EventArgs e)
        {
            if (tph.Text == "Введите фамилию")
            { tph.Text = ""; tph.ForeColor = Color.Black; }
        }

        private void tlogin_Enter(object sender, EventArgs e)
        {
            if (tlogin.Text == "Введите логин")
            { tlogin.Text = ""; tlogin.ForeColor = Color.Black; }
        }

        private void tname_Leave(object sender, EventArgs e)
        {
            if (tname.Text == "")
            { tname.Text = "Введите имя"; tname.ForeColor = Color.Gray; }
        }

        private void tph_Leave(object sender, EventArgs e)
        {
            if (tph.Text == "")
            { tph.Text = "Введите фамилию"; tph.ForeColor = Color.Gray; }
        }

        private void tlogin_Leave(object sender, EventArgs e)
        {
            if (tlogin.Text == "")
            { tlogin.Text = "Введите логин"; tlogin.ForeColor = Color.Gray; }
        }


    }
}
