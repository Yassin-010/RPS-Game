
namespace RPS_Game
{
    public class Player
    {
        public string Name { get; }
        public int Score { get; set; }

        public Player(string name)
        {
            Name = name;
            Score = 0;
        }

        public virtual string ChooseMove()
        {
            Console.WriteLine($"{Name}, choose your move (rock, paper, or scissors):");
            string move = Console.ReadLine().ToLower();
            return move;
        }
    }
}
