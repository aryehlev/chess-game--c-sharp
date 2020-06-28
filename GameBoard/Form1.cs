using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameBoard
{
    public partial class Form1 : Form
    {
        private bool m_IsFirstTimeUp;

        public Form1()
        {
            InitializeComponent();
        }

        private Point MouseDownLocation;


        private void transparentControl1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void transparentControl1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                transparentControl1.Left = e.X + transparentControl1.Left - MouseDownLocation.X;
                transparentControl1.Top = e.Y + transparentControl1.Top - MouseDownLocation.Y;
            }
        }

        public void Form1_Load(object sender, EventArgs e)
        {
           
                Bitmap bm = new Bitmap(800, 800);
                using(Graphics g = Graphics.FromImage(bm))
                using(SolidBrush lightBrush = new SolidBrush(Color.Wheat))
                using(SolidBrush darkBrush = new SolidBrush(Color.Peru))
                {
                    for(int i = 0; i < 8; i++)
                    {
                        for(int j = 0; j < 8; j++)
                        {
                            if((j % 2 == 0 && i % 2 == 0) || (j % 2 != 0 && i % 2 != 0))
                                g.FillRectangle(darkBrush, i * 100, j * 100, 100, 100);
                            else if((j % 2 == 0 && i % 2 != 0) || (j % 2 != 0 && i % 2 == 0))
                                g.FillRectangle(lightBrush, i * 100, j * 100, 100, 100);
                        }
                    }

                   
                    BackgroundImage = bm;
                }
        }
    }
}
