namespace Restoring_Images
{
    partial class FillOwnMatrix
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FillOwnMatrix));
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.btnAddColMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddRowMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveKernelMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnShowNormalizeMenu = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.Location = new System.Drawing.Point(0, 28);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 29;
            this.dataGrid.Size = new System.Drawing.Size(809, 435);
            this.dataGrid.TabIndex = 0;
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddColMenu,
            this.btnAddRowMenu,
            this.btnSaveKernelMenu,
            this.btnShowNormalizeMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(809, 28);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // btnAddColMenu
            // 
            this.btnAddColMenu.Name = "btnAddColMenu";
            this.btnAddColMenu.Size = new System.Drawing.Size(104, 24);
            this.btnAddColMenu.Text = "Add column";
            this.btnAddColMenu.Click += new System.EventHandler(this.btnAddColMenu_Click);
            // 
            // btnAddRowMenu
            // 
            this.btnAddRowMenu.Name = "btnAddRowMenu";
            this.btnAddRowMenu.Size = new System.Drawing.Size(80, 24);
            this.btnAddRowMenu.Text = "Add row";
            this.btnAddRowMenu.Click += new System.EventHandler(this.btnAddRowMenu_Click);
            // 
            // btnSaveKernelMenu
            // 
            this.btnSaveKernelMenu.Name = "btnSaveKernelMenu";
            this.btnSaveKernelMenu.Size = new System.Drawing.Size(125, 24);
            this.btnSaveKernelMenu.Text = "Save this kernel";
            this.btnSaveKernelMenu.Click += new System.EventHandler(this.btnSaveKernelMenu_Click);
            // 
            // btnShowNormalizeMenu
            // 
            this.btnShowNormalizeMenu.Name = "btnShowNormalizeMenu";
            this.btnShowNormalizeMenu.Size = new System.Drawing.Size(173, 24);
            this.btnShowNormalizeMenu.Text = "Show normalize kernel";
            this.btnShowNormalizeMenu.Click += new System.EventHandler(this.btnShowNormalizeMenu_Click);
            // 
            // FillOwnMatrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 463);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FillOwnMatrix";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FillOwnMatrix";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem btnAddColMenu;
        private System.Windows.Forms.ToolStripMenuItem btnAddRowMenu;
        private System.Windows.Forms.ToolStripMenuItem btnSaveKernelMenu;
        private System.Windows.Forms.ToolStripMenuItem btnShowNormalizeMenu;
    }
}