using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamingPlatform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool openstate = false;
        private Rectangle originalFormSize;
        private Rectangle panel2OriginalRectangle;

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            MoviesList.Hide();
            if (openstate == false)
            {
                openstate = true;
                for (int i = 60; i < 280; i+=6)
                {
                    SideMenu.Size = new Size(i, 600);
                }
            }
            else
            {
                openstate = false;
                for (int i = 280; i > 60; i-=6)
                {
                    SideMenu.Size = new Size(i, 600);
                }
            }
            panel2.Show();
            MoviesList.Show();
        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
            panel2.BackgroundImage = imageList1.Images[1];
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            panel2.BackgroundImage = imageList1.Images[0];

        }

        private void resizeControl(Rectangle r, Control c) {
            float xRatio = (float)(this.Width) / (float)(originalFormSize.Width);
            float yRatio = (float)(this.Height) / (float)(originalFormSize.Height);

            int newX = (int)(r.Width * xRatio);
            int newY = (int)(r.Height * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size= new Size(newWidth, newHeight);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            panel2OriginalRectangle = new Rectangle(panel2.Location.X, panel2.Location.Y, panel2.Size.Width, panel2.Size.Height);

        }

        private void Form1_Resize(object sender, EventArgs e)
        {

          //  resizeControl(panel2OriginalRectangle, panel2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MovieInfo movie = new MovieInfo();
            movie.MovieName.Text = "Venom: Let There Be Carnage";
            movie.Parent = MoviesList;
        }
    }
}
