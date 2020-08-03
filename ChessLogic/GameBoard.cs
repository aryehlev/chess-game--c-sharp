namespace GameBoard
{
    class GameBoard
    {
        private const int k_SizeOfBoard = 8;
        private Peice[,] m_PeicesOnBoard;

        public GameBoard()
        {
            m_PeicesOnBoard = new Peice[k_SizeOfBoard,k_SizeOfBoard];
        }
    }
}
