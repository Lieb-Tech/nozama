using System;

namespace nozama.Repository.Book
{
    public class BookByIDQueryModel
    {
        public long BookID { get; set; }
        public string BookTitle { get; set; }
        public string CoverArtUrl { get; set; }
        public DateTime Added { get; set; }
        public string Synopsis { get; set; }

        public long AuthorID { get; set; }
        public string AuthorName { get; set; }

        public int Reviews { get; set; }
        public int NumStarts { get; set; }

    }
}
