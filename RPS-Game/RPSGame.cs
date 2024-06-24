
namespace RPS_Game
{
    public class RPSGame
    {
        public Player player;
         public AIPlayer aiPlayer;

        public RPSGame()
        {
            player = new Player("Player");
            aiPlayer = new AIPlayer();
        }

        public void PlayGame()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors!");

            try
            {
                while(player.Score < 3 && aiPlayer.Score < 3)
                {
                    string playerMove = player.ChooseMove();
                    while (playerMove != "rock" && playerMove != "paper" && playerMove != "scissors")
                    {
                        Console.WriteLine($"Invalid input!");
                        playerMove = player.ChooseMove();
                    }
                    string aiMove = aiPlayer.ChooseMove();

                    Console.WriteLine($"Player chose: {playerMove}");
                    Console.WriteLine($"AI chose: {aiMove}");

                    string result = CompareMoves(playerMove, aiMove);
                    Console.WriteLine(result);

                    Console.WriteLine($"Player score: {player.Score}");
                    Console.WriteLine($"AI score: {aiPlayer.Score}");
                    Console.WriteLine();
                }


                if(player.Score > aiPlayer.Score)
                    Console.WriteLine("Player wins!");
                else if(player.Score < aiPlayer.Score)
                    Console.WriteLine("AI wins!");
                else
                    Console.WriteLine("It's a tie!");
            }
            catch(Exception ex)
            {
                Console.WriteLine("An error occurred during gameplay:");
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }

        public string CompareMoves(string playerMove, string aiMove)
        {
            if( playerMove == aiMove)
            {
                return "It's a tie!";
            }

            if(  (playerMove == "rock" && aiMove == "scissors") ||
                 (playerMove == "paper" && aiMove == "rock") ||
                 (playerMove == "scissors" && aiMove == "paper"))
            {
                player.Score++;
                return "Player wins the round!";
            }

            aiPlayer.Score++;
            return "AI wins the round!";
        }
        public void UpdateScores(string winner)
        {
            if(winner == "Player")
                player.Score++;
            else if(winner == "AI")
                aiPlayer.Score++;
        }


    }
}
