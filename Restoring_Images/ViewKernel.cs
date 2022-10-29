using Restoring_Images.CurrentFilters;
using System;
using System.Windows.Forms;

namespace Restoring_Images
{
    public partial class ViewKernel : Form
    {
        private Kernel kernel;
        private double[,] RoundMass(double[,]inputMas, int roundPar)
        {
            int rows = inputMas.GetLength(0);
            int cols = inputMas.GetLength(1);
            double[,] result = new double[rows, cols];

            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    result[i, j] = Math.Round(inputMas[i, j], roundPar);
                }
            }
            return result;
        }
        public ViewKernel(Kernel k)
        {
            InitializeComponent();
            kernel = k;
            foreach (DataGridViewColumn col in dataGrid.Columns)
            {
                col.Width = 30;
            }
        }
        public ViewKernel()
        {
            InitializeComponent();
        }
        private void ViewKernel_Load(object sender, EventArgs e)
        {
            double[,] mas = RoundMass(kernel.Ker, 3);
            int rows = mas.GetLength(0);
            int cols = mas.GetLength(1);
            dataGrid.RowCount = rows;
            dataGrid.ColumnCount = cols;

            for (int i = 0; i < dataGrid.ColumnCount; i++)
            {
                for (int j = 0; j < dataGrid.RowCount; j++)
                {
                    dataGrid.Rows[i].Cells[j].Value = mas[i, j].ToString();
                }
            }
            foreach (DataGridViewColumn col in dataGrid.Columns)
            {
                col.Width = 50;
            }
        }
    }
}
