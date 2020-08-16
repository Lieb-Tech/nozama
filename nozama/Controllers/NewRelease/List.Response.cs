using nozama.Repository.Book;
using System.Collections.Generic;

namespace nozama.Controllers.NewRelease
{
    public class ListNewReleasesResponse
    {
        public List<ListNewReleaseModel> NewReleases { get; set; } 
    }
}
