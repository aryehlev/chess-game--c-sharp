using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameBoard
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.castle.MouseDown += key_MouseDown;
            this.castle.MouseMove += key_MouseMove;
            this.castle.MouseUp += key_MouseUp;
            putInFirstLocation(castle);
            this.m_LastLocation = this.castle.Location;
           
        }

        private void putInFirstLocation(PictureBox castle)
        {
            castle.Location = new Point(roundToNearest100(12) + XPointDeviation, roundToNearest100(12)+ YPointDeviation);
            changeColor(castle);
        }

        private void key_MouseUp(object i_Sender, MouseEventArgs i_E)
        {

            PictureBox pb = (PictureBox)i_Sender;
            pb.BackColor = pb.Parent.BackColor;

            putInNextLocation(pb);
           
            changeColor(pb);
        }

        private void changeColor(PictureBox i_PictureBox)
        {
            if ((roundToNearest100(i_PictureBox.Location.X) / 100) % 2 == (roundToNearest100(i_PictureBox.Location.Y) / 100) % 2)
            {
                i_PictureBox.BackColor = Color.FromArgb(192, 192, 0);
            }
            else
            {
                i_PictureBox.BackColor = i_PictureBox.Parent.BackColor;
            }
        }

        private readonly object m_LockForLastLocation = new object();
        private Point m_StartPointFOrMouseMove;
        private Point m_LastLocation;
        private const int XPointDeviation = 20;
        private const int YPointDeviation = 12;

        private int roundToNearest100(int i_Num)
        {
            if(i_Num < 100)
            {
                if(i_Num >= 50)
                {
                    return 100;
                }

                if(i_Num < 50 && i_Num >= 0)
                {
                    return 0;
                }
            }

            if(i_Num >= 800 || i_Num < 0)
            {
                return -1;
            }
            string strToConvert = i_Num.ToString();
            if(strToConvert[1] >= '5' && strToConvert[0] <'7')
            {
                strToConvert = $"{char.GetNumericValue(strToConvert[0]) + 1}00";
            }
            else
            {
                strToConvert = $"{strToConvert[0]}00";
            }

            return int.Parse(strToConvert);

        }

        private void nextMove(PictureBox piece)
        {
            
        }

        private void putInNextLocation(PictureBox pb)
        {
            Point p = pb.Location;
            int X = roundToNearest100(p.X);
            int Y = roundToNearest100(p.Y);
            bool isOkPlace = false;

            switch (pb.Name)
            {
                case "castle":
                    isOkPlace = inLine(pb);
                    break;
            }

            lock(m_LockForLastLocation)
            {
                if(Y != -1 && X != -1 && isOkPlace)
                {
                    pb.Location = new Point(X + XPointDeviation, Y + YPointDeviation);
                    m_LastLocation = pb.Location;

                }
                else
                {
                    pb.Location = m_LastLocation;
                }
            }
        }

            
        private bool inLine(PictureBox pb)
        {
            return Math.Abs(pb.Location.X - m_LastLocation.X)  <= 20 ^ Math.Abs(pb.Location.Y  - m_LastLocation.Y) <= 20;
        }

        private void key_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                m_StartPointFOrMouseMove = new Point(e.X, e.Y);
            }
        }

        private void key_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                PictureBox pb = (PictureBox)sender;
                Point pt = pb.Location;
                pt.Offset(e.X - m_StartPointFOrMouseMove.X, e.Y - m_StartPointFOrMouseMove.Y);
                pb.Location = pt;
               

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

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void transparentControl2_Click(object sender, EventArgs e)
        {

        }
    }
}
