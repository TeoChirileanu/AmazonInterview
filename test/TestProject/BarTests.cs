using NFluent;
using NUnit.Framework;
using SourceProject;

namespace TestProject
{
    public class BarTests
    {
        [Test]
        public void CaseOne()
        {
            // Arrange
            var bar = new Bar();

            // Act
            var minimumDays = Bar.MinimumDays(5, 5, new[,]
            {
                {1, 0, 0, 0, 0},
                {0, 1, 0, 0, 0},
                {0, 0, 1, 0, 0},
                {0, 0, 0, 1, 0},
                {0, 0, 0, 0, 1}
            });

            // Assert
            Check.That(minimumDays).IsEqualTo(4);
        }

        [Test]
        public void CaseTwo()
        {
            // Arrange

            // Act

            // Assert
        }
    }
}