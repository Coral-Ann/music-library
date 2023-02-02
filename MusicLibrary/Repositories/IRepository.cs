namespace MusicLibrary.Repositories
{
    public interface IRepository<T>
    {
        public IEnumerable<T> GetAll();

        //I feel like we're gonna need more to this interface...

    }
}