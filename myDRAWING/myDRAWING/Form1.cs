using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myDRAWING
{
    public partial class Form1 : Form
    {
        String connectionString = "Data Source=DB2.db;Version=3;";
        SQLiteConnection conn;

        int count = 0;
        string username;

        public Form1()
        {
            InitializeComponent();

            conn = new SQLiteConnection(connectionString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            String selectQuery = "Select id,Shapenumber from SHAPES where Username='" + textBox1.Text + "'";
            SQLiteCommand command = new SQLiteCommand(selectQuery, conn);
            SQLiteDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                DialogResult dialogResult = MessageBox.Show("This username already exists!", "DO YOU WANT TO CHANGE THIS USERNAME?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    textBox1.Clear();
                    username = "";
                }
                else
                {
                    username = textBox1.Text + "A";
                }
            }
            else
            {
                username = textBox1.Text;
            }

            conn.Close();

            if (username != "")
            {
                Form2 myForm = new Form2(username, count);
                this.Hide();
                myForm.ShowDialog();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //conn = new SQLiteConnection(connectionString);
        }
    }
}
