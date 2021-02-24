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

namespace laba_1 
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string query = "select obhaga.name as Номер_Общаги, obhaga.Phone as Телефон, graphic.name as График_работы From obhaga join graphic on obhaga.id_graphic = graphic.Id_graphic;";
            MySqlConnection conn = DBUtils.GetMySqlConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            cmDB.CommandTimeout = 60;
            MySqlDataReader rd;
            try
            {
                conn.Open();
                rd = cmDB.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        string[] row = { rd.GetString(0), rd.GetString(1), rd.GetString(2), };
                        var listViemItem = new ListViewItem(row);
                        listView1.Items.Add(listViemItem);
                    }
                }

              
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                MessageBox.Show("Информация об общежитиях");
            }
            catch (Exception ex)
            {
                  conn.Close();
                MessageBox.Show("Ошибка подключения к БД");
                MessageBox.Show(ex.Message);

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
