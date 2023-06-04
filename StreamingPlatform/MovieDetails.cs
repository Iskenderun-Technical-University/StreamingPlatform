using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamingPlatform
{
    public partial class MovieDetails : Form
    {
        public MovieDetails()
        {
            InitializeComponent();
        }
        string videoPath;
        long fileSizeInBytes;
        SqlConnection con= new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kg462\Desktop\StreamingPlatform\StreamingPlatform\Database.mdf;Integrated Security=True");

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Video Files|*.avi;*.mp4;*.mov;*.mkv;*.flv;*.wmv|All Files|*.*";
                openFileDialog.Title = "Select a Video File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected file stream
                    using (Stream fileStream = openFileDialog.OpenFile())
                    {
                        // Get the path of the selected video file
                         videoPath = ((FileStream)fileStream).Name;
                        ShowTrailer.URL= videoPath;
                        fileSizeInBytes = fileStream.Length;
                        //label1.Text =fileSizeInBytes + videoPath ;
                        //SaveVideo();
                        // Use the videoPath variable as needed
                    }
                }
            }
        }

        private void CreateVideoFile()
        {
            con.Open();
            string query = "select VideoFile from MovieTb where ID=1";
            SqlCommand cmd = new SqlCommand(query, con);
            var bytes = (byte[])cmd.ExecuteScalar();
            File.WriteAllBytes(@"C:\Users\kg462\Desktop\Venom 2 Trailer.mp4", bytes);
            con.Close();
            MessageBox.Show("Video Created Successfully!!");
        }

        private void SaveVideo() {
            byte[] buffer = new byte[fileSizeInBytes];
            using (Stream video = File.OpenRead(videoPath)) {
                video.Read(buffer, 0, buffer.Length);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update MovieTb set VideoFile =@stream where Name='Venom2'", con);
                    cmd.Parameters.Add("@stream", System.Data.SqlDbType.VarBinary).Value = buffer;
                    cmd.ExecuteNonQuery();
                    con.Close();
            }
        }
    }
}
