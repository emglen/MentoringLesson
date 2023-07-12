namespace KNLibrary;

public class GameBoard
{
    public char[] CreateGameBoard()
    {
        var gameBoard= new[] {'1','2','3','4','5','6','7','8','9'};
        return gameBoard;
    }
    public void ActualGameBoard(char [] gameBoard)
    {
        Console.WriteLine(gameBoard[0] + " " + gameBoard[1] + " " + gameBoard[2]);
        Console.WriteLine(gameBoard[3] + " " + gameBoard[4] + " " + gameBoard[5]);
        Console.WriteLine(gameBoard[6] + " " + gameBoard[7] + " " + gameBoard[8]);
    }

    public bool WinCheck(char[] board, char symbol)
    {
        if ((board[0] == symbol && board[1] == symbol && board[2] == symbol) ||
            (board[3] == symbol && board[4] == symbol && board[5] == symbol) ||
            (board[6] == symbol && board[7] == symbol && board[8] == symbol) ||
            (board[0] == symbol && board[3] == symbol && board[6] == symbol) ||
            (board[1] == symbol && board[4] == symbol && board[7] == symbol) ||
            (board[2] == symbol && board[5] == symbol && board[8] == symbol) ||
            (board[0] == symbol && board[4] == symbol && board[8] == symbol) ||
            (board[2] == symbol && board[4] == symbol && board[6] == symbol))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool IsValidField(char[] board, int number)
    {
        if (board[number - 1] == number)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}