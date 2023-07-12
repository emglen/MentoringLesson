using KNLibrary;

static void Main(string[] args)
{
   Player playerX = new Player("PlayerX", 'x');
   Player playerO = new Player("PlayerO", 'o');
   var gameBoard = new GameBoard();
   bool gameFinish = false;
   bool nextPlayer = true;

   var board = gameBoard.CreateGameBoard();
   int number = 0;

   while (!gameFinish)
   {
      if (nextPlayer)
      {
         Console.WriteLine("{playerX.name} please enter number 1-9: ");
         var input = Console.ReadLine();
         number = Convert.ToChar(input);
         if (!gameBoard.IsValidField(board, number))
         {
            Console.WriteLine("Field used. Please enter new field");
            Console.WriteLine("Actual game board");
            gameBoard.ActualGameBoard(board);
         }
         else
         {
            board[number - 1] = playerX.gameSymbol;
            Console.WriteLine("Actual game board/n");
            gameBoard.ActualGameBoard(board);
            if (gameBoard.WinCheck(board, playerX.gameSymbol))
            {
               Console.WriteLine($"Player {playerX.name} wins!");
               gameFinish = true;
            }
            else
            {
               nextPlayer = false;
            }
         }
      }
      else
      {
         Console.WriteLine($"playerO.name}} please enter number 1-9: ");
         var input = Console.ReadLine();
         number = Convert.ToChar(input);
         if (!gameBoard.IsValidField(board, number))
         {
            Console.WriteLine("Field used. Please enter new field");
            Console.WriteLine("Actual game board");
            gameBoard.ActualGameBoard(board);
            break;
         }
         else
         {
            board[number - 1] = playerO.gameSymbol;
            Console.WriteLine("Actual game board/n");
            gameBoard.ActualGameBoard(board);
            if (gameBoard.WinCheck(board, playerO.gameSymbol))
            {
               Console.WriteLine($"Player {playerO.name} wins!");
               gameFinish = true;
            }
            else
            {
               nextPlayer = true;
            }
         }
      }
   }
}