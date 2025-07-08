using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        // Latitude, Longitude, Name of Taco Bell
        [Fact]
        public void ShouldReturnNonNullObject()
        {
            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);
        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        [InlineData("34.280205,-86.217115,Taco Bell Albertvill...", -86.217115)]
        [InlineData("32.92496,-85.961342,Taco Bell Alexander Cit...", -85.961342)]
        [InlineData("34.071477,-84.296345, Taco Bell Alpharett...", -84.296345)]
        [InlineData("34.047374,-84.223918, Taco Bell Alpharetta...", -84.223918)]
        [InlineData("34.039588,-84.283254, Taco Bell Alpharetta...", -84.283254)]
        //Add additional inline data. Refer to your CSV file.
        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete the test with Arrange, Act, Assert steps below.
            //       Note: "line" string represents input data we will Parse 
            //       to extract the Longitude.  
            //       Each "line" from your .csv file
            //       represents a TacoBell location

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var ITrackable = tacoParser.Parse(line);
            var actual = ITrackable.Location.Longitude;

            //Assert
            Assert.Equal(expected, actual);
        }


        //TODO: Create a test called ShouldParseLatitude
        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        [InlineData("34.280205,-86.217115,Taco Bell Albertvill...", 34.280205)]
        [InlineData("32.92496,-85.961342,Taco Bell Alexander Cit...", 32.92496)]
        [InlineData("34.071477,-84.296345, Taco Bell Alpharett...", 34.071477)]
        [InlineData("34.047374,-84.223918, Taco Bell Alpharetta...", 34.047374)]
        [InlineData("34.039588,-84.283254, Taco Bell Alpharetta...", 34.039588)]

        public void ShouldParseLatitude(string line, double expected)

        {
            var tacoParser = new TacoParser();

            var ITrackable = tacoParser.Parse(line);
            var actual = ITrackable.Location.Latitude;

            //figure out how to get a latitude from the iTrackable
            Assert.Equal(expected, actual);
        }
    }
}
