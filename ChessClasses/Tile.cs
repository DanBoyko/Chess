using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChessClasses;

namespace ChessClasses
{
    public class Tile
    {
        Piece? piece;
        int xcoord;
        int ycoord;

        public Tile(int x, int y, Piece? piece)
        {
            this.xcoord = x;
            this.ycoord = y;
            this.piece = piece;
        }

        public void RemovePiece(Piece piece)
        {
            this.piece = null;
        }

        public void AddPiece(Piece piece)
        {
            this.piece = piece;
        }

        public bool IsBlack(int xcoord, int ycoord)
        {
            return ((xcoord + ycoord) % 2) == 0;
        }
    }
}
