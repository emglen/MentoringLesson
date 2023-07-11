namespace KNLibrary;

public class GameBoard
{
    public string[,] CreateGameBoard()
    {
        string [,] gameBoard=
        {
            {"1","",""},
            {"","d",""},
            {"","","2"}
        };
        return gameBoard;
    }
    public void ActualGameBoard(string [,] gameBoard)
    {
        for (int i = 0; i<gameBoard.GetLength(0);i++)
        {
            for (int j =0; j<gameBoard.GetLength(1); j++)
            {
                Console.WriteLine(gameBoard[i,j]);
            }
        }
    }

    public bool WinnCheck(string[,] gameBoard)
    {
        return true;
    }
}