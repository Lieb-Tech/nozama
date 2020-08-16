using AutoMapper;
using nozama.Repository.Book;

namespace nozama.Controllers.NewRelease
{
    public class ListNewReleasesProfile : Profile
    {
        public ListNewReleasesProfile()
        {
            CreateMap<NewReleaseQueryModel, ListNewReleaseModel>();
        }
    }
}
