﻿using System;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;
using ImageEditor;
using System.Security.Policy;
using Restoring_Images.CurrentFilters;

namespace Restoring_Images
{
    public partial class MainForm : Form
    {
        private Thread thread;
        private string imagePath;
        private Image image;
        //private MyImage img;
        private Image freshImage;

        private int kerSize;
        private Kernel kernel;
        public MainForm(Kernel ker)
        {
            this.kernel = ker;
            InitializeComponent();
        }
        public MainForm()
        {
            InitializeComponent();
        }
        public Kernel GetKernel()
        {
            return kernel;
        }
        private void menuOpen_Click(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog
            {
                Title = "Select your image",
                Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"
            };

            if (fileDialog.ShowDialog() != DialogResult.OK) return;
            try
            {
                imagePath = fileDialog.FileName;
                image = new Bitmap(imagePath);
                pictureBoxOld.Image = image;
            }
            catch (OutOfMemoryException exception)
            {
                MessageBox.Show(exception.Message, "Error!");
                throw;
            }
        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "JPG(*.JPG)|*.jpg"
            };
            if (saveDialog.ShowDialog()==DialogResult.OK)
            {
                freshImage.Save(saveDialog.FileName);
            }
        }

        private void btnBlur_Click(object sender, EventArgs e)
        {
            /*Быстрый unsafe blur*/
            Bitmap copy = new Bitmap((Bitmap) this.pictureBoxOld.Image);
            Bitmap result = Blurs.Blur(copy, 5);
            this.pictureBoxNew.Image = (Image) result;
        }

        private void btnDeblur_Click(object sender, EventArgs e)
        {
            /*deblur*/
            ConvolutionFilter deblurFilter = new ConvolutionFilter();
            Image deblurImage =
                InverseFiltering.Filtering(image, MyFilters.MotionBlurLeftToRightFilter, out deblurFilter);
            pictureBoxNew.Image = deblurImage;
        }

        private void workWithManyFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenWorkWithMany);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenWorkWithMany(object sender)    
        {
            Application.Run(new WorkerWithDirectory());
        }

        private void OpenFillMatrix(object sender)
        {
            Application.Run(new FillOwnMatrix());
        }

        private void btnGaussianBlur_Click(object sender, EventArgs e)
        {
            var ker = GetKernel(boxBlurs.SelectedIndex);
            kernel = new Kernel(GetKernel(boxBlurs.SelectedIndex));
            Bitmap srcImage = (Bitmap)Image.FromFile(imagePath);
            freshImage = MyBlurs.Convolve(srcImage, ker);
            pictureBoxNew.Image = freshImage;
        }

        private void boxBlurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indx = boxBlurs.SelectedIndex;
            switch (indx)
            {
                case 0:
                    numericSigma.Enabled = false;
                    richTextBox.Text = "Блочное размытие — это линейный фильтр в пространственной области, в котором каждый пиксель в результирующем изображении имеет значение, равное среднему значению соседних пикселей во входном изображении.";
                    kernel = new Kernel(GetKernel(indx));
                    break;
                case 1:
                    numericSigma.Enabled = true;
                    richTextBox.Text = "Размытие по Гауссу в цифровой обработке изображений — способ размытия изображения с помощью функции Гаусса, названной в честь немецкого математика Карла Фридриха Гаусса.";
                    kernel = new Kernel(GetKernel(indx));
                    break;
                case 2:
                    numericSigma.Enabled = false;
                    richTextBox.Text = "Motion blur — размытие изображения при повороте камеры, воспроизведении сцен движения или быстро движущихся объектов.";
                    kernel = new Kernel(GetKernel(indx));
                    break;
                case 3:
                    numericSigma.Enabled = false;
                    richTextBox.Text = "Motion blur — размытие изображения по диагонали слева направо";
                    kernel = new Kernel(GetKernel(indx));
                    break;
                case 4:
                    numericSigma.Enabled = false;
                    richTextBox.Text = "Motion blur — размытие изображения по диагонали справа налево";
                    kernel = new Kernel(GetKernel(indx));
                    break;

                default:
                    numericSigma.Enabled = false;
                    richTextBox.Text = " ";
                    break;
            }

        }
        private double[,]GetKernel(int blurIndex)
        {
            kerSize = (int)kernelSize.Value; 
            double[,] kernel = new double[kerSize, kerSize];
            switch (blurIndex)
            {
                case 0:
                    kernel = MyBlurs.BoxBlur(kerSize);
                    break;
                case 1:
                    kernel = MyBlurs.GausBlur(kerSize, (double)numericSigma.Value);
                    break;
                case 2:
                    kernel = MyBlurs.MotionBlur(kerSize);
                    break;
                case 3:
                    kernel = MyBlurs.MotionBlurLeftToRight(kerSize);
                    break;
                case 4:
                    kernel = MyBlurs.MotionBlurRightToleft(kerSize);
                    break;
                default:
                    break;
            }
            return kernel;
        }

        private void btmMakeOwnMatrix_Click(object sender, EventArgs e)
        {
            thread = new Thread(OpenFillMatrix);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btnCheckKernel_Click(object sender, EventArgs e)
        {
            ViewKernel vk = new ViewKernel(kernel);
            vk.ShowDialog();
        }

        private void kernelSize_ValueChanged(object sender, EventArgs e)
        {
            kernel = new Kernel(GetKernel(boxBlurs.SelectedIndex), (int)kernelSize.Value);
        }
    }
}
