
namespace Restoring_Images
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.workWithManyFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxOld = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.pageOld = new System.Windows.Forms.TabPage();
            this.tabNewImage = new System.Windows.Forms.TabPage();
            this.pictureBoxNew = new System.Windows.Forms.PictureBox();
            this.btnGaussianBlur = new System.Windows.Forms.Button();
            this.boxBlurs = new System.Windows.Forms.ComboBox();
            this.labelSelect = new System.Windows.Forms.Label();
            this.kernelSize = new System.Windows.Forms.NumericUpDown();
            this.labelKernelSize = new System.Windows.Forms.Label();
            this.labelSigma = new System.Windows.Forms.Label();
            this.numericSigma = new System.Windows.Forms.NumericUpDown();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.btmMakeOwnMatrix = new System.Windows.Forms.Button();
            this.btnCheckKernel = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOld)).BeginInit();
            this.tabControl.SuspendLayout();
            this.pageOld.SuspendLayout();
            this.tabNewImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kernelSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSigma)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.workWithManyFilesToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(958, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpen,
            this.menuSave});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(46, 24);
            this.menuFile.Text = "File";
            // 
            // menuOpen
            // 
            this.menuOpen.Name = "menuOpen";
            this.menuOpen.Size = new System.Drawing.Size(128, 26);
            this.menuOpen.Text = "Open";
            this.menuOpen.Click += new System.EventHandler(this.menuOpen_Click);
            // 
            // menuSave
            // 
            this.menuSave.Name = "menuSave";
            this.menuSave.Size = new System.Drawing.Size(128, 26);
            this.menuSave.Text = "Save";
            this.menuSave.Click += new System.EventHandler(this.menuSave_Click);
            // 
            // workWithManyFilesToolStripMenuItem
            // 
            this.workWithManyFilesToolStripMenuItem.Name = "workWithManyFilesToolStripMenuItem";
            this.workWithManyFilesToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.workWithManyFilesToolStripMenuItem.Text = "Work with many files";
            this.workWithManyFilesToolStripMenuItem.Click += new System.EventHandler(this.workWithManyFilesToolStripMenuItem_Click);
            // 
            // pictureBoxOld
            // 
            this.pictureBoxOld.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxOld.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxOld.Name = "pictureBoxOld";
            this.pictureBoxOld.Size = new System.Drawing.Size(468, 453);
            this.pictureBoxOld.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOld.TabIndex = 1;
            this.pictureBoxOld.TabStop = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "YourFile";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.pageOld);
            this.tabControl.Controls.Add(this.tabNewImage);
            this.tabControl.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabControl.Location = new System.Drawing.Point(12, 31);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(482, 495);
            this.tabControl.TabIndex = 2;
            // 
            // pageOld
            // 
            this.pageOld.BackColor = System.Drawing.Color.NavajoWhite;
            this.pageOld.Controls.Add(this.pictureBoxOld);
            this.pageOld.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pageOld.Location = new System.Drawing.Point(4, 32);
            this.pageOld.Name = "pageOld";
            this.pageOld.Padding = new System.Windows.Forms.Padding(3);
            this.pageOld.Size = new System.Drawing.Size(474, 459);
            this.pageOld.TabIndex = 0;
            this.pageOld.Text = "Your loaded image";
            // 
            // tabNewImage
            // 
            this.tabNewImage.BackColor = System.Drawing.Color.NavajoWhite;
            this.tabNewImage.Controls.Add(this.pictureBoxNew);
            this.tabNewImage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabNewImage.Location = new System.Drawing.Point(4, 32);
            this.tabNewImage.Name = "tabNewImage";
            this.tabNewImage.Padding = new System.Windows.Forms.Padding(3);
            this.tabNewImage.Size = new System.Drawing.Size(474, 459);
            this.tabNewImage.TabIndex = 1;
            this.tabNewImage.Text = "Processed image";
            // 
            // pictureBoxNew
            // 
            this.pictureBoxNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxNew.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxNew.Name = "pictureBoxNew";
            this.pictureBoxNew.Size = new System.Drawing.Size(468, 453);
            this.pictureBoxNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNew.TabIndex = 0;
            this.pictureBoxNew.TabStop = false;
            // 
            // btnGaussianBlur
            // 
            this.btnGaussianBlur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGaussianBlur.AutoSize = true;
            this.btnGaussianBlur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(119)))), ((int)(((byte)(0)))));
            this.btnGaussianBlur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGaussianBlur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGaussianBlur.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGaussianBlur.ForeColor = System.Drawing.Color.Transparent;
            this.btnGaussianBlur.Location = new System.Drawing.Point(521, 476);
            this.btnGaussianBlur.Name = "btnGaussianBlur";
            this.btnGaussianBlur.Size = new System.Drawing.Size(437, 50);
            this.btnGaussianBlur.TabIndex = 7;
            this.btnGaussianBlur.Text = "Apply blur";
            this.btnGaussianBlur.UseVisualStyleBackColor = false;
            this.btnGaussianBlur.Click += new System.EventHandler(this.btnGaussianBlur_Click);
            // 
            // boxBlurs
            // 
            this.boxBlurs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boxBlurs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(0)))));
            this.boxBlurs.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.boxBlurs.ForeColor = System.Drawing.Color.Black;
            this.boxBlurs.FormattingEnabled = true;
            this.boxBlurs.Items.AddRange(new object[] {
            "Box Blur",
            "Gaussian Blur",
            "Motion Blur",
            "Motion Blur (left to right)",
            "Motion Blur (right to left)"});
            this.boxBlurs.Location = new System.Drawing.Point(709, 118);
            this.boxBlurs.Name = "boxBlurs";
            this.boxBlurs.Size = new System.Drawing.Size(237, 31);
            this.boxBlurs.TabIndex = 8;
            this.boxBlurs.SelectedIndexChanged += new System.EventHandler(this.boxBlurs_SelectedIndexChanged);
            // 
            // labelSelect
            // 
            this.labelSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSelect.AutoSize = true;
            this.labelSelect.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSelect.ForeColor = System.Drawing.Color.Black;
            this.labelSelect.Location = new System.Drawing.Point(516, 119);
            this.labelSelect.Name = "labelSelect";
            this.labelSelect.Size = new System.Drawing.Size(129, 23);
            this.labelSelect.TabIndex = 9;
            this.labelSelect.Text = "Select your blur";
            // 
            // kernelSize
            // 
            this.kernelSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kernelSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(0)))));
            this.kernelSize.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kernelSize.ForeColor = System.Drawing.Color.Black;
            this.kernelSize.Location = new System.Drawing.Point(709, 80);
            this.kernelSize.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.kernelSize.Name = "kernelSize";
            this.kernelSize.Size = new System.Drawing.Size(237, 30);
            this.kernelSize.TabIndex = 10;
            this.kernelSize.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.kernelSize.ValueChanged += new System.EventHandler(this.kernelSize_ValueChanged);
            // 
            // labelKernelSize
            // 
            this.labelKernelSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKernelSize.AutoSize = true;
            this.labelKernelSize.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelKernelSize.ForeColor = System.Drawing.Color.Black;
            this.labelKernelSize.Location = new System.Drawing.Point(516, 84);
            this.labelKernelSize.Name = "labelKernelSize";
            this.labelKernelSize.Size = new System.Drawing.Size(91, 23);
            this.labelKernelSize.TabIndex = 11;
            this.labelKernelSize.Text = "Kernel size";
            // 
            // labelSigma
            // 
            this.labelSigma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSigma.AutoSize = true;
            this.labelSigma.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSigma.ForeColor = System.Drawing.Color.Black;
            this.labelSigma.Location = new System.Drawing.Point(516, 47);
            this.labelSigma.Name = "labelSigma";
            this.labelSigma.Size = new System.Drawing.Size(175, 23);
            this.labelSigma.TabIndex = 13;
            this.labelSigma.Text = "Sigma (Gaussian Blur)";
            // 
            // numericSigma
            // 
            this.numericSigma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericSigma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(0)))));
            this.numericSigma.DecimalPlaces = 1;
            this.numericSigma.Enabled = false;
            this.numericSigma.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numericSigma.ForeColor = System.Drawing.Color.Black;
            this.numericSigma.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericSigma.Location = new System.Drawing.Point(709, 43);
            this.numericSigma.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericSigma.Name = "numericSigma";
            this.numericSigma.Size = new System.Drawing.Size(237, 30);
            this.numericSigma.TabIndex = 14;
            // 
            // richTextBox
            // 
            this.richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(151)))), ((int)(((byte)(48)))));
            this.richTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.richTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox.Location = new System.Drawing.Point(516, 167);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.Size = new System.Drawing.Size(430, 152);
            this.richTextBox.TabIndex = 15;
            this.richTextBox.Text = "";
            // 
            // btmMakeOwnMatrix
            // 
            this.btmMakeOwnMatrix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btmMakeOwnMatrix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(119)))), ((int)(((byte)(0)))));
            this.btmMakeOwnMatrix.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmMakeOwnMatrix.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btmMakeOwnMatrix.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btmMakeOwnMatrix.ForeColor = System.Drawing.Color.Transparent;
            this.btmMakeOwnMatrix.Location = new System.Drawing.Point(844, 325);
            this.btmMakeOwnMatrix.Name = "btmMakeOwnMatrix";
            this.btmMakeOwnMatrix.Size = new System.Drawing.Size(102, 65);
            this.btmMakeOwnMatrix.TabIndex = 16;
            this.btmMakeOwnMatrix.Text = "Draw own matrix";
            this.btmMakeOwnMatrix.UseVisualStyleBackColor = false;
            this.btmMakeOwnMatrix.Click += new System.EventHandler(this.btmMakeOwnMatrix_Click);
            // 
            // btnCheckKernel
            // 
            this.btnCheckKernel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckKernel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(119)))), ((int)(((byte)(0)))));
            this.btnCheckKernel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckKernel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheckKernel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCheckKernel.ForeColor = System.Drawing.Color.Transparent;
            this.btnCheckKernel.Location = new System.Drawing.Point(516, 325);
            this.btnCheckKernel.Name = "btnCheckKernel";
            this.btnCheckKernel.Size = new System.Drawing.Size(175, 51);
            this.btnCheckKernel.TabIndex = 17;
            this.btnCheckKernel.Text = "Check selected filter";
            this.btnCheckKernel.UseVisualStyleBackColor = false;
            this.btnCheckKernel.Click += new System.EventHandler(this.btnCheckKernel_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(958, 538);
            this.Controls.Add(this.btnCheckKernel);
            this.Controls.Add(this.btmMakeOwnMatrix);
            this.Controls.Add(this.boxBlurs);
            this.Controls.Add(this.labelSelect);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.kernelSize);
            this.Controls.Add(this.labelKernelSize);
            this.Controls.Add(this.numericSigma);
            this.Controls.Add(this.btnGaussianBlur);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.labelSigma);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(937, 585);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restoring Images";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOld)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.pageOld.ResumeLayout(false);
            this.tabNewImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kernelSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSigma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuOpen;
        private System.Windows.Forms.ToolStripMenuItem menuSave;
        private System.Windows.Forms.PictureBox pictureBoxOld;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage pageOld;
        private System.Windows.Forms.TabPage tabNewImage;
        private System.Windows.Forms.PictureBox pictureBoxNew;
        private System.Windows.Forms.ToolStripMenuItem workWithManyFilesToolStripMenuItem;
        private System.Windows.Forms.Button btnGaussianBlur;
        private System.Windows.Forms.ComboBox boxBlurs;
        private System.Windows.Forms.Label labelSelect;
        private System.Windows.Forms.NumericUpDown kernelSize;
        private System.Windows.Forms.Label labelKernelSize;
        private System.Windows.Forms.Label labelSigma;
        private System.Windows.Forms.NumericUpDown numericSigma;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button btmMakeOwnMatrix;
        private System.Windows.Forms.Button btnCheckKernel;
    }
}

