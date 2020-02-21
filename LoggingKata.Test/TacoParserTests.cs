using System;
using Xunit;
using LoggingKata;


namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void IsNotNull()
        {
            TacoParser challenger = new TacoParser();
            var cells = "34.039588,-84.283254,Taco Bell Alpharetta/... (Free trial * Add to Cart for a full POI info)";
            Assert.NotNull(challenger.Parse(cells));
        }

        [Theory]
        [InlineData("34.039588,-84.283254,Taco Bell Alpharetta/... (Free trial * Add to Cart for a full POI info)", "Alpharetta")]
        [InlineData("32.072974,-84.222921,Taco Bell Americu... (Free trial * Add to Cart for a full POI info)", "Americu")]
        [InlineData("33.671982,-85.826674,Taco Bell Annisto... (Free trial * Add to Cart for a full POI info)", "Annisto")]
        [InlineData("34.324462,-86.503055,Taco Bell Ara... (Free trial * Add to Cart for a full POI info)", "Ara")]
        [InlineData("34.992219,-86.841402,Taco Bell Ardmore/... (Free trial * Add to Cart for a full POI info)", "Ardmore")]
        [InlineData("34.795116,-86.97191,Taco Bell Athens/... (Free trial * Add to Cart for a full POI info)", "Athens")]
        public void Parse(string line, string expected)
        {
            //Arrange
            TacoParser challenger = new TacoParser();
            //Act
            ITrackable actual = challenger.Parse(line);
            //Assert
            Assert.Equal(actual.Name, expected);
        }

        [Theory]
        [InlineData(null, null)]
        [InlineData("", null)]
        [InlineData("34.1234,-65.2345", null)]
        public void TacoParse(string line, ITrackable expected)
        {
            //Arrange
            TacoParser challenger = new TacoParser();
            //Act
            ITrackable actual = challenger.Parse(line);
            //Assert
            Assert.Equal(actual, expected);
        }
    }
}
