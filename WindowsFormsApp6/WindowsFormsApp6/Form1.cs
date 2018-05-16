using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach(Control a in this.Controls) //Story ve Taskların konumu değişince rengi değiştirme.
            {
                if (a is Panel && a.Width == 137)
                {
                    if (a.Location.X > 280 && a.Location.X < 530 && a.Location.Y>190)
                        a.BackColor = Color.Tomato;
                    else if(a.Location.X > 529 && a.Location.X < 830 && a.Location.Y > 190)
                        a.BackColor = Color.Gold;
                    else if (a.Location.X > 829 && a.Location.X < 1200 && a.Location.Y > 190)
                        a.BackColor = Color.SeaGreen;
                    else
                        a.BackColor = Color.DarkGray;
                }
                if (a is Panel && a.Width == 137)
                {
                    if (a.Location.X > 960 && a.Location.Y < 80)
                        this.Controls.Remove(a);
                   
                }
                if (a is Panel && a.Width == 230)
                {
                    if (a.Location.X > 870 && a.Location.Y < 80)
                        this.Controls.Remove(a);

                }
                if (a is Panel && a.Width == 230)
                {
                    if ( a.Location.X < 85 && a.Location.Y > 190)
                        a.BackColor = Color.SkyBlue;
                    else
                        a.BackColor = Color.DarkGray;
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Panel pnl = new Panel();
            pnl.Location = new Point(532, 40);
            pnl.Width = 137;
            pnl.Height = 110;
            pnl.BackColor = Color.DarkGray;
            ControlExtension.Draggable(pnl, true);
            Label lbl1 = new Label();
            lbl1.Text = "Story No:";
            lbl1.Location = new Point(3, 5);
            lbl1.Width = 55;
            lbl1.Height = 13;
            Label lbl2 = new Label();
            lbl2.Text = "End Date:";
            lbl2.Location = new Point(3, 26);
            NumericUpDown nud1 = new NumericUpDown();
           nud1.Location = new Point(55, 3);
            nud1.Width = 30;
            nud1.Height = 20;
            DateTimePicker dtp = new DateTimePicker();
            dtp.Format = DateTimePickerFormat.Short;
            dtp.Location = new Point(55, 24);
            dtp.Width = 80;
            dtp.Height = 20;
            TextBox txt1 = new TextBox();
            txt1.Width = 131;
            txt1.Height = 20;
            txt1.Text = "Employee";
            txt1.Location = new Point(3, 46);
            TextBox txt2 = new TextBox();
            txt2.Width = 131;
            txt2.Height = 39;
            txt2.Text = "Task";
            txt2.Location = new Point(3, 68);
            txt2.Multiline = true;
            pnl.Controls.Add(txt2);
            pnl.Controls.Add(txt1);
            pnl.Controls.Add(dtp);
            pnl.Controls.Add(nud1);
            pnl.Controls.Add(lbl1);
            pnl.Controls.Add(lbl2);
            this.Controls.Add(pnl);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Panel pnl1 = new Panel();
            pnl1.Location = new Point(485, 20);
            pnl1.Width = 230;
            pnl1.Height = 140;
            pnl1.BackColor = Color.DarkGray;
            ControlExtension.Draggable(pnl1, true);
            Label lbl1 = new Label();
            lbl1.Text = "Story No:";
            lbl1.Location = new Point(3, 5);
            lbl1.Width = 55;
            lbl1.Height = 13;
            
            NumericUpDown nud1 = new NumericUpDown();
            nud1.Location = new Point(61, 3);
            nud1.Width = 30;
            nud1.Height = 20;
            TextBox txt2 = new TextBox();
            txt2.Width = 224;
            txt2.Height = 90;
            txt2.Text = "Description";
            txt2.Location = new Point(3, 45);
            txt2.Multiline = true;
            Label lbl2 = new Label();
            lbl2.Text = "Date:";
            lbl2.Location = new Point(3, 26);
            lbl2.Width = 55;
            lbl2.Height = 13;
            DateTimePicker dtp = new DateTimePicker();
            dtp.Format = DateTimePickerFormat.Short;
            dtp.Location = new Point(61, 24);
            dtp.Width = 80;
            dtp.Height = 20;
            TextBox txt1 = new TextBox();
            txt1.Width = 80;
            txt1.Height = 20;
            txt1.Text = "Tag";
            txt1.Location = new Point(100,3);
            pnl1.Controls.Add(txt2);
            pnl1.Controls.Add(nud1);
            pnl1.Controls.Add(lbl1);
            pnl1.Controls.Add(lbl2);
            pnl1.Controls.Add(txt1);
            pnl1.Controls.Add(dtp);
            this.Controls.Add(pnl1);
        }
    }
}
