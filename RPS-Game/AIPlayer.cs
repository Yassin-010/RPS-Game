
namespace RPS_Game
{
    public class AIPlayer : Player
    {
        private Random random;
        public AIPlayer() : base("AI")
        {
            random = new Random();
        }

        public override string ChooseMove()
        {
            string[] moves = { "rock", "paper", "scissors" };
            int index = random.Next(moves.Length);
            return moves[index];
        }
    }
}
