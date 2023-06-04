using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StreamingPlatform
{
    public partial class MovieInfo : UserControl
    {
        public MovieInfo()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"");

        int FormWidth = 280, FormHeight = 235,PictureHeight=150;

        private void MoviePicture_Click(object sender, EventArgs e)
        {
            this.Size = new Size(FormWidth-4, FormHeight-4);
            MoviePicture.Size = new Size(276, PictureHeight -4);
            timer1.Start();
        }

        private void MovieInfo_MouseEnter(object sender, EventArgs e)
        {
            this.Size = new Size(FormWidth + 10, FormHeight + 10);
            MoviePicture.Size = new Size(290, PictureHeight + 10);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Size = new Size(FormWidth + 10, FormHeight + 10);
            MoviePicture.Size = new Size(290, PictureHeight + 10);
            timer1.Stop();
            MainMenu.movieDetails.ShowDialog();
        }

        private void MoviePicture_MouseLeave(object sender, EventArgs e)
        {
            
            this.Size = new Size(FormWidth, FormHeight);
            MoviePicture.Size = new Size(280, PictureHeight);

        }

    }
}
