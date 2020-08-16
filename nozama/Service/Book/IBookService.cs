namespace nozama.Service.Book
{
    public interface IBookService
    {
        T Factory<T>() where T : ServiceAction, new();
    }
}
