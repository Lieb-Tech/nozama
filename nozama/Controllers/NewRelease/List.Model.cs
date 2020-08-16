using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nozama.Controllers.NewRelease
{
    public class ListNewReleaseModel
    {
        public long BookID { get; set; }
        public string BookTitle { get; set; }
        public string CoverArtUrl { get; set; }

        public long AuthorID { get; set; }
        public string AuthorName { get; set; }

        public int Reviews { get; set; }
        public int NumStarts { get; set; }
    }
}
