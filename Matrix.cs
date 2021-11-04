using System;

namespace Datastructures
{
    public class Matrix
    {

        // rotate a N x N matrix by 90 degrees in anti-clockwise direction
        /*
         *  Time Complexity: O(n*n), where n is side of array.  O(N2)
            A single traversal of the matrix is needed.
            Space Complexity: O(1). 
            As a constant space is needed
        */
        public void _rotateMatrix(int N, int[,] mat)
        {
            // consider all squares one by one
            for (int x = 0; x < N / 2; x++)
            {
                // consider elements in group of 4 incurrent square
                for (int y = x; y < N - x - 1; y++)
                {
                    // store current cell in temp variable
                    int temp = mat[x, y];

                    // move values from right to top
                    mat[x, y] = mat[y, N - 1 - x];

                    // move values from bottom to right
                    mat[y, N - 1 - x] = mat[N - 1 - x, N - 1 - y];

                    // move values from left to bottom
                    mat[N - 1 - x, N - 1 - y] = mat[N - 1 - y, x];

                    // assign temp to left
                    mat[N - 1 - y, x] = temp;
                }
            }
        }

        //rotate clockwise
        public void _rotateMatrix_Clockwise(int N, int[,] mat)
        {
            // consider all squares one by one
            for (int y = 0; y < N / 2; y++)
            {
                // consider elements in group of 4 incurrent square
                for (int x = y; x < N - y - 1; x++)
                {
                    // store current cell in temp variable
                    int temp = mat[y, x];

                    // move values from left to top
                    mat[y, x] = mat[x, N - 1 - y];

                    // move values from bottom to left
                    mat[x, N - 1 - y] = mat[N - 1 - y, N - 1 - x];

                    // move values from right to bottom
                    mat[N - 1 - y, N - 1 - x] = mat[N - 1 - x, y];

                    // assign temp to left
                    mat[N - 1 - x, y] = temp;
                }
            }
        }

        // print the rotated matrix
        public void _printMatrix(int N, int[,] mat)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                    Console.Write(" " + mat[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine();
        }
       
        /* Rotate Matrix: Given an image represented by an NxN matrix, where each pixel in the image is 4
         bytes, write a method to rotate the image by 90 degrees. Can you do this in place? */

        //rotate image sides : clockwise rotation
        public int[][] RoatateImageSides(int start, int end, int[][] _img)
        {
            for (int i = start; i <= end - 1; i++)
            {
                int offset = i - start;
                int temp = _img[start][i];
                _img[start][i] = _img[end - offset][start];
                _img[end - offset][start] = _img[end][end - offset];
                _img[end][end - offset] = _img[i][end];
                _img[i][end] = temp;
            }
            return _img;
        }

        //rotate image
        public int[][] RotateImage(int[][] inputImage)
        {
            for (int i = 0; i < inputImage.Length / 2; i++)
            {
                inputImage = RoatateImageSides(i, inputImage.Length - i - 1, inputImage);
            }
            return inputImage;
        }

        public void DisplayRotatedImage(int[][] imgMatrix)
        {
            int length = imgMatrix[0].Length;
            for (int i = 0; i < length; i++)
            {
                string a = "";
                for (int j = 0; j < length; j++)
                {
                    a += imgMatrix[i][j] + " ";
                }
                Console.WriteLine(a);
            }
        }

        // Write an algorithm such that if an element in an MxN matrix is 0, its entire row and column is set to 0 
        public void _setMatrixZero(int [][] matrix)
        {
            int m = matrix.Length;
            int n = matrix[0].Length;
            bool [] zeroM = new bool[m];
            bool [] zeroN = new bool[n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        zeroM[i] = true;
                        zeroN[j] = true;
                    }
                }
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (zeroM[i] || zeroN[j])
                        matrix[i][j] = 0;
                }
            }
        }

    }
}
