using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StreamingPlatform
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        bool openstate = true;
        private Rectangle originalFormSize;
        private Rectangle panel2OriginalRectangle;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kg462\Desktop\StreamingPlatform\StreamingPlatform\Database.mdf;Integrated Security=True");

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            HighightPanel.Hide();
            MoviesList.Hide();
            if (openstate == false)
            {
                openstate = true;
                SideMenu.Size = new Size(295, 565);
                MoviesList.Padding = new Padding(37, 5, 0, 0);
            }
            else
            {
                openstate = false;
                SideMenu.Size = new Size(70, 565);
                MoviesList.Padding = new Padding(0, 0, 0, 0);
            }
            HighightPanel.Show();
            MoviesList.Show();
        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
            HighightPanel.BackgroundImage = imageList1.Images[1];
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            HighightPanel.BackgroundImage = imageList1.Images[0];

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
            panel2OriginalRectangle = new Rectangle(HighightPanel.Location.X, HighightPanel.Location.Y, HighightPanel.Size.Width, HighightPanel.Size.Height);

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

        private void guna2ImageButton4_MouseEnter(object sender, EventArgs e)
        {
            RightNav.ShadowDecoration.Enabled = true;
        }

        private void guna2ImageButton4_MouseLeave(object sender, EventArgs e)
        {
            RightNav.ShadowDecoration.Enabled = false;
        }

        private void guna2ImageButton3_MouseEnter(object sender, EventArgs e)
        {
            LeftNav.ShadowDecoration.Enabled = true;
        }

        private void guna2ImageButton3_MouseLeave(object sender, EventArgs e)
        {
            LeftNav.ShadowDecoration.Enabled = false;
        }

        private void UserSettings_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Show the context menu at the location of the mouse click
                UserMenu.Show(UserSettings, e.Location);
            }
        }

        private void enterAdminPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.ShowDialog();
        }
    }
}
