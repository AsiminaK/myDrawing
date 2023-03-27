using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myDRAWING
{
    public partial class Form3 : Form
    {
        String connectionString = "Data Source=DB2.db;Version=3;";
        SQLiteConnection conn;

        int mycount;

        public Form3(String user, int count)
        {
            InitializeComponent();

            mycount = count;
            label1.Text = user;
            conn = new SQLiteConnection(connectionString);

            conn.Open();
            while (count >= 0)
            {
                String selectQuery = "Select id,Shapename,Timestamp from SHAPES where Username='" + user +"' and Shapenumber='" + count + "'";
                SQLiteCommand command = new SQLiteCommand(selectQuery, conn);
                SQLiteDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    richTextBox1.Text += reader.GetString(1) + Environment.NewLine;
                    richTextBox2.Text += reader.GetString(2) + Environment.NewLine;
                }
                count--;
            }
            conn.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 myForm = new Form2(label1.Text, mycount );
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
