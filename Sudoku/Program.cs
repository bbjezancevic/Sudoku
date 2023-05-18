using System;

namespace SudokuSolver
{
    class Program
    {
        public static void Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();

            //int[,] zagonetka = new int[,] {
            //{ 0, 0, 0, 0, 3, 8, 0, 4 },
            //{ 0, 6, 0, 4, 0, 7, 0, 8 },
            //{ 0, 1, 0, 0, 4, 0, 0, 0 },
            //{ 8, 7, 5, 0, 0, 2, 0, 0 },
            //{ 0, 0, 1, 0, 0, 0, 3, 5 },
            //{ 0, 2, 3, 0, 0, 5, 0, 7 },
            //{ 2, 0, 8, 0, 0, 0, 7, 3 },
            //{ 0, 0, 0, 0, 0, 0, 2, 0 }
            //};

            //int[,] zagonetka = new int[,] {
            //{ 0, 0, 0, 0, 0, 0, 0, 0 },
            //{ 0, 0, 0, 0, 0, 0, 0, 0 },
            //{ 0, 0, 0, 0, 0, 0, 0, 0 },
            //{ 0, 0, 0, 0, 0, 0, 0, 0 },
            //{ 0, 0, 0, 0, 0, 0, 0, 0 },
            //{ 0, 0, 0, 0, 0, 0, 0, 0 },
            //{ 0, 0, 0, 0, 0, 0, 0, 0 },
            //{ 0, 0, 0, 0, 0, 0, 0, 0 }
            //};

            int[,] zagonetka = new int[,] {
            { 0, 0, 0, 0, 0, 0, 0, 0, 1 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 2 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 3 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 4 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 5 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 6 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 7 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 8 },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 }
            };

            Sudoku sudoku = new Sudoku();
            sudoku.Zagonetka = zagonetka;

            sudoku.IspisiSudoku();
            Console.Write("______________________ \n\n");

            if (sudoku.RijesiSudoku())
            {
                sudoku.IspisiSudoku();
            }
            else
            {
                Console.Write("Nema rješenja");
            }


            watch.Stop();
            Console.WriteLine("\n" + watch.ElapsedMilliseconds + "ms");
        }
    }
}