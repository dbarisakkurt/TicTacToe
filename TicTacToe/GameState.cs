namespace TicTacToe
{
    public enum GameResult
    {
        OnGoing,
        Player1Won,
        Player2Won,
        Draw
    }

    public class GameState
    {
        private const int _boardSize = 3;
        private string[,] _board = new string[_boardSize, _boardSize];
        private string _nextPlay = "x";

        public void Reset()
        {
            _nextPlay = "x";
            _board = new string[_boardSize, _boardSize];
        }

        public GameResult GetGameResult()
        {
            GameResult result = GameResult.OnGoing;


            if (CheckAllCellsUsed())
            {
                result = GameResult.Draw;
            }
            else if (CheckPlayerWon("x"))
            {
                result = GameResult.Player1Won;
            }
            else if (CheckPlayerWon("o"))
            {
                result = GameResult.Player2Won;
            }

            return result;
        }

        public void UpdateCell(int x, int y)
        {
            _board[x, y] = _nextPlay;

            if(_nextPlay == "x")
            {
                _nextPlay = "o";
            }
            else
            {
                _nextPlay = "x";
            }
        }

        public string GetCell(int x, int y)
        {
            return _board[x, y];
        }

        private bool CheckAllCellsUsed()
        {
            for (int i = 0; i < _boardSize; i++)
            {
                for (int j = 0; j < _boardSize; j++)
                {
                    if (_board[i, j] == null)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private bool CheckPlayerWon(string input)
        {
            if (_board[0, 0] == input && _board[1, 1] == input && _board[2, 2] == input)
            {
                return true;
            }
            if (_board[0, 2] == input && _board[1, 1] == input && _board[2, 0] == input)
            {
                return true;
            }


            if (_board[0, 0] == input && _board[0, 1] == input && _board[0, 2] == input)
            {
                return true;
            }
            if (_board[1, 0] == input && _board[1, 1] == input && _board[1, 2] == input)
            {
                return true;
            }
            if (_board[2, 0] == input && _board[2, 1] == input && _board[2, 2] == input)
            {
                return true;
            }

            if (_board[0, 0] == input && _board[1, 0] == input && _board[2, 0] == input)
            {
                return true;
            }
            if (_board[0, 1] == input && _board[1, 1] == input && _board[2, 1] == input)
            {
                return true;
            }
            if (_board[0, 2] == input && _board[1, 2] == input && _board[2, 2] == input)
            {
                return true;
            }

            return false;
        }
    }
}
