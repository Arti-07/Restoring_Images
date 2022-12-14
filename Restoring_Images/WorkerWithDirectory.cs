using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Restoring_Images.CurrentFilters;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ProgressBar = System.Windows.Forms.ProgressBar;

namespace Restoring_Images
{
    public partial class WorkerWithDirectory : Form
    {
        private Thread thread;
        private string Path;
        private List<string> Files;
        private List<Image> imagesFromDirectory;
        private List<Image> bluredImages;

        private Kernel kernel;
        private int filesCount;

        public WorkerWithDirectory()
        {
            InitializeComponent();
        }
        public WorkerWithDirectory(Kernel kernel)
        {
            InitializeComponent();
            this.kernel = kernel;
            textBoxSelectedFilter.Text = $"{kernel.Name} , size = {kernel.Size}";
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
                    filesCount = Files.Count;
                }
            }
        }

        private void btnStartBlurring_Click(object sender, EventArgs e)
        {
            progressBar.Maximum = filesCount;
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

            BlurImages(imagesFromDirectory, progressBar);
            MessageBox.Show("Успех!", "Сообщение", MessageBoxButtons.OK);
            string savePath = $@"{dir}\";
            SaveImages(savePath, bluredImages);

            //Thread thread = new Thread(()=>
            //{
            //    BlurImages(imagesFromDirectory);
            //    string savePath = $@"{dir}\";
            //    SaveImages(savePath, bluredImages);
            //});
            //thread.Start();
        }

        private void BlurImages(List<Image> sourseImages, ProgressBar pb)
        {
            bluredImages = new List<Image>();
            foreach (Image img in sourseImages) 
            {
                Bitmap bitmap = (Bitmap)img;
                bluredImages.Add(MyBlurs.Convolve(bitmap, kernel.Ker));
                pb.Value += 1;
            }
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
