using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageEditor;

namespace Restoring_Images
{
    public static class MyFilters
    {

        public static ConvolutionFilter Blur3x3Filter
        {
            get
            {
                return new ConvolutionFilter("Blur3x3Filter",
                    new double[,]
                    {
                        {0.0, 0.2, 0.0,},
                        {0.2, 0.2, 0.2,},
                        {0.0, 0.2, 0.2,},
                    });
            }
        }

        public static ConvolutionFilter Blur5x5Filter
        {
            get
            {
                return new ConvolutionFilter("Blur5x5Filter",
                    new double[,]
                    {
                        {0, 0, 1, 0, 0,},
                        {0, 1, 1, 1, 0,},
                        {1, 1, 1, 1, 1,},
                        {0, 1, 1, 1, 0,},
                        {0, 0, 1, 0, 0,},
                    }, 1.0 / 13.0);
            }
        }

        public static ConvolutionFilter Gaussian3x3BlurFilter
        {
            get
            {
                return new ConvolutionFilter("Gaussian3x3BlurFilter",
                    new double[,]
                    {
                        {1, 2, 1,},
                        {2, 4, 2,},
                        {1, 2, 1,},
                    }, 1.0 / 16.0);
            }
        }

        public static ConvolutionFilter Gaussian5x5BlurFilter
        {
            get
            {
                return new ConvolutionFilter("Gaussian5x5BlurFilter",
                    new double[,]
                    {
                        {2, 04, 05, 04, 2,},
                        {4, 09, 12, 09, 4,},
                        {5, 12, 15, 12, 5,},
                        {4, 09, 12, 09, 4,},
                        {2, 04, 05, 04, 2,},
                    }, 1.0 / 159.0);
            }
        }

        public static ConvolutionFilter MotionBlurFilter
        {
            get
            {
                return new ConvolutionFilter("MotionBlurFilter",
                    new double[,]
                    {
                        {1, 0, 0, 0, 0, 0, 0, 0, 1,},
                        {0, 1, 0, 0, 0, 0, 0, 1, 0,},
                        {0, 0, 1, 0, 0, 0, 1, 0, 0,},
                        {0, 0, 0, 1, 0, 1, 0, 0, 0,},
                        {0, 0, 0, 0, 1, 0, 0, 0, 0,},
                        {0, 0, 0, 1, 0, 1, 0, 0, 0,},
                        {0, 0, 1, 0, 0, 0, 1, 0, 0,},
                        {0, 1, 0, 0, 0, 0, 0, 1, 0,},
                        {1, 0, 0, 0, 0, 0, 0, 0, 1,},
                    }, 1.0 / 18.0);
            }
        }

        public static ConvolutionFilter MotionBlurLeftToRightFilter
        {
            get
            {
                return new ConvolutionFilter("MotionBlurLeftToRightFilter",
                    new double[,]
                    {
                        {1, 0, 0, 0, 0, 0, 0, 0, 0,},
                        {0, 1, 0, 0, 0, 0, 0, 0, 0,},
                        {0, 0, 1, 0, 0, 0, 0, 0, 0,},
                        {0, 0, 0, 1, 0, 0, 0, 0, 0,},
                        {0, 0, 0, 0, 1, 0, 0, 0, 0,},
                        {0, 0, 0, 0, 0, 1, 0, 0, 0,},
                        {0, 0, 0, 0, 0, 0, 1, 0, 0,},
                        {0, 0, 0, 0, 0, 0, 0, 1, 0,},
                        {0, 0, 0, 0, 0, 0, 0, 0, 1,},
                    }, 1.0 / 9.0);
            }
        }

        public static ConvolutionFilter MotionBlurRightToLeftFilter
        {
            get
            {
                return new ConvolutionFilter("MotionBlurRightToLeftFilter",
                    new double[,]
                    {
                        {0, 0, 0, 0, 0, 0, 0, 0, 1,},
                        {0, 0, 0, 0, 0, 0, 0, 1, 0,},
                        {0, 0, 0, 0, 0, 0, 1, 0, 0,},
                        {0, 0, 0, 0, 0, 1, 0, 0, 0,},
                        {0, 0, 0, 0, 1, 0, 0, 0, 0,},
                        {0, 0, 0, 1, 0, 0, 0, 0, 0,},
                        {0, 0, 1, 0, 0, 0, 0, 0, 0,},
                        {0, 1, 0, 0, 0, 0, 0, 0, 0,},
                        {1, 0, 0, 0, 0, 0, 0, 0, 0,},
                    }, 1.0 / 9.0);
            }
        }

        public static ConvolutionFilter SoftenFilter
        {
            get
            {
                return new ConvolutionFilter("SoftenFilter",
                    new double[,]
                    {
                        {1, 1, 1,},
                        {1, 1, 1,},
                        {1, 1, 1,},
                    }, 1.0 / 8.0);
            }
        }
    }
}
