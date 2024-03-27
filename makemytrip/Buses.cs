using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace makemytrip
{
    public partial class Buses : UserControl
    {
        public Buses()
        {
            InitializeComponent();
        }
        public string Busname
        {
            get => Busname;
            set
            {
                label1.Text = value;
            }
        }
        public  void Setdata()
        {

        }
        [DllImport("user32.dll")]
        private static extern bool PostMessage(
           IntPtr hWnd, // handle to destination window
           Int32 msg, // message
           Int32 wParam, // first message parameter
           Int32 lParam // second message parameter
           );
        const Int32 WM_LBUTTONDOWN = 0x0201;

        private void SelectClick(object sender, EventArgs e)
        {
            if(button3.Text== "Select seats")
            {
                button3.Text = "Hide seats";
                button3.BackColor = Color.White;
                button3.ForeColor = SystemColors.Highlight;
                //panel1.Height = 630;
               // Height = 1100;
                panel1.Visible = true;
                panel8.BackColor = SystemColors.GradientInactiveCaption;
                //Int32 x = comboBox1.Width - 10;
                //Int32 y = comboBox1.Height / 2;
                //Int32 lParam = x + y * 0x00010000;
                //PostMessage(comboBox1.Handle, WM_LBUTTONDOWN, 1, lParam);
       
            }
            else
            {
                button3.Text = "Select seats";
                button3.BackColor = SystemColors.Highlight;
                button3.ForeColor = Color.White;
                // panel1.Height = 0;
                panel1.Visible = false;
                Height = 280;
                panel8.BackColor = Color.White;
            }
        }

    }
}
