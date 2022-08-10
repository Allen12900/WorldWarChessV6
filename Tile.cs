using System;
using System.Collections.Generic;
using System.Text;

namespace WorldWarChessV6
{
    public class Tile
    {
        private readonly int[] position;

        public Tile(string piece, string colour, int x, int y)
        {
            this.Piece = piece;
            this.Colour = colour;
            position = new int[2];
            position[0] = x;
            position[1] = y;
        }

        public string Piece { get; set; }

        public int X
        {
            get => position[0];
            set => position[0] = value;
        }

        public int Y
        {
            get => position[1];
            set => position[1] = value;
        }

        public string Colour { get; set; }
    }
}
