using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageEditor;

namespace Restoring_Images
{
    public partial class WorkerWithDirectory : Form
    {
        private Thread thread;
        private string Path;
        private List<string> Files;
        private List<Image> imagesFromDirectory;
        private List<Image> bluredImages;


        public WorkerWithDirectory()
        {
            InitializeComponent();
        }

        private void backToRestoringImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(Open);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void Open(object sender)
        {
            Application.Run(new MainForm());
        }

        private void btnSelectDirectory_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result==DialogResult.OK && !string.IsNullOrEmpty(fbd.SelectedPath))
                {
                    Files = Directory.GetFiles(fbd.SelectedPath).ToList();
                    MessageBox.Show($@"Files found : {Files.Count}", "Message");
                    Path = fbd.SelectedPath;
                    textBoxDic.Text = $@"{Path}";
                }
            }
        }

        private void btnStartBlurring_Click(object sender, EventArgs e)
        {
            string dir = $@"{Path}\test";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            imagesFromDirectory = new List<Image>();
            foreach (var imgPath in Files)
            {
                imagesFromDirectory.Add(new Bitmap(imgPath));
            }

            int selectedFilter = comboBoxFilters.SelectedIndex; 
            Thread thread1 = new Thread(()=>
            {
                BlurAllImages(imagesFromDirectory, selectedFilter);
                string savePath = $@"{dir}\";
                SaveImages(savePath, bluredImages);
            });
            thread1.Start();
            //BlurAllImages(comboBoxFilters.SelectedIndex);
            //string savePath = $@"{dir}\";
            //SaveImages(savePath, bluredImages);
        }

        private void BlurAllImages(List<Image> sourceImages, int blurNum)
        {
            //progressBar.Value = 0;
            //progressBar.Maximum = imagesFromDirectory.Count;
            //var step = 1 / progressBar.Maximum;

            bluredImages = new List<Image>();
            switch (blurNum)
            {
                case 0:
                    foreach (Image image in sourceImages)
                    {
                        bluredImages.Add(image.Convolution(MyFilters.Blur3x3Filter));
                        //progressBar.Value += (int) step;
                    }
                    break;
                case 1:
                    foreach (Image image in sourceImages)
                    {
                        bluredImages.Add(image.Convolution(MyFilters.Blur5x5Filter));
                        //progressBar.Value += (int)step;
                    }
                    break;
                case 2:
                    foreach (Image image in sourceImages)
                    {
                        bluredImages.Add(image.Convolution(MyFilters.Gaussian3x3BlurFilter));
                        //progressBar.Value += (int)step;
                    }
                    break;
                case 3:
                    foreach (Image image in sourceImages)
                    {
                        bluredImages.Add(image.Convolution(MyFilters.Gaussian5x5BlurFilter));
                        //progressBar.Value += (int)step;
                    }
                    break;
                case 4:
                    foreach (Image image in sourceImages)
                    {
                        bluredImages.Add(image.Convolution(MyFilters.MotionBlurFilter));
                        //progressBar.Value += (int)step;
                    }
                    break;
                case 5:
                    foreach (Image image in sourceImages)
                    {
                        bluredImages.Add(image.Convolution(MyFilters.MotionBlurLeftToRightFilter));
                        //progressBar.Value += (int)step;
                    }
                    break;
                case 6:
                    foreach (Image image in sourceImages)
                    {
                        bluredImages.Add(image.Convolution(MyFilters.MotionBlurRightToLeftFilter));
                        //progressBar.Value += (int)step;
                    }
                    break;
                case 7:
                    foreach (Image image in sourceImages)
                    {
                        bluredImages.Add(image.Convolution(MyFilters.SoftenFilter));
                        //progressBar.Value += (int)step;
                    }
                    break;
            }
            //progressBar.Value = progressBar.Maximum;
        }


        private void SaveImages(string path, List<Image>images)
        {
            int index = 0;
            foreach (Image img in images)
            {
                img.Save($"{path}\\Image{index}.jpg",ImageFormat.Jpeg);
                index++;    
            }

        }
    }
}
