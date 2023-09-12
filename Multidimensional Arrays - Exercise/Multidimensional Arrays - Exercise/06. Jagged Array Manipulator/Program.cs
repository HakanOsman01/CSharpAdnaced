namespace _06._Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[][]jaggedArray=ReadJaggedArray(n);
           AnalyzJaggedArray(jaggedArray);
            string command = Console.ReadLine();
            while(command != "End")
            {
                string[] tokens = command.Split().ToArray();
                string action = tokens[0];
                int row = int.Parse(tokens[1]);
                int colum = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);
                bool isValid = CheckIsValidRowAndColumIndex(jaggedArray, row, colum);
                if (isValid)
                {
                    if (action == "Add")
                    {
                        jaggedArray[row][colum] += value;
                    }
                    else
                    {
                        jaggedArray[row][colum] -= value;
                    }
                   
                }
                command = Console.ReadLine();
               
            }
            PrintJaggedArray(jaggedArray);

        }
        static double[][]ReadJaggedArray(int n)
        {
            double[][]jaggedArray=new double[n][];
            for (int row = 0; row < n; row++)
            {
                double[]currentRow=Console.ReadLine()
                  .Split()
                 .Select(double.Parse)
                 .ToArray();
                jaggedArray[row]=new double[currentRow.Length];
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    jaggedArray[row][col] = currentRow[col];
                }


            }
            return jaggedArray;
        }
        static bool CheckIsValidRowAndColumIndex(double[][] jaggedArray,int row,int colum)
        {
            bool isRowValid = true;
            if(row<0 || row >= jaggedArray.GetLength(0))
            {
                return false;
            }
            if (isRowValid)
            {
                if(colum<0 || colum >= jaggedArray[row].Length)
                {
                    return false;
                }
            }
            return true;

        }
        static void PrintJaggedArray(double[][] jaggedArray)
        {
            for (int row = 0; row < jaggedArray.GetLength(0); row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    Console.Write($"{jaggedArray[row][col]} ");
                }
                Console.WriteLine();
            }
        }
        static void AnalyzJaggedArray(double[][] jaggedArray)
        {
            for (int row = 0; row < jaggedArray.GetLength(0); row++)
            {
                if (row + 1 < jaggedArray.GetLength(0))
                {
                    int sizeFirstRow = jaggedArray[row].Length;
                    int sizeSecondRow = jaggedArray[row + 1].Length;
                    if (sizeFirstRow == sizeSecondRow)
                    {
                        for (int col = 0; col < jaggedArray[row].Length; col++)
                        {
                            jaggedArray[row][col] *= 2.00;
                            jaggedArray[row + 1][col] *= 2.00;
                        }
                    }
                    else
                    {
                        for (int col = 0; col < jaggedArray[row].Length; col++)
                        {
                            jaggedArray[row][col] /= 2.00;

                        }
                        for (int i = 0; i < jaggedArray[row + 1].Length; i++)
                        {
                            jaggedArray[row + 1][i] /= 2.00;
                        }

                    }
                }
            }
        }
    }
}