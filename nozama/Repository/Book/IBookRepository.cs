namespace nozama.Repository.Book
{
    public interface IBookRepository
    {
        T Factory<T>() where T : RepositoryCommandQuery, new();
    }
}
