using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoring_Images.CurrentFilters
{
    public class Kernel
    {
        public double[,] Ker { get; set; }
        public int Size { get; set; }
        public Kernel(double[,] ker)
        {
            Ker = ker;
        }
        public Kernel(double[,] ker, int size)
        {
            Ker = ker;
            Size = size;
        }
    }
}
