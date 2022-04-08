using Xunit;


namespace CustomHashTableShould
{
    public class CustomHashTableShould
    {


        [Fact]
        public void Doublethink_Test()
        {
            // Arrange
            int a = 2;
            int b = 2;
            int expected = 5;
            // Act
            int actual = a + b;
            // Assert
            Assert.Equal(expected, actual + 1);
        }

        [Fact]
        public void Entry_Constructor_Test()
        {
            // Arrange
            Entry testEntry = new Entry("a", "b");
            // Act
            
            // Assert
            
        }
    }
}