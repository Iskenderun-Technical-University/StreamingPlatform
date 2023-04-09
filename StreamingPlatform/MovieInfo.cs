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
    public partial class MovieInfo : UserControl
    {
        public MovieInfo()
        {
            InitializeComponent();
        }
        bool hover = false;
        int FormWidth = 289, FormHeight = 236, PictureWidth = 283, PictureHeight = 150, LabelWidth = 283, LabelHeight = 80;

        private void MoviePicture_MouseMove(object sender, MouseEventArgs e)
        {
            this.Size = new Size(FormWidth + 10, FormHeight + 10);
            MoviePicture.Size = new Size(PictureWidth + 10, PictureHeight + 10);
            MovieName.Size = new Size(LabelWidth + 10, LabelHeight + 10);
        }

        private void hovereffect() {
            if (!hover)
            {
                this.Size = new Size(FormWidth + 10, FormHeight + 10);
                MoviePicture.Size = new Size(PictureWidth + 10, PictureHeight + 10);
                MovieName.Size = new Size(LabelWidth + 10, LabelHeight + 10);
                hover = true;
            }
            else
            {
                this.Size = new Size(FormWidth, FormHeight);
                MoviePicture.Size = new Size(PictureWidth, PictureHeight);
                MovieName.Size = new Size(LabelWidth, LabelHeight);
                hover = false;
            }
        }

        private void MoviePicture_MouseLeave(object sender, EventArgs e)
        {
            this.Size = new Size(FormWidth, FormHeight);
            MoviePicture.Size = new Size(PictureWidth, PictureHeight);
            MovieName.Size = new Size(LabelWidth, LabelHeight);
        }

        private void MoviePicture_MouseHover(object sender, EventArgs e)
        {
            /*this.Size = new Size(FormWidth + 10, FormHeight + 10);
            MoviePicture.Size = new Size(PictureWidth + 10, PictureHeight + 10);
            MovieName.Size = new Size(LabelWidth + 10, LabelHeight + 10);*/
        }

    }
}
