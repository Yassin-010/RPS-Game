using RPS_Game;


namespace RPSGameTests
{
    public class UnitTest1
    {
        [Fact]
        public void CompareMoves_PlayerWins_ReturnsPlayerWins()
        {
            // Arrange
            RPSGame game = new RPSGame();

            // Act
            string result = game.CompareMoves("rock", "scissors");

            // Assert
            Assert.Equal("Player wins the round!", result);
        }

        [Fact]
        public void CompareMoves_AIWins_ReturnsAIWins()
        {
            // Arrange
            RPSGame game = new RPSGame();

            // Act
            string result = game.CompareMoves("paper", "scissors");

            // Assert
            Assert.Equal("AI wins the round!", result);
        }

        [Fact]
        public void CompareMoves_Tie_ReturnsTie1()
        {
            // Arrange
            RPSGame game = new RPSGame();

            // Act
            string result = game.CompareMoves("rock", "rock");

            // Assert
            Assert.Equal("It's a tie!", result);
        }
        [Fact]
        public void CompareMoves_Tie_ReturnsTie2()
        {
            // Arrange
            RPSGame game = new RPSGame();

            // Act
            string result = game.CompareMoves("paper", "paper");

            // Assert
            Assert.Equal("It's a tie!", result);
        }
        [Fact]
        public void CompareMoves_Tie_ReturnsTie3()
        {
            // Arrange
            RPSGame game = new RPSGame();

            // Act
            string result = game.CompareMoves("scissors", "scissors");

            // Assert
            Assert.Equal("It's a tie!", result);
        }

        [Fact]
        public void UpdateScores_PlayerWins_ScoresUpdatedCorrectly()
        {
            // Arrange
            RPSGame game = new RPSGame();
            game.player.Score = 1;
            game.aiPlayer.Score = 2;

            // Act
            game.UpdateScores("Player");

            // Assert
            Assert.Equal(2, game.player.Score);
            Assert.Equal(2, game.aiPlayer.Score);
        }

        [Fact]
        public void UpdateScores_AIWins_ScoresUpdatedCorrectly()
        {
            // Arrange
            RPSGame game = new RPSGame();
            game.player.Score = 2;
            game.aiPlayer.Score = 1;

            // Act
            game.UpdateScores("AI");

            // Assert
            Assert.Equal(2, game.player.Score);
            Assert.Equal(2, game.aiPlayer.Score);
        }

        [Fact]
        public void UpdateScores_Tie_ScoresRemainSame()
        {
            // Arrange
            RPSGame game = new RPSGame();
            game.player.Score = 2;
            game.aiPlayer.Score = 2;

            // Act
            game.UpdateScores("Tie");

            // Assert
            Assert.Equal(2, game.player.Score);
            Assert.Equal(2, game.aiPlayer.Score);
        }
    }
}