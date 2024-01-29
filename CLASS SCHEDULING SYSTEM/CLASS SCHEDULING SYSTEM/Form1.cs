using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace CLASS_SCHEDULING_SYSTEM
{
    public partial class Form1 : Form
    {                         
        public Form1()        
        {
            InitializeComponent();
            SetRoundedPanel(panel1, 20);
        }
        private void SetRoundedPanel(Panel panel, int radius)
        {
            panel.Paint += (sender, e) =>
            {
                using (GraphicsPath path = RoundedRectangle(panel.ClientRectangle, radius))
                using (Region region = new Region(path))
                {
                    panel.Region = region;
                    using (Pen pen = new Pen(Color.LightGray, 1))
                    {
                        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                        e.Graphics.DrawPath(pen, path);
                    }
                }
            };
        }

        private GraphicsPath RoundedRectangle(Rectangle bounds, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(bounds.X, bounds.Y, radius * 2, radius * 2, 180, 90);
            path.AddArc(bounds.Right - radius * 2, bounds.Y, radius * 2, radius * 2, 270, 90);
            path.AddArc(bounds.Right - radius * 2, bounds.Bottom - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - radius * 2, radius * 2, radius * 2, 90, 90);

            path.CloseFigure();
            return path;
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f8 = new Form8();
            f8.Show();

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
