using System;
using System.Collections.Generic;
using System.Text;

namespace WorldWarChessV6
{
    class Board
    {
        private readonly Tile[,] board;
        private readonly int size = 10;

        public Board(int size)
        {
            this.size = size;
            board = new Tile[size, size];

            for (int i = 0; i < size - 1; i = i + 2)
            {
                for (int j = 1; j < size; j = j + 2)
                {
                    board[i, j] = new Tile("", "Black", i, j);
                    board[i, j - 1] = new Tile("", "White", i, j - 1);
                }
            }

            for (int i = 1; i < size; i = i + 2)
            {
                for (int j = 1; j < size; j = j + 2)
                {
                    board[i, j] = new Tile("", "White", i, j);
                    board[i, j - 1] = new Tile("", "Black", i, j - 1);
                }
            }
        }

        public void PrintBoard()
        {
            /*for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (board[i, j].Colour == "White")
                    {
                        Console.Write(board[i, j].Colour + " ");
                    }
                    else if (board[i, j].Colour == "Black")
                    {
                        Console.Write(board[i, j].Colour + " ");
                    }
                }
                Console.WriteLine("\n\n");
            }*/

        }
    }
}
