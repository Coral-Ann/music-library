namespace MusicLibrary.Repositories
{
    public interface IRepository<T>
    {
        public IEnumerable<T> GetAll();
    }
}