using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace makemytrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll")]
        public static extern bool PostMessage(
            IntPtr hWnd, // handle to destination window
            Int32 msg, // message
            Int32 wParam, // first message parameter
            Int32 lParam // second message parameter
            );

        const Int32 WM_LBUTTONDOWN = 0x0201;
        private bool isfalse,isTime,isTravel,isDrop,isDtime;
        private Buses bus = new Buses()
        {
        };

        private  void Locations(ref bool b,ComboBox comboBox,Panel p,PictureBox pict)
        {
            if (!b)
            {
                pict.BackgroundImage = Properties.Resources.up1;

                b = true;

                Int32 x = comboBox.Width - 10;

                Int32 y = comboBox.Height / 2;

                Int32 lParam = x + y * 0x00010000;

                PostMessage(comboBox.Handle, WM_LBUTTONDOWN, 1, lParam);
                p.Height = comboBox.Height * comboBox.Items.Count;
            }
            else
            {
                pict.BackgroundImage = Properties.Resources.da;
                p.Height = 0;
                b = false;
            }
        }

        private void Time(ref bool b,Panel p,PictureBox picture)
        {
            if (!b)
            {
                picture.BackgroundImage = Properties.Resources.up1;
                p.Height = 250;
                b = true;
            }
            else
            {
                picture.BackgroundImage = Properties.Resources.da;
                p.Height = 0;
                b = false;
            }
        }

        private void DropClick(object sender, EventArgs e)
        {
            Locations(ref isfalse, comboBox1, panel7,pictureBox5);    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox5.BackgroundImage = Properties.Resources.da;
            comboBox1.Items.Add("a");
            comboBox1.Items.Add("b");
            comboBox2.Items.Add("a");
            comboBox2.Items.Add("b");
            comboBox3.Items.Add("Chengalpattu");
            comboBox3.Items.Add("SRM universitry");
            panel18.Controls.Add(bus);
            bus.Dock = DockStyle.Top;
            bus.Setdata();
            panel18.Controls.Add(bus);
            bus.Dock = DockStyle.Top;
            //buses1.Dock = DockStyle.Top;
        }


        private void TPictureBoxClick(object sender, EventArgs e)
        {
            Locations(ref isTravel, comboBox2, panel11, pictureBox11);
        }
        private void DropPointClick(object sender, EventArgs e)
        {
            Locations(ref isDrop, comboBox3, panel13, pictureBox12);
        }
        private void DtimeClick(object sender, EventArgs e)
        {
            Time(ref isTime, panel9, pictureBox6);
        }
        private void DTime(object sender, EventArgs e)
        {
            Time(ref isDtime, panel15, pictureBox13);
        }
    }
}
