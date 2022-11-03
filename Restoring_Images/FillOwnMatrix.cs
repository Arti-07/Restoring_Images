using Restoring_Images.CurrentFilters;
using System;
using System.Windows.Forms;

namespace Restoring_Images
{
    public partial class FillOwnMatrix : Form
    {
        private Kernel kernel;

        public Kernel GetKer()
        {
            return kernel;
        }
        public FillOwnMatrix()
        {
            InitializeComponent();
        }
        public FillOwnMatrix(Kernel kernel)
        {
            InitializeComponent();
            this.kernel = kernel;
            dataGrid.RowCount = kernel.GetRowCount();
            dataGrid.ColumnCount = kernel.GetColCount();
            foreach (DataGridViewColumn col in dataGrid.Columns)
            {
                col.Width = 30;
            }
        }
        
        private double[,] RoundMass(double[,] inputMas, int roundPar)
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
        private static double[,] GetNormalizedMatrix(double[,] matrix)
        {
            double sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }
            }
            double[,] resultMatrix = new double[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < resultMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < resultMatrix.GetLength(1); j++)
                {
                    resultMatrix[i, j] = matrix[i, j] / sum;
                }
            }
            return resultMatrix;
        }

        private void btnAddColMenu_Click(object sender, EventArgs e)
        {
            dataGrid.Columns.Add("", "");
            foreach (DataGridViewColumn col in dataGrid.Columns)
            {
                col.Width = 30;
            }
        }

        private void btnAddRowMenu_Click(object sender, EventArgs e)
        {
            dataGrid.Rows.Add("", "");
            foreach(DataGridViewRow row in dataGrid.Rows)
            {
                row.Height = 30;
            }
        }


        private void btnSaveKernelMenu_Click(object sender, EventArgs e)
        {
            double[,] DataValue = new double[dataGrid.RowCount, dataGrid.ColumnCount];
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                foreach (DataGridViewColumn col in dataGrid.Columns) 
                {
                    DataValue[row.Index, col.Index] = Convert.ToDouble(dataGrid.Rows[row.Index].Cells[col.Index].Value);  
                }
            }
            kernel.Ker = GetNormalizedMatrix(DataValue);
            MessageBox.Show("Успешное сохранение матрицы!", "Сообщение",
                MessageBoxButtons.OK);
            /*
            for (int i = 0; i < DataValue.GetLength(0); i++)
            {
                for (int j = 0; j < DataValue.GetLength(1); j++)
                {
                    listBox1.Items.Add(kernel.Ker[i, j].ToString());
                }
            }
            */
        }

        private void btnShowNormalizeMenu_Click(object sender, EventArgs e)
        {
            dataGrid.Rows.Clear();
            dataGrid.Refresh();
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
        }
    }
}
