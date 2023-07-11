using KNLibrary;

static void Main(string[] args)
{
   Player playerX = new Player("PlayerX", "x");
   Player playerY = new Player("PlayerY", "y");
   GameBoard gameBoard = new GameBoard();

   string[,] board = gameBoard.CreateGameBoard();
   board[0, 0] = "test";
   Console.WriteLine(board[0,0]);
   gameBoard.ActualGameBoard(board);

}