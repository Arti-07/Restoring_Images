﻿namespace Restoring_Images
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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.btnAddCol = new System.Windows.Forms.Button();
            this.btnFillTable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(12, 12);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 29;
            this.dataGrid.Size = new System.Drawing.Size(428, 426);
            this.dataGrid.TabIndex = 0;
            // 
            // btnAddCol
            // 
            this.btnAddCol.Location = new System.Drawing.Point(446, 393);
            this.btnAddCol.Name = "btnAddCol";
            this.btnAddCol.Size = new System.Drawing.Size(178, 45);
            this.btnAddCol.TabIndex = 1;
            this.btnAddCol.Text = "Add column";
            this.btnAddCol.UseVisualStyleBackColor = true;
            // 
            // btnFillTable
            // 
            this.btnFillTable.Location = new System.Drawing.Point(446, 341);
            this.btnFillTable.Name = "btnFillTable";
            this.btnFillTable.Size = new System.Drawing.Size(155, 46);
            this.btnFillTable.TabIndex = 2;
            this.btnFillTable.Text = "fill table";
            this.btnFillTable.UseVisualStyleBackColor = true;
            this.btnFillTable.Click += new System.EventHandler(this.btnFillTable_Click);
            // 
            // FillOwnMatrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFillTable);
            this.Controls.Add(this.btnAddCol);
            this.Controls.Add(this.dataGrid);
            this.Name = "FillOwnMatrix";
            this.Text = "FillOwnMatrix";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button btnAddCol;
        private System.Windows.Forms.Button btnFillTable;
    }
}