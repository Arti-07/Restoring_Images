
namespace Restoring_Images
{
    partial class WorkerWithDirectory
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkerWithDirectory));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.backToRestoringImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStartBlurirng = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.labelDic = new System.Windows.Forms.Label();
            this.textBoxDic = new System.Windows.Forms.TextBox();
            this.btnSelectDirectory = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.textBoxSelectedFilter = new System.Windows.Forms.TextBox();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.NavajoWhite;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToRestoringImageToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // backToRestoringImageToolStripMenuItem
            // 
            this.backToRestoringImageToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backToRestoringImageToolStripMenuItem.Name = "backToRestoringImageToolStripMenuItem";
            this.backToRestoringImageToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.backToRestoringImageToolStripMenuItem.Text = "Back to MainWindow";
            this.backToRestoringImageToolStripMenuItem.Click += new System.EventHandler(this.backToRestoringImageToolStripMenuItem_Click);
            // 
            // btnStartBlurirng
            // 
            this.btnStartBlurirng.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartBlurirng.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartBlurirng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartBlurirng.Location = new System.Drawing.Point(470, 239);
            this.btnStartBlurirng.Name = "btnStartBlurirng";
            this.btnStartBlurirng.Size = new System.Drawing.Size(318, 139);
            this.btnStartBlurirng.TabIndex = 1;
            this.btnStartBlurirng.Text = "Start Bluring";
            this.btnStartBlurirng.UseVisualStyleBackColor = true;
            this.btnStartBlurirng.Click += new System.EventHandler(this.btnStartBlurring_Click);
            // 
            // label
            // 
            this.label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label.Location = new System.Drawing.Point(12, 43);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(155, 23);
            this.label.TabIndex = 3;
            this.label.Text = "Your selected blur :";
            // 
            // labelDic
            // 
            this.labelDic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDic.AutoSize = true;
            this.labelDic.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDic.Location = new System.Drawing.Point(470, 93);
            this.labelDic.Name = "labelDic";
            this.labelDic.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelDic.Size = new System.Drawing.Size(146, 23);
            this.labelDic.TabIndex = 4;
            this.labelDic.Text = "Selected directory";
            // 
            // textBoxDic
            // 
            this.textBoxDic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDic.Location = new System.Drawing.Point(395, 119);
            this.textBoxDic.Name = "textBoxDic";
            this.textBoxDic.ReadOnly = true;
            this.textBoxDic.Size = new System.Drawing.Size(299, 27);
            this.textBoxDic.TabIndex = 5;
            // 
            // btnSelectDirectory
            // 
            this.btnSelectDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectDirectory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelectDirectory.Location = new System.Drawing.Point(12, 97);
            this.btnSelectDirectory.Name = "btnSelectDirectory";
            this.btnSelectDirectory.Size = new System.Drawing.Size(333, 49);
            this.btnSelectDirectory.TabIndex = 6;
            this.btnSelectDirectory.Text = "Select Directory";
            this.btnSelectDirectory.UseVisualStyleBackColor = true;
            this.btnSelectDirectory.Click += new System.EventHandler(this.btnSelectDirectory_Click);
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.Color.Red;
            this.progressBar.Location = new System.Drawing.Point(12, 349);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(451, 29);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 7;
            // 
            // textBoxSelectedFilter
            // 
            this.textBoxSelectedFilter.Location = new System.Drawing.Point(173, 43);
            this.textBoxSelectedFilter.Name = "textBoxSelectedFilter";
            this.textBoxSelectedFilter.ReadOnly = true;
            this.textBoxSelectedFilter.Size = new System.Drawing.Size(172, 27);
            this.textBoxSelectedFilter.TabIndex = 8;
            // 
            // WorkerWithDirectory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(800, 390);
            this.Controls.Add(this.textBoxSelectedFilter);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnSelectDirectory);
            this.Controls.Add(this.textBoxDic);
            this.Controls.Add(this.labelDic);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnStartBlurirng);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "WorkerWithDirectory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Directory Blur";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem backToRestoringImageToolStripMenuItem;
        private System.Windows.Forms.Button btnStartBlurirng;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelDic;
        private System.Windows.Forms.TextBox textBoxDic;
        private System.Windows.Forms.Button btnSelectDirectory;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox textBoxSelectedFilter;
    }
}