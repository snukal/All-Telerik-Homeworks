using System;
using System.Linq;

class FillTheMatrix
{
    static void PrintMatrix(int[,] matrix, int n)
    {
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int columns = 0; columns < matrix.GetLength(1); columns++)
            {
                Console.Write("{0,-4}", matrix[rows, columns]);
            }
            Console.WriteLine();
        }
    }


    static void Main()
    {
        Console.Write("Please, enter number for n: ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];

        Console.Write("Please, choice in which case would you want to fill the matrix (A, B, C): ");
        char choice = char.Parse(Console.ReadLine());

        switch (choice)
        {
            case 'A':

                for (int columns = 0, index = 1; columns < matrix.GetLength(1); columns++)
                {
                    for (int rows = 0; rows < matrix.GetLength(0); rows++, index++)
                    {
                        matrix[rows, columns] = index;
                    }
                }

                PrintMatrix(matrix, n);
                break;


            case 'B':

                for (int columns = 0; columns < matrix.GetLength(1); columns++)
                {
                    for (int rows = 0; rows < matrix.GetLength(0); rows++)
                    {
                        if (columns % 2 == 0)
                        {
                            matrix[rows, columns] = rows + 1 + (columns * n);
                        }
                        else
                        {
                            matrix[n - 1 - rows, columns] = rows + 1 + (columns * n);
                        }
                    }
                }
                PrintMatrix(matrix, n);
                break;

            case 'C':

                int value = 1;
                // fill matrix under the main diagonal
                for (int i = n - 1; i >= 0; i--)
                {
                    int rows = i;
                    int columns = 0;
                    while (rows < n && columns < n)
                    {
                        matrix[rows, columns] = value;
                        rows++;
                        columns++;
                        value++;
                    }
                }
                // fill matrix over the main diagonal
                for (int j = 1; j < n; j++)
                {
                    int rows = 0;
                    int columns = j;
                    while (rows < n && columns < n)
                    {
                        matrix[rows, columns] = value;
                        rows++;
                        columns++;
                        value++;
                    }
                }

                PrintMatrix(matrix, n);
                break;
        }
    }

}