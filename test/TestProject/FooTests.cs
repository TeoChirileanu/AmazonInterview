using System.Collections.Generic;
using NFluent;
using NUnit.Framework;
using SourceProject;

namespace TestProject
{
    public class FooTests
    {
        [Test]
        public void CaseOne()
        {
            // Arrange
            var expectedFeature = new List<string> {"anacell", "betacellular"};
            var foo = new Foo();

            // Act
            var features = foo.PopularNFeatures(
                5,
                2,
                new List<string>
                {
                    "anacell", "betacellular", "cetracular", "deltacullar", "eurocell"
                },
                3,
                new List<string>
                {
                    "Best", "services", "provided", "by", "anacell", "betacellular", 
                    "has", "great", "services", "anacell", "provides", "much", "better", 
                    "services", "than", "all", "other"
                });

            // Assert
            Check.That(features).ContainsExactly(expectedFeature);
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