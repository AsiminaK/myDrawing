using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Data.SQLite;
using System.Drawing.Imaging;
using System.IO;

namespace myDRAWING
{
    public partial class Form2 : Form
    {
        String connectionString = "Data Source=DB2.db;Version=3;";
        SQLiteConnection conn;

        Graphics g;
        Pen p;
        SolidBrush sb = new SolidBrush(Color.Black);
        int fsX1, fsY1, x1, y1;
        bool freestyle;
        bool md;

        Color smth = Color.Black;

        public Point MouseDownLocation;

        bool straightline;
        bool cyrcle;
        bool ellipse;
        bool square;

        string shapetime;
        string shapename;
        string username;
        int count;

        bool saved = false;

        public Form2(String s, int c)
        {
            InitializeComponent();

            username = s;
            count = c;
            label9.Text = username;

            conn = new SQLiteConnection(connectionString);
        }

        private void backToMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saved == false)
            {
                DialogResult dialogResult = MessageBox.Show("If you leave without saving your image will be lost!", "ARE YOU SURE YOU WANT TO LEAVE?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Form1 myForm = new Form1();
                    this.Hide();
                    myForm.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                Form1 myForm = new Form1();
                this.Hide();
                myForm.ShowDialog();
                this.Close();
            }


        }

        private void cATCHTHEPENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            g = panel2.CreateGraphics();
            p = new Pen(smth, hScrollBar1.Value);
            freestyle = true;
        }

        private void straightLineToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            straightline = true;
            freestyle = false;
        }

        private void ellipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ellipse = true;
            freestyle = false;
            shapename = "Ellipse";
            shapetime = DateTime.Now.ToString();
        }

        private void cyrcleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cyrcle = true;
            freestyle = false;
            shapename = "Cyrcle";
            shapetime = DateTime.Now.ToString();
        }

        private void squareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            square = true;
            freestyle = false;
            shapename = "Square";
            shapetime = DateTime.Now.ToString();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            p.Width = hScrollBar1.Value;
        }

        private void eRASERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            g = panel2.CreateGraphics();
            p = new Pen(panel2.BackColor, hScrollBar2.Value);
            freestyle = true;
        }


        private void dELETEEVERYTHINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panel2.BackColor != Color.White)
            {
                panel2.BackColor = Color.White;
            }
            else
            {
                panel2.BackColor = Color.WhiteSmoke;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            g.DrawLine(p, 70, 564, 70, 404);
            delay();
            g.DrawLine(p, 70, 404, 250, 404);
            delay();
            g.DrawLine(p, 250, 404, 250, 564);
            delay();
            g.DrawLine(p, 250, 564, 70, 564);
            delay();
            g.DrawLine(p, 70, 404, 157, 300);
            delay();
            g.DrawLine(p, 157, 300, 250, 404);
            delay();
            g.DrawLine(p, 92, 465, 92, 434);
            delay();
            g.DrawLine(p, 92, 434, 134, 434);
            delay();
            g.DrawLine(p, 134, 434, 134, 465);
            delay();
            g.DrawLine(p, 134, 465, 92, 465);
            delay();
            g.DrawLine(p, 181, 465, 181, 434);
            delay();
            g.DrawLine(p, 181, 434, 225, 434);
            delay();
            g.DrawLine(p, 225, 434, 225, 465);
            delay();
            g.DrawLine(p, 225, 465, 181, 465);
            delay();
            g.DrawLine(p, 135, 564, 135, 518);
            delay();
            g.DrawLine(p, 135, 518, 179, 518);
            delay();
            g.DrawLine(p, 179, 518, 179, 564);
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            g.DrawEllipse(p, 220, 50, 150, 150);
            delay();
            g.DrawLine(p, 395, 149, 516, 168 );
            delay();
            g.DrawLine(p,391, 106, 469, 98);
            delay();
            g.DrawLine(p, 386, 76, 487, 26);
            delay();
            g.DrawLine(p,350, 52, 395, 10);
            delay();
            g.DrawLine(p, 329, 47, 348, 31);
            delay();
            g.DrawLine(p, 309, 38, 327, 2);
            delay();
            g.DrawLine(p, 281, 37, 276, 0);
            delay();
            g.DrawLine(p, 230, 16, 250, 45);
            delay();
            g.DrawLine(p, 162, 31, 218, 68);
            delay();
            g.DrawLine(p, 168, 90, 203, 93);
            delay();
            g.DrawLine(p, 117, 126, 207, 130);
            delay();
            g.DrawLine(p, 186, 194, 229, 179);
            delay();
            g.DrawLine(p, 187, 265, 256, 198);
            delay();
            g.DrawLine(p, 284, 218, 289, 259);
            delay();
            g.DrawLine(p, 346, 205, 361, 291);
            delay();
            g.DrawLine(p, 370, 176, 415, 209);

        }

        private void button3_Click(object sender, EventArgs e)
        {

            SolidBrush drawBrush = new SolidBrush(smth);

            using (Font font1 = new Font("Times New Roman", 80, FontStyle.Bold, GraphicsUnit.Pixel))
            {
                PointF pointF1 = new PointF(410, 225);
                g.DrawString("U", font1, drawBrush, pointF1);
                delay();
                PointF pointF2 = new PointF(510, 225);
                g.DrawString("N", font1, drawBrush, pointF2);
                delay();
                PointF pointF3 = new PointF(610, 225);
                g.DrawString("I", font1, drawBrush, pointF3);
                delay();
                PointF pointF4 = new PointF(710, 225);
                g.DrawString("P", font1, drawBrush, pointF4);
                delay();
                PointF pointF5 = new PointF(810, 225);
                g.DrawString("I", font1, drawBrush, pointF5);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //head
            g.DrawEllipse(p, 620, 355, 75, 75);
            delay();
            //body
            g.DrawLine(p, 655, 431, 655, 542);
            delay();
            //legs
            g.DrawLine(p, 624, 590, 655, 542);
            delay();
            g.DrawLine(p, 655, 542, 706, 584);
            delay();
            //hands
            g.DrawLine(p, 591, 436, 655, 464);
            delay();
            g.DrawLine(p, 655, 464, 728, 442);
            delay();
            //eyes
            g.DrawEllipse(p, 633, 388, 12, 12);
            delay();
            g.DrawEllipse(p, 660, 388, 12, 12);
            delay();
            //mouth
            g.DrawLine(p, 639, 406, 674, 406);
            delay();
            g.DrawLine(p, 674, 406, 674, 410);
            delay();
            g.DrawLine(p, 639, 410, 674, 410);
            delay();
            g.DrawLine(p, 639, 410, 639, 406);

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            fsX1 = e.X;
            fsY1 = e.Y;

            md = true;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            //label9.Text = "Συντεταγμένες: " + e.X.ToString() + ", " + e.Y.ToString();
            if (freestyle && md)
            {

                sb.Color = p.Color;
                g.DrawLine(p, fsX1, fsY1, e.X, e.Y);
                g.FillEllipse(sb, fsX1 - p.Width / 2, fsY1 - p.Width / 2, p.Width, p.Width);
                fsX1 = e.X;
                fsY1 = e.Y;

            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {

            x1 = e.X - fsX1;
            y1 = e.Y - fsY1;
            g = panel2.CreateGraphics();


            if (ellipse && md)
            {
                g.DrawEllipse(p, fsX1, fsY1, x1, y1);

                shapename = "Ellipse";
                shapetime = DateTime.Now.ToString();

                save(conn, shapename, shapetime, username, count);
                count++;

                ellipse = false;
            }
            else if (square && md)
            {
                g.DrawRectangle(p, fsX1, fsY1, x1, y1);

                shapename = "Square";
                shapetime = DateTime.Now.ToString();

                save(conn, shapename, shapetime, username, count);
                count++;

                square = false;
            }
            else if (straightline && md)
            {
                g.DrawLine(p, e.X, e.Y, fsX1, fsY1);

                shapename = "Straight line";
                shapetime = DateTime.Now.ToString();

                save(conn, shapename, shapetime, username, count);
                count++;

                straightline = false;
            }
            else if (cyrcle && md)
            {
                g.DrawEllipse(p, fsX1, fsY1, x1, x1);

                shapename = "Cyrcle";
                shapetime = DateTime.Now.ToString();

                save(conn, shapename, shapetime, username, count);
                count++;

                cyrcle = false;
            }

            md = false;
        }

        private static void save(SQLiteConnection conn, string shapename, string shapetime, string user, int shapenumber)
        {
            conn.Open();
            String insertQuery = "Insert into SHAPES(Shapename, timestamp, Username, Shapenumber) values('" + shapename + "','" + shapetime + "','" + user + "','" + shapenumber + "')";
            SQLiteCommand cmd = new SQLiteCommand(insertQuery, conn);
            int count = cmd.ExecuteNonQuery();
            conn.Close();
        }

        private static void delay()
        {
            int i = 0;
            System.Timers.Timer _delayTimer = new System.Timers.Timer();
            _delayTimer.Interval = 650;
            _delayTimer.AutoReset = false; //so that it only calls the method once
            _delayTimer.Elapsed += (s, args) => i = 1;
            _delayTimer.Start();
            while (i == 0) { };
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //head
            g.DrawEllipse(p, 1011, 245, 252, 252);
            delay();
            //eyes
            g.DrawEllipse(p, 1059, 311, 55, 55);
            delay();
            g.DrawEllipse(p, 1150, 311, 55, 55);
            delay();
            //nose
            g.DrawEllipse(p, 1117, 380, 20, 20);
            delay();
            //mustache
            g.DrawLine(p, 1129, 374, 1175, 353);
            delay();
            g.DrawLine(p, 1133, 377, 1176, 377);
            delay();
            g.DrawLine(p, 1131, 383, 1161, 391);
            delay();
            g.DrawLine(p, 1116, 375, 1059, 375);
            delay();
            g.DrawLine(p, 1116, 380, 1095, 387);
            delay();
            g.DrawLine(p, 1118, 384, 1097, 402);
            delay();
            //mouth
            g.DrawLine(p, 1096, 432, 1183, 432);
            delay();
            //ears
            g.DrawLine(p, 1036, 265, 1029, 173);
            delay();
            g.DrawLine(p, 1029, 173, 1094, 222);
            delay();
            g.DrawLine(p, 1167, 218, 1196, 152);
            delay();
            g.DrawLine(p, 1196, 152, 1217, 243);
        }

        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = e.Bounds;
            if (e.Index >= 0)
            {
                string n = ((ComboBox)sender).Items[e.Index].ToString();
                Font f = new Font("Arial", 9, FontStyle.Regular);
                Color c = Color.FromName(n);
                Brush b = new SolidBrush(c);
                g.DrawString(n, f, Brushes.Black, rect.X, rect.Top);
                g.FillRectangle(b, rect.X + 110, rect.Y + 5, rect.Width - 10, rect.Height - 10);

                p.Color = c;
                smth = p.Color;

            }
        }

        private void sAVEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveControlImage(panel2);
            saved = true;
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saved == false)
            {
                DialogResult dialogResult = MessageBox.Show("If you leave without saving your image will be lost!", "ARE YOU SURE YOU WANT TO LEAVE?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 myForm = new Form3(username, count);
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        public void comboBox3_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = e.Bounds;
    
            if (e.Index >= 0)
            {
                string n = ((ComboBox)sender).Items[e.Index].ToString();
                Font f = new Font("Arial", 9, FontStyle.Regular);
                Color c1 = Color.FromName(n.ToString());
                Brush b = new SolidBrush(c1);
                g.DrawString(n, f, Brushes.Black, rect.X, rect.Top);
                g.FillRectangle(b, rect.X + 110, rect.Y + 5, rect.Width - 10, rect.Height - 10);

                if (c1 != Color.Transparent)
                {
                    panel2.BackColor = c1;
                }
                

            }
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            g = panel2.CreateGraphics();
            p = new Pen(Color.Black, hScrollBar1.Value);

            ArrayList ColorList = new ArrayList();
            Type colorType = typeof(System.Drawing.Color);
            PropertyInfo[] propInfoList = colorType.GetProperties(BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public);

            foreach (PropertyInfo c in propInfoList)
            {
                this.comboBox1.Items.Add(c.Name);
                this.comboBox3.Items.Add(c.Name);
            }


        }

        private void SaveControlImage(Panel panel)
        {
            Bitmap bmp = new Bitmap(panel.Width, panel.Height - 50, PixelFormat.Format32bppArgb);
            Graphics Grap = Graphics.FromImage(bmp);

            Grap.CopyFromScreen(PointToScreen(panel.Location).X, PointToScreen(panel.Location).Y, 0, 0, panel.Size, CopyPixelOperation.SourceCopy);
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "JPEG|*.jpg";
            DialogResult tl = save.ShowDialog();
            if (tl == DialogResult.OK)
            {
                bmp.Save(save.FileName);
                MessageBox.Show("Save has completed succesfully!");
            }

        }

    }
}
