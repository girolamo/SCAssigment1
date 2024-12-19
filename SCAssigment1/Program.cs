using SCAssigment1;
using SCAssigment1.Providers;

try
{
    var contentProvider = new ContentEnttiesFromFiles();
    var wordsCounter = new WordsCounter(contentProvider);
    var wordsOccurence = wordsCounter.Count();
    wordsOccurence.Print();
}
catch (FileNotFoundException e)
{
    Console.WriteLine(e.Message);
}
catch (Exception e)
{
    Console.WriteLine($"Unknown exception: {e.Message}");
}