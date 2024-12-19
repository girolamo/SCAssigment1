using System.Collections.Concurrent;
using SCAssigment1.Entities;
using SCAssigment1.Providers;

namespace SCAssigment1
{
    public class WordsCounter(IContentEntitiesProvider<IContentEntity> contentProvider)
    {
        public ConcurrentDictionary<string, int> Count()
        {
            var wordsOccurence = new ConcurrentDictionary<string, int>();

            Parallel.ForEach(contentProvider.GetEntities(), contentEntity =>
            {
                var text = contentEntity.GetText();
                var splitedWords = text.Split([' ', '\t', '\r', '\n'], StringSplitOptions.RemoveEmptyEntries);

                foreach (var separatedWord in splitedWords)
                {
                    wordsOccurence.AddOrUpdate(separatedWord, 1, (key, oldValue) => oldValue + 1);
                }
            });

            return wordsOccurence;
        }
    }
}
