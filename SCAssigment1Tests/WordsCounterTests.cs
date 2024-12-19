using Moq;
using SCAssigment1;
using SCAssigment1.Entities;
using SCAssigment1.Providers;

namespace SCAssigment1Tests
{
    [TestFixture]
    public class WordsCounterTests
    { 
        private Mock<IContentEntity> mockContentEntity1;
        private Mock<IContentEntity> mockContentEntity2;
        private Mock<IContentEntitiesProvider<IContentEntity>> mockContentProvider;

        [SetUp]
        public void SetUp()
        {
            mockContentEntity1 = new Mock<IContentEntity>();
            mockContentEntity2 = new Mock<IContentEntity>();
            mockContentProvider = new Mock<IContentEntitiesProvider<IContentEntity>>();
        }

        [Test, TestCaseSource(typeof(TestContent.TestCases), nameof(TestContent.TestCases.Cases))]
        public void WordsCounter_ShouldBeConsistent_WhenInputsProvided(string text1, string text2, Dictionary<string, int> expected)
        {
            mockContentEntity1.Setup(x => x.GetText()).Returns(text1);
            mockContentEntity2.Setup(x => x.GetText()).Returns(text2);
            mockContentProvider.Setup(x => x.GetEntities()).Returns([mockContentEntity1.Object, mockContentEntity2.Object]);

            var wordsCounter = new WordsCounter(mockContentProvider.Object);
            var wordsOccurence = wordsCounter.Count();

            CollectionAssert.AreEquivalent(expected, wordsOccurence, TestContent.FailedTestMessage);
        }
    }
}
