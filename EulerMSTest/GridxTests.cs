using EulerLib;

namespace EulerMSTest
{
    /// <summary>
    /// Tests for Gridx class
    /// </summary>
    [TestClass]
    [TestCategory("Gridx")]
    public class GridxTests
    {
        /// <summary>
        /// Test for max product of consecutive numbers - any direction
        /// </summary>
        [TestMethod]
        public void TestMaxProduct()
        {
            int[,] grid1 = new int[,]
            {
                {5,2,3,0,0,1 },
                {5,2,1,0,0,0 },
                {2,1,2,0,0,0 },
                {1,0,0,0,0,0 }
            };

            int[,] grid2 = new int[,]
            {
                {1,3,2,2,1,1 },
                {2,1,1,0,1,5 },
                {3,1,2,2,5,2 },
                {3,0,0,2,0,2 }
            };

            int[,] grid3 = new int[,]
            {
                {1,3,2,1,0,3 },
                {1,1,1,1,1,5 },
                {1,2,2,0,1,1 },
                {1,1,2,5,5,2 }
            };

            int[,] grid4 = new int[,]
            {
                {1,3,2,1,0,0 },
                {1,1,3,1,1,5 },
                {1,2,2,0,2,5 },
                {1,0,0,1,1,2 }
            };
            List<int[,]> testGrids = [grid1, grid2, grid3, grid4];

            foreach (int[,] grid in testGrids)
            {
                Gridx igrid = new Gridx(grid);
                long largestProduct = igrid.LargestProduct(3);
                Assert.AreEqual(50, largestProduct);
            }
        }

        /// <summary>
        /// Test greatest product of consecutive numbers - vertical
        /// </summary>
        [TestMethod]
        public void TestVertical()
        {
            int[,] grid1 = new int[,]
            {
                {5,2,3,0,0,1 },
                {5,2,1,0,0,0 },
                {2,1,2,0,0,0 },
                {1,0,0,0,0,0 }
            };

            int[,] grid2 = new int[,]
            {
                {1,3,2,2,1,1 },
                {2,1,1,0,1,0 },
                {5,1,2,2,0,2 },
                {5,0,0,0,0,0 }
            };

            int[,] grid3 = new int[,]
            {
                {1,3,2,1,0,5 },
                {1,1,1,1,1,5 },
                {1,2,2,0,1,2 },
                {1,1,2,0,0,2 }
            };

            int[,] grid4 = new int[,]
            {
                {1,3,2,1,0,0 },
                {1,1,3,1,1,5 },
                {1,2,2,0,2,5 },
                {1,0,0,1,1,2 }
            };

            List<int[,]> testGrids = [grid1, grid2, grid3, grid4];

            foreach (int[,] grid in testGrids)
            {
                Gridx igrid = new Gridx(grid);
                long largestProduct = igrid.LargestProduct(3);
                Assert.AreEqual(50, largestProduct);
            }
        }

        /// <summary>
        /// Test greatest diagonal product of consecutive numbers - horizontal numbers
        /// </summary>
        [TestMethod]
        public void TestHorizontal()
        {
            int[,] grid1 = new int[,]
            {
                {5,2,5,0,0,1 },
                {1,2,1,0,0,0 },
                {2,1,2,0,0,0 },
                {1,0,0,0,0,0 }
            };

            int[,] grid2 = new int[,]
            {
                {1,3,2,2,5,5 },
                {1,1,1,0,1,0 },
                {1,1,2,2,0,2 },
                {1,0,0,0,0,0 }
            };

            int[,] grid3 = new int[,]
            {
                {1,3,2,1,0,0 },
                {1,1,1,1,1,0 },
                {1,2,2,0,1,2 },
                {5,5,2,0,0,2 }
            };

            int[,] grid4 = new int[,]
            {
                {1,3,2,1,0,0 },
                {1,1,3,1,1,1 },
                {1,2,2,0,2,2 },
                {1,0,0,5,5,2 }
            };

            List<int[,]> testGrids = [ grid1, grid2, grid3, grid4 ];

            foreach (int[,] grid in testGrids)
            {
                Gridx igrid = new Gridx(grid);
                long largestProduct = igrid.LargestProduct(3);
                Assert.AreEqual(50, largestProduct);
            }
        }

        /// <summary>
        /// Test greatest product of consecutive numbers - diagonal - upper right to lower left
        /// </summary>
        [TestMethod]
        public void TestDiagUpperRightToLowerLeft()
        {
            int[,] grid1 = new int[,]
            {
                {1,3,5,0,0,5,1 },
                {1,5,1,0,0,0,1 },
                {2,1,2,0,0,0,1 },
                {1,0,0,0,0,0,1 }
            };

            int[,] grid2 = new int[,]
            {
                {1,3,2,1,0,1,5 },
                {1,1,1,0,1,5,1 },
                {1,1,2,2,2,2,1 },
                {1,0,0,0,0,0,1 }
            };

            int[,] grid3 = new int[,]
            {
                {1,3,2,1,0,0,1 },
                {1,1,5,1,1,0,1 },
                {1,2,2,0,1,2,1 },
                {5,0,0,0,0,2,1 }
            };

            int[,] grid4 = new int[,]
            {
                {1,3,2,1,0,0,1 },
                {1,1,3,1,1,2,5 },
                {1,2,2,0,2,2,1 },
                {1,0,0,1,5,2,1 }
            };

            List<int[,]> testGrids = [ grid1, grid2, grid3, grid4 ];

            foreach (int[,] grid in testGrids)
            {
                Gridx igrid = new Gridx(grid);
                long largestProduct = igrid.LargestDiagonalProductUpperRightToLowerLeft(3);
                Assert.AreEqual(50, largestProduct);
            }    
        }

        /// <summary>
        /// Test greatest product of consecutive numbers - diagonal - upper left to lower right
        /// </summary>
        [TestMethod]
        public void TestDiagUpperLeftToLowerRight()
        {
            int[,] grid1 = new int[,]
            {
                {5,3,2,0,0,0,1 },
                {1,5,1,0,0,0,1 },
                {1,1,2,0,0,0,1 },
                {1,0,0,0,0,0,1 }
            };

            int[,] grid2 = new int[,]
            {
                {1,3,2,1,5,0,1 },
                {1,1,1,0,1,5,1 },
                {1,1,2,0,0,2,2 },
                {1,0,0,0,0,0,1 }
            };

            int[,] grid3 = new int[,]
            {
                {1,3,2,0,0,0,1 },
                {5,1,1,0,0,0,1 },
                {1,2,2,0,0,0,1 },
                {1,0,5,0,0,0,1 }
            };

            int[,] grid4 = new int[,]
            {
                {1,3,2,0,0,0,1 },
                {1,1,1,2,2,0,1 },
                {1,1,2,0,1,5,1 },
                {1,0,0,0,0,1,5 }
            };

            List<int[,]> testGrids = [grid1, grid2, grid3, grid4];

            foreach (int[,] grid in testGrids)
            {
                Gridx igrid = new Gridx(grid);
                long largestProduct = igrid.LargestDiagonalProductUpperLeftToLowerRight(3);
                Assert.AreEqual(50, largestProduct);
            }
        }
    }
}
