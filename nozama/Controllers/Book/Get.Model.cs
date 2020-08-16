
namespace nozama.Controllers.Book
{
    public class GetBookModel
    {
        public long BookID { get; set; }
        public string Title { get; set; }
        public string Synopsis { get; set; }

        public int Reviews { get; set; }
        public int NumStars { get; set; }

        public long AuthorID{ get; set; }
        public string AuthorName { get; set; }
    }
}
