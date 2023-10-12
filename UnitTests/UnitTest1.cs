using Hangman;
using Xunit;

namespace TestProject1
{
    public class GamePageTest
    {
        [Theory]
        [InlineData("Easy")]
        [InlineData("Medium")]
        [InlineData("Hard")]
        public void GamePageWordInitialization(string gameType)
        {
            GamePage gamePage = new GamePage(gameType);

            // Assert checking is string is Null or empty
            Assert.False(string.IsNullOrEmpty(gamePage.Word));
        }
    }
}   
