using System;
using System.Collections.Generic;
using System.Drawing;

namespace ChessLogic
{
    class GameBoard
    {
        private const int k_SizeOfBoard = 8;
        private ChessPeice[,] m_Board;
        private HashSet<ChessPeice> m_ChessPeicesOnBoard;

        public GameBoard()
        {
            m_Board = new ChessPeice[k_SizeOfBoard,k_SizeOfBoard];
            Rook leftBlackRook = new Rook(new Point(0,0), false);
            m_Board[0, 0] = leftBlackRook;
            Rook rightBlackRook = new Rook(new Point(0, 7), false);
            m_Board[0, 7] = rightBlackRook;
            m_ChessPeicesOnBoard.Add(rightBlackRook);
            m_ChessPeicesOnBoard.Add(leftBlackRook);
        }

        public bool TryMovePeice(ChessPeice i_PeiceToMove, Point i_NewLocation)
        {
            if(!m_ChessPeicesOnBoard.Contains(i_PeiceToMove))
            {
                throw new ArgumentException("chesspeice not in board");
            }
            bool wasSuccess =  i_PeiceToMove.IsLegalPeiceMove(i_NewLocation);

            ChessPeice peiceInNewPoint = m_Board[i_NewLocation.X, i_NewLocation.Y];
            
            if (peiceInNewPoint != null)
            {
                if(peiceInNewPoint.IsWhite == i_PeiceToMove.IsWhite)
                {
                    wasSuccess = false;
                }
                else
                {
                    m_ChessPeicesOnBoard.Remove(peiceInNewPoint);
                }
            }

            if(wasSuccess)
            {
                m_Board[i_PeiceToMove.LocationOnBoard.X, i_PeiceToMove.LocationOnBoard.Y] = null;
                i_PeiceToMove.LocationOnBoard = new Point(i_NewLocation.X, i_NewLocation.Y);
            }

            return wasSuccess;
        }
    }
}
