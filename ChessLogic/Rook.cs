using System.Drawing;

namespace ChessLogic
{
    class Rook : ChessPeice
    {
        public Rook(Point i_LocationOnBoard, bool i_IsWhite)
            : base(i_LocationOnBoard, i_IsWhite)
        {
        }

        public override bool IsLegalPeiceMove(Point i_NewPoint)
        {
            bool isLegal = i_NewPoint.X == LocationOnBoard.X ^ i_NewPoint.Y == LocationOnBoard.Y;
            return base.IsLegalPeiceMove(i_NewPoint) && isLegal;
        }
    }
}
