using System.Collections.Concurrent;

namespace SCAssigment1
{
    public static class SolutionPrinter
    {
        public static void Print(this ConcurrentDictionary<string, int> words)
        {
            foreach (var word in words)
            {
                Console.WriteLine($"{word.Value}: {word.Key}");
            }
        }
    }
}
