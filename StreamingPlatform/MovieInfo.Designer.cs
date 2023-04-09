namespace StreamingPlatform
{
    partial class MovieInfo
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieInfo));
            this.MoviePicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.MovieName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // MoviePicture
            // 
            this.MoviePicture.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.MoviePicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MoviePicture.Image = ((System.Drawing.Image)(resources.GetObject("MoviePicture.Image")));
            this.MoviePicture.ImageRotate = 0F;
            this.MoviePicture.Location = new System.Drawing.Point(3, 3);
            this.MoviePicture.Name = "MoviePicture";
            this.MoviePicture.Size = new System.Drawing.Size(283, 150);
            this.MoviePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MoviePicture.TabIndex = 0;
            this.MoviePicture.TabStop = false;
            this.MoviePicture.MouseLeave += new System.EventHandler(this.MoviePicture_MouseLeave);
            this.MoviePicture.MouseHover += new System.EventHandler(this.MoviePicture_MouseHover);
            this.MoviePicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoviePicture_MouseMove);
            // 
            // MovieName
            // 
            this.MovieName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MovieName.Font = new System.Drawing.Font("Simplified Arabic", 14.75F, System.Drawing.FontStyle.Bold);
            this.MovieName.ForeColor = System.Drawing.Color.Gainsboro;
            this.MovieName.Location = new System.Drawing.Point(0, 156);
            this.MovieName.Name = "MovieName";
            this.MovieName.Size = new System.Drawing.Size(289, 80);
            this.MovieName.TabIndex = 1;
            this.MovieName.Text = "The Movie Name";
            this.MovieName.MouseLeave += new System.EventHandler(this.MoviePicture_MouseLeave);
            this.MovieName.MouseHover += new System.EventHandler(this.MoviePicture_MouseHover);
            this.MovieName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoviePicture_MouseMove);
            // 
            // MovieInfo
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(126)))));
            this.Controls.Add(this.MovieName);
            this.Controls.Add(this.MoviePicture);
            this.Name = "MovieInfo";
            this.Size = new System.Drawing.Size(289, 236);
            this.MouseLeave += new System.EventHandler(this.MoviePicture_MouseLeave);
            this.MouseHover += new System.EventHandler(this.MoviePicture_MouseHover);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoviePicture_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.MoviePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2PictureBox MoviePicture;
        public System.Windows.Forms.Label MovieName;
    }
}
