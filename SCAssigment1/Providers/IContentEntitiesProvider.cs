using SCAssigment1.Entities;

namespace SCAssigment1.Providers
{
    public interface IContentEntitiesProvider<out T> where T : class, IContentEntity
    {
        public IEnumerable<T> GetEntities();
    }
}
