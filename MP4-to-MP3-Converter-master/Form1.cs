using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using NReco.VideoConverter;
using Tulpep.NotificationWindow;
using YoutubeExtractor;

namespace MP4_to_MP3_Converter
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        string musicFolderPath, musicName, musicFileName;
        string[] videoPaths, videoNames;
        List<string> musicNames = new List<string>();

        // Completed task number
        int counter = 0;

        // Original size of the components
        Size formSize;
        Size pictureSize;
        Point pictureLocation;

        // Frame Counter
        float frameNumber = 0f;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resolutionCombobox.SelectedIndex = 0;
            tabControl.SelectedIndex = 0;
            previewCheckBox.CheckStateChanged += previewCheckBox_CheckedChanged;
            // Initialize the value
            formSize = this.Size;
            pictureSize = pictureBox1.Size;
            pictureLocation = pictureBox1.Location;
        }

        private void listBoxPaths_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                listBoxPaths.Items.Remove(listBoxPaths.SelectedItem);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog() { Multiselect = true };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                videoPaths = openFileDialog.FileNames;
                videoNames = openFileDialog.SafeFileNames;
            }
            foreach (var path in videoPaths)
            {
                listBoxPaths.Items.Add(path);
            }
            completedTasksLabel.Text = videoPaths.Length.ToString() + " task(s) added";
        }

        private void listBoxPaths_SelectedValueChanged(object sender, EventArgs e)
        {
            if (previewCheckBox.Enabled == false && listBoxPaths.SelectedItem != null)
            {
                previewCheckBox.Enabled = true;
            }

            if (previewCheckBox.Checked == true)
                getPreview();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                musicFolderPath = folderBrowserDialog.SelectedPath;

                foreach (var videoName in videoNames)
                {
                    musicName = videoName.Substring(0, videoName.Length - 4);
                    musicFileName = musicFolderPath + "\\" + musicName + ".mp3";
                    musicNames.Add(musicFileName);
                }
            }
            savePathBox.Text = musicFolderPath;
        }


        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (listBoxPaths.SelectedItems.Count == 0)
            {
                MessageBox.Show("There is no selected item for queue", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (savePathBox.Text == "")
            {
                MessageBox.Show("There is no selected save path", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (listBoxPaths.SelectedItems.Count != 0 && savePathBox.Text != "")
                {
                    completedTasksLabel.Text = videoPaths.Length.ToString() + " task(s) has started";

                    // Construct an instance of FFMpegConverter
                    var convert = new FFMpegConverter();

                    // Zip two list to one list
                    var pathandFiles = listBoxPaths.SelectedItems.Cast<string>().Zip(musicNames, (p, n) => new { Path = p, Name = n });

                    foreach (var pn in pathandFiles)
                    {
                        // Convert video to mp3 audio format
                        convert.ConvertMedia(pn.Path.Trim(), pn.Name.Trim(), "mp3");
                        counter += 1;
                        completedTasksLabel.Text = counter.ToString() + " of " + videoPaths.Count().ToString() + " task(s) completed";
                    }
                    // Call the notifier
                    notifier();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void previewCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (previewCheckBox.Checked == true)
            {
                this.nextFrameButton.Visible = true;
                this.previousFrameButton.Visible = true;
                this.Size = new Size(921, 344);
                pictureBox1.Location = new Point(535, 63);
                pictureBox1.Size = new Size(360, 240);

                getPreview();


            }
            if (previewCheckBox.Checked == false)
            {
                pictureBox1.Image = null;
                pictureBox1.Size = pictureSize;
                pictureBox1.Location = pictureLocation;
                this.Size = formSize;
            }
        }

        private void previousFrameButton_Click(object sender, EventArgs e)
        {
            frameNumber -= 1f;
            getPreview();
        }

        private void nextFrameButton_Click(object sender, EventArgs e)
        {
            frameNumber += 1f;
            getPreview();
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            downloadProgressBar.Minimum = 0;
            downloadProgressBar.Maximum = 100;
            var videos = DownloadUrlResolver.GetDownloadUrls(youtubePathTextbox.Text);
            var video = videos.First(q => q.VideoType == VideoType.Mp4 && q.Resolution == Convert.ToInt32(resolutionCombobox.Text));
            if (video.RequiresDecryption)
                DownloadUrlResolver.DecryptDownloadUrl(video);
            VideoDownloader videoDownloader = new VideoDownloader(video, @"C:\Users\Selectra\Desktop\MP4-to-MP3-Converter-master");
            videoDownloader.DownloadProgressChanged += VideoDownloader_DownloadProgressChanged;
            Thread thread = new Thread(() => { videoDownloader.Execute(); }) { IsBackground = true };
            thread.Start();
        }

        private void VideoDownloader_DownloadProgressChanged(object sender, ProgressEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                downloadProgressBar.Value = (int)e.ProgressPercentage;
                downloadProgressLabel.Text = $"{string.Format("{0:0.##}", e.ProgressPercentage)}";
                downloadProgressBar.Update();
            }));
        }


        #region Get Preview
        /// <summary>
        /// Gets the preview of selected list item
        /// </summary>
        private void getPreview()
        {
            if (listBoxPaths.SelectedItem != null)
            {
                FFMpegConverter fFMpeg = new FFMpegConverter();

                System.IO.Stream stream = new System.IO.MemoryStream();
                fFMpeg.GetVideoThumbnail((string)listBoxPaths.SelectedItem, stream, frameNumber);
                Image img = Image.FromStream(stream);

                img = ResizeImage(img, pictureBox1.Width, pictureBox1.Height);
                pictureBox1.Image = img;
            }
        }
        #endregion

        #region Popup Notifier

        // Popup notifier class
        private void notifier()
        {
            PopupNotifier notifier = new PopupNotifier()
            {
                TitleText = "FINISHED",
                ContentText = "Process has been completed",
                ShowCloseButton = true,
                ShowOptionsButton = false,
                TitleFont = new Font("Arial", 26f, FontStyle.Bold, GraphicsUnit.Point),
                TitlePadding = new Padding(100, 0, 0, 0),
                TitleColor = Color.DarkBlue,
                ContentFont = new Font("Bell MT", 15f, FontStyle.Regular, GraphicsUnit.Point),
                ContentColor = Color.Black,
                ContentHoverColor = Color.Red,
                BorderColor = Color.Cornsilk,
                AnimationDuration = 300,
            };
            notifier.Popup();
        }

        #endregion

        #region Resize Image
        /// <summary>
        /// Resize the image to the specified width and height.
        /// </summary>
        /// <param name="image">The image to resize.</param>
        /// <param name="width">The width to resize to.</param>
        /// <param name="height">The height to resize to.</param>
        /// <returns>The resized image.</returns>
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
        #endregion

        private static string LoadJson(string url)
        {
            //System.IO.Stream stream2 = new System.IO.MemoryStream();
            //TextWriter textWriter = new StreamWriter(@"C:\Users\Selectra\Desktop\");
            //Newtonsoft.Json.JsonTextWriter jsonTextWriter = new Newtonsoft.Json.JsonTextWriter(textWriter);
            //jsonTextWriter.WriteComment("Hey it's me");

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.CookieContainer = new CookieContainer();
            request.CookieContainer.Add(new Cookie(@"SID", @"SID GOES HERE") { Domain = "youtube.com" });
            request.CookieContainer.Add(new Cookie(@"SSID", @"SSID GOES HERE") { Domain = "youtube.com" });
            var response = (HttpWebResponse)request.GetResponse();

            string pageSource;

            using (var stream = new StreamReader(response.GetResponseStream()))
                pageSource = stream.ReadToEnd();

            return pageSource;
        }
    }
}
