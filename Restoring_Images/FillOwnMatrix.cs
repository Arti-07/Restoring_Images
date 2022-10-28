using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restoring_Images
{
    public partial class FillOwnMatrix : Form
    {
        private int n = 3;
        public FillOwnMatrix()
        {
            InitializeComponent();
            dataGrid.ColumnCount = n;
            dataGrid.Columns[0].Name = "1";
            dataGrid.Columns[1].Name = "2";
            dataGrid.Columns[2].Name = "3";
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FillData()
        {

            int[,] mas =
            {
                { 1,2,3},
                { 4,5,6},
                { 7,8,9}
            };
            int[] row = { 1, 2, 3 };
            dataGrid.Rows.Add(row.ToString());
        }
        private void btnFillTable_Click(object sender, EventArgs e)
        {
            FillData();
        }
    }
}
