using System;

namespace ConsoleApp2
{
    internal class SquareMatrix
    {
        private int n;
        private int a;
        private int b;
        private int[,] matrix;

        public int N
        {
            get => n;
            set => n = value;
        }

        public int A
        {
            get => a;
            set => a = value;
        }

        public int B
        {
            get => b;
            set => b = value;
        }

        public SquareMatrix(int n, int a, int b)
        {
            this.n = n;
            this.a = a;
            this.b = b;
            FillMatrix();
        }

        private void FillMatrix()
        {
            matrix = new int[n, n];
            Random rnd = new Random();
            int row = 0;
            while (row < n)
            {
                int col = 0;
                while (col < n)
                {
                    matrix[row, col] = rnd.Next(a, b + 1);
                    col++;
                }
                row++;
            }
        }

        public void ShowMatrix()
        {
            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    Console.Write($"{matrix[r, c],4} ");
                }
                Console.WriteLine();
            }
        }

        public int GetOddNumberCount()
        {
            int totalOdds = 0;
            foreach (int val in matrix)
            {
                if (val % 2 != 0)
                {
                    totalOdds++;
                }
            }
            return totalOdds;
        }
    }
}
