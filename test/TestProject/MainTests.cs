using NUnit.Framework;
using SourceProject;

namespace TestProject
{
    public class MainTests
    {
        [Test]
        public void ShouldTestSomething()
        {
            // Arrange
            var main = new Main();

            // Act
            main.Foo();

            // Assert
            Assert.Pass();
        }
    }
}