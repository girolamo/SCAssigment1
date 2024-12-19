namespace SCAssigment1.Entities
{
    internal class FileContentEntity(string path) : IContentEntity
    {
        public string GetText()
        {
            using var reader = new StreamReader(path);
            var text = File.ReadAllText(path);

            return text;
        }
    }
}
