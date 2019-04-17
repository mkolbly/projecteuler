using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerLib
{
    /// <summary>
    /// Class representing an Array of Integers
    /// </summary>
    /// <remarks>
    /// 
    /// Note: The coordinate system has x going up->down and y going left->right
    ///       Here, we'll use i,j where i will traverse the up-down axis and j will
    ///       traverse the left-right axis instead of x,y
    ///       
    ///         j0 j1 j2
    ///         ____________
    ///     i0 |
    ///     i1 |
    ///     i2 |
    /// 
    /// </remarks>
    public class Gridx
    {
        /// <summary>Our integer array</summary>
        private int[,] igrid;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="grid">Array grid</param>
        public Gridx(int[,] igrid)
        {
            this.igrid = igrid;
        }

        /// <summary>
        /// Grid height (i-axis)
        /// </summary>
        public int Height
        {
            get
            {
                return this.igrid.GetLength(0);    
            }
        }

        /// <summary>
        /// Grid width (j-axis)
        /// </summary>
        public int Width
        {
            get
            {
                return this.igrid.GetLength(1);
            }
        }

        /// <summary>
        /// For our 2x2 grid of integers, find the greatest product of adjacent numbers
        /// in any direction - up, down, left, right, or diagonally
        /// </summary>
        public long LargestProduct(int lenAdjacentNumbers)
        {

            long largest1 = this.LargestDiagonalProductUpperRightToLowerLeft(lenAdjacentNumbers);

            long largest2 = this.LargestDiagonalProductUpperLeftToLowerRight(lenAdjacentNumbers);

            long largest3 = this.LargestHorizontalProduct(lenAdjacentNumbers);

            long largest4 = this.LargestVerticalProduct(lenAdjacentNumbers);

            List<long> largests = new List<long>() { largest1, largest2, largest3, largest4 };

            long largest = largests.Max();

            return largest;         
        }


        /// <summary>
        /// For our 2x2 grid of integers, find the greatest product of adjacent numbers
        /// in the diagonal direction (upper-right to lower-left) aka (lower-left to upper-right)
        /// </summary>
        /// <param name="lenAdjacentNumbers">How many adjacent integers to multiply</param>
        /// <returns>Greatest diagonal product</returns>
        private long LargestDiagonalProductUpperRightToLowerLeft(int lenAdjacentNumbers)
        {
            int width = this.Width;
            int height = this.Height;
            long largestProduct = 0;

            if ((width >= lenAdjacentNumbers) && (height >= lenAdjacentNumbers))
            {
                // upper-right to lower-left
                for (int j = (lenAdjacentNumbers -1); j < width; j++)
                {
                    for (int i = 0; i <= (height - lenAdjacentNumbers); i++)
                    {
                        long product = 1;
                        for (int l = 0; l < lenAdjacentNumbers; l++)
                        {
                            product *= igrid[i + l, j - l];
                        }
                        if (product > largestProduct)
                            largestProduct = product;
                    }
                }
            }

            return largestProduct;
        }


        /// <summary>
        /// For our 2x2 grid of integers, find the greatest product of adjacent numbers
        /// in the diagonal direction (upper-right to lower-left) aka (lower-left to upper-right)
        /// </summary>
        /// <param name="lenAdjacentNumbers">How many adjacent integers to multiply</param>
        /// <returns>Greatest diagonal product</returns>
        private long LargestDiagonalProductUpperLeftToLowerRight(int lenAdjacentNumbers)
        {
            int width = this.Width;
            int height = this.Height;
            long largestProduct = 0;

            if ((width >= lenAdjacentNumbers) && (height >= lenAdjacentNumbers))
            {
                // upper-left to lower-right
                for (int j = 0; j <= (width - lenAdjacentNumbers); j++)
                {
                    for (int i = 0; i <= (height - lenAdjacentNumbers); i++)
                    {
                        long product = 1;
                        for (int l = 0; l < lenAdjacentNumbers; l++)
                        {
                            product *= igrid[i + l, j + l];
                        }
                        if (product > largestProduct)
                            largestProduct = product;
                    }
                }

            }

            return largestProduct;
        }


        /// <summary>
        /// For our 2x2 grid of integers, find the greatest product of adjacent numbers
        /// in the horizontal direction
        /// </summary>
        /// <param name="lenAdjacentNumbers">How many adjacent integers to multiply</param>
        /// <returns>Greatest horizontal product</returns>
        private long LargestHorizontalProduct(int lenAdjacentNumbers)
        {
            int width = this.Width;
            int height = this.Height;
            long largestProduct = 0;

            if (width >= lenAdjacentNumbers)
            {
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j <= (width - lenAdjacentNumbers); j++)
                    {
                    
                        long product = 1;
                        for (int l = 0; l < lenAdjacentNumbers; l++)
                        {
                            product *= igrid[i, j + l];
                        }

                        if (product > largestProduct)
                            largestProduct = product;
                    }
                }
            }

            return largestProduct;
        }



        /// <summary>
        /// For our 2x2 grid of integers, find the greatest product of adjacent numbers
        /// in the vertical direction
        /// </summary>
        /// <param name="lenAdjacentNumbers">How many adjacent integers to multiply</param>
        /// <returns>Greatest vertical product</returns>
        private long LargestVerticalProduct(int lenAdjacentNumbers)
        {
            int width = this.Width;
            int height = this.Height;
            long largestProduct = 0;

            if (height >= lenAdjacentNumbers)
            {
                for (int j = 0; j < width; j++)  //
                {
                    for (int i = 0; i <= (height - lenAdjacentNumbers); i++)
                    {
                        long product = 1;
                        for (int l = 0; l < lenAdjacentNumbers; l++)
                        {
                            product *= igrid[i + l, j];
                        }

                        if (product > largestProduct)
                            largestProduct = product;
                    }
                }
            }

            return largestProduct;
        }
    }
}
