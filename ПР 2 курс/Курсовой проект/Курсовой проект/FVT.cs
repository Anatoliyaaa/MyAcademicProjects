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
    public partial class FVT : Form
    {
        public FVT(int id)
        {
            ID = id;
            InitializeComponent();
            // admin
            if (id == 1)
            {
                bz.Visible = false;
                bd.Visible = false;
            }
            else
            {
                bA.Visible = false;
                tbIDA.Visible = false;
                label3.Visible = false;
            }
            
        }
        int ID;
        string[] st = new string [] { "Куликов А.А.", "Борщева С.В.", "Макарова А.К.", "Чередниченко М.А." };
        private void bExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rm_Click(object sender, EventArgs e)
        {
            if (rm.Checked)
            {
                vt.Items.Clear();
                vt.Items.Add(st[0]);
                vt.Items.Add(st[1]);
            }
        }

        private void rv_Click(object sender, EventArgs e)
        {
            if (rv.Checked)
            {
                vt.Items.Clear();
                vt.Items.Add(st[2]);
                vt.Items.Add(st[3]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (vt.Text == "")
            { MessageBox.Show("Вы не выбрали тренера"); return; }

            DB db = new DB();

            if (isuserindb())
                return;


            if (vt.Text == st[0])// zapis` k 1 treneru
            {


                MySqlCommand command = new MySqlCommand("INSERT INTO `t1m` (`id`) VALUES (@id)", db.getConnection());
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = ID;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Вы записались на тренировки");
                else
                    MessageBox.Show("Вы не записались на тренировки");

                db.closeConnection();

            }
            if (vt.Text == st[1])// zapis` k 2 treneru
            {


                MySqlCommand command = new MySqlCommand("INSERT INTO `t2m` (`id`) VALUES (@id)", db.getConnection());
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = ID;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Вы записались на тренировки");
                else
                    MessageBox.Show("Вы не записались на тренировки");

                db.closeConnection();

            }
            if (vt.Text == st[2])// zapis` k 3 treneru
            {


                MySqlCommand command = new MySqlCommand("INSERT INTO `t1v` (`id`) VALUES (@id)", db.getConnection());
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = ID;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Вы записались на тренировки");
                else
                    MessageBox.Show("Вы не записались на тренировки");

                db.closeConnection();

            }
            if (vt.Text == st[3])// zapis` k 4 treneru
            {


                MySqlCommand command = new MySqlCommand("INSERT INTO `t2v` (`id`) VALUES (@id)", db.getConnection());
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = ID;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Вы записались на тренировки");
                else
                    MessageBox.Show("Вы не записались на тренировки");

                db.closeConnection();

            }

        }
        private void bd_Click(object sender, EventArgs e)
        {
            if (vt.Text == "")
            { MessageBox.Show("Вы не выбрали тренера"); return; }

            DB db = new DB();

            //if (isnotuserindb())
            //    return;
            if (vt.Text == st[0])// zapis` k 1 treneru
            {


                MySqlCommand command = new MySqlCommand("DELETE FROM `t1m` WHERE `id`=@id", db.getConnection());
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = ID;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Вы удалили запись на тренировки");
                else
                    MessageBox.Show("Вы не записаны в эту группу");

                db.closeConnection();

            }
            if (vt.Text == st[1])// zapis` k 2 treneru
            {


                MySqlCommand command = new MySqlCommand("DELETE FROM `t2m` WHERE `id`=@id", db.getConnection());
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = ID;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Вы удалили запись на тренировки");
                else
                    MessageBox.Show("Вы не записаны в эту группу");

                db.closeConnection();

            }
            if (vt.Text == st[2])// zapis` k 3 treneru
            {


                MySqlCommand command = new MySqlCommand("DELETE FROM `t1v` WHERE `id`=@id", db.getConnection());
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = ID;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Вы удалили запись на тренировки");
                else
                    MessageBox.Show("Вы не записаны в эту группу");

                db.closeConnection();

            }
            if (vt.Text == st[3])// zapis` k 4 treneru
            {


                MySqlCommand command = new MySqlCommand("DELETE FROM `t2v` WHERE `id`=@id", db.getConnection());
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = ID;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Вы удалили запись на тренировки");
                else
                    MessageBox.Show("Вы не записаны в эту группу");

                db.closeConnection();

            }

        }


        public Boolean isuserindb()
        {
            DB db = new DB();
            DataTable table1 = new DataTable();
            DataTable table2 = new DataTable();
            DataTable table3 = new DataTable();
            DataTable table4 = new DataTable();
            MySqlDataAdapter adapter1 = new MySqlDataAdapter();
            MySqlDataAdapter adapter2 = new MySqlDataAdapter();
            MySqlDataAdapter adapter3 = new MySqlDataAdapter();
            MySqlDataAdapter adapter4 = new MySqlDataAdapter();

            MySqlCommand command1 = new MySqlCommand("SELECT * FROM `t1m` WHERE `id` = @id", db.getConnection());
            MySqlCommand command2 = new MySqlCommand("SELECT * FROM `t2m` WHERE `id` = @id", db.getConnection());
            MySqlCommand command3 = new MySqlCommand("SELECT * FROM `t1v` WHERE `id` = @id", db.getConnection());
            MySqlCommand command4 = new MySqlCommand("SELECT * FROM `t2v` WHERE `id` = @id", db.getConnection());
            command1.Parameters.Add("@id", MySqlDbType.VarChar).Value =ID;
            command2.Parameters.Add("@id", MySqlDbType.VarChar).Value = ID;
            command3.Parameters.Add("@id", MySqlDbType.VarChar).Value = ID;
            command4.Parameters.Add("@id", MySqlDbType.VarChar).Value = ID;

            adapter1.SelectCommand = command1;
            adapter2.SelectCommand = command2;
            adapter3.SelectCommand = command3;
            adapter4.SelectCommand = command4;
            adapter1.Fill(table1);
            adapter2.Fill(table2);
            adapter3.Fill(table3);
            adapter4.Fill(table4);

            if (table1.Rows.Count > 0)
            {

                MessageBox.Show("Вы уже записаны в одну из групп\nНельзя записаться в другую");
                return true;
            }
            else if (table2.Rows.Count > 0 || table3.Rows.Count > 0 || table4.Rows.Count > 0)
            {
                MessageBox.Show("Вы уже записаны в одну из групп\nНельзя записаться в другую");
                return true;
            }
            else return false;




        }
        public Boolean isnotuserindb()
        {
            DB db = new DB();
            DataTable table1 = new DataTable();
            DataTable table2 = new DataTable();
            DataTable table3 = new DataTable();
            DataTable table4 = new DataTable();
            MySqlDataAdapter adapter1 = new MySqlDataAdapter();
            MySqlDataAdapter adapter2 = new MySqlDataAdapter();
            MySqlDataAdapter adapter3 = new MySqlDataAdapter();
            MySqlDataAdapter adapter4 = new MySqlDataAdapter();

            MySqlCommand command1 = new MySqlCommand("SELECT * FROM `t1m` WHERE `id` = @id", db.getConnection());
            MySqlCommand command2 = new MySqlCommand("SELECT * FROM `t2m` WHERE `id` = @id", db.getConnection());
            MySqlCommand command3 = new MySqlCommand("SELECT * FROM `t1v` WHERE `id` = @id", db.getConnection());
            MySqlCommand command4 = new MySqlCommand("SELECT * FROM `t2v` WHERE `id` = @id", db.getConnection());
            command1.Parameters.Add("@id", MySqlDbType.VarChar).Value = ID;
            command2.Parameters.Add("@id", MySqlDbType.VarChar).Value = ID;
            command3.Parameters.Add("@id", MySqlDbType.VarChar).Value = ID;
            command4.Parameters.Add("@id", MySqlDbType.VarChar).Value = ID;

            adapter1.SelectCommand = command1;
            adapter2.SelectCommand = command2;
            adapter3.SelectCommand = command3;
            adapter4.SelectCommand = command4;
            adapter1.Fill(table1);
            adapter2.Fill(table2);
            adapter3.Fill(table3);
            adapter4.Fill(table4);

            if (table1.Rows.Count == 0)
            {

                MessageBox.Show("Вы еще нигде не записаны");
                return true;
            }
            else if (table2.Rows.Count == 0 || table3.Rows.Count == 0 || table4.Rows.Count == 0)
            {
                MessageBox.Show("Вы еще нигде не записаны");
                return true;
            }
            else return false;




        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fstart fstart = new Fstart(1, ID);
            this.Close();
            fstart.Show();
        }

        private void FVT_Load(object sender, EventArgs e)
        {

        }

        private void bA_Click(object sender, EventArgs e)// knopka admina
        {
            if (vt.Text == "")
            { MessageBox.Show("Вы не выбрали тренера"); return; }

            DB db = new DB();

            //if (isnotuserindb())
            //    return;
            if (vt.Text == st[0])// zapis` k 1 treneru
            {


                MySqlCommand command = new MySqlCommand("DELETE FROM `t1m` WHERE `id`=@id", db.getConnection());
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = tbIDA.Text;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Вы удалили запись человека с ID "+ tbIDA.Text+" на тренировки");
                else
                    MessageBox.Show("Человек с ID "+ tbIDA.Text+" не записан в эту группу");

                db.closeConnection();

            }
            if (vt.Text == st[1])// zapis` k 2 treneru
            {


                MySqlCommand command = new MySqlCommand("DELETE FROM `t2m` WHERE `id`=@id", db.getConnection());
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = tbIDA.Text;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Вы удалили запись человека с ID "+ tbIDA.Text+" на тренировки");
                else
                    MessageBox.Show("Человек с ID "+ tbIDA.Text+" не записан в эту группу");

                db.closeConnection();

            }
            if (vt.Text == st[2])// zapis` k 3 treneru
            {


                MySqlCommand command = new MySqlCommand("DELETE FROM `t1v` WHERE `id`=@id", db.getConnection());
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = tbIDA.Text;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Вы удалили запись человека с ID "+ tbIDA.Text+" на тренировки");
                else
                    MessageBox.Show("Человек с ID "+ tbIDA.Text+" не записан в эту группу");

                db.closeConnection();

            }
            if (vt.Text == st[3])// zapis` k 4 treneru
            {


                MySqlCommand command = new MySqlCommand("DELETE FROM `t2v` WHERE `id`=@id", db.getConnection());
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = tbIDA.Text;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Вы удалили запись человека с ID "+ tbIDA.Text+" на тренировки");
                else
                    MessageBox.Show("Человек с ID "+ tbIDA.Text + " не записан в эту группу" );

                db.closeConnection();

            }
        }
    }
}
