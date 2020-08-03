using System.Drawing;

namespace GameBoard
{
    abstract class Peice
    {
        private Point m_LocationOnBoard;
        private readonly bool r_IsWhite;

        protected Peice(Point i_LocationOnBoard, bool i_IsWhite)
        {
            m_LocationOnBoard = i_LocationOnBoard;
            r_IsWhite = i_IsWhite;
        }

        public bool IsLegalPeiceMove(Point i_NewPoint)
        {
            return  i_NewPoint.X >= 0 && i_NewPoint.X <= 7 && i_NewPoint.Y >= 0 && i_NewPoint.Y <= 7;
        }

        public Point LocationOnBoard
        {
            get => m_LocationOnBoard;
            set => m_LocationOnBoard = value;
        }
        public bool IsWhite
        {
            get => r_IsWhite;
        }
    }
}
