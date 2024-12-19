using SCAssigment1.Entities;

namespace SCAssigment1.Providers
{
    internal class ContentEnttiesFromFiles : IContentEntitiesProvider<FileContentEntity>
    {
        public IEnumerable<FileContentEntity> GetEntities()
        {
            var workingDirectory = Directory.GetCurrentDirectory();
            var txtFilesPaths = Directory.GetFiles(workingDirectory, "*.txt");
            if (txtFilesPaths.Length <= 0)
            {
                throw new FileNotFoundException($"No *.txt files found in directory: {workingDirectory}");
            }

            return txtFilesPaths.Select(txtFilePath => new FileContentEntity(txtFilePath));
        }
    }
}
