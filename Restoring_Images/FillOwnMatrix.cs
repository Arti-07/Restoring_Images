using Restoring_Images.CurrentFilters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Restoring_Images
{
    public partial class FillOwnMatrix : Form
    {
        private int n = 3;
        public FillOwnMatrix()
        {
            InitializeComponent();
        }

        private void btnFillTable_Click(object sender, EventArgs e)
        {

            int n = 3;
            dataGrid.RowCount = n;
            dataGrid.ColumnCount = n;
            int[,] a = new int[n, n];
            Random r = new Random(10);
            for (int i = 0; i < dataGrid.ColumnCount; i++)
            {
                for (int j = 0; j < dataGrid.RowCount; j++)
                {
                    a[i, j] = r.Next(10);
                    dataGrid.Rows[i].Cells[j].Value = a[i, j].ToString();
                }
            }
        }
    }
}
