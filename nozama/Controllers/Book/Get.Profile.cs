using AutoMapper;
using nozama.Repository.Book;

namespace nozama.Controllers.Book
{
    public class GetProfile : Profile
    {
        public GetProfile()
        {
            CreateMap<BookByIDQueryModel, GetBookModel>()
                .ForMember(
                    dest => dest.Title,
                    opt => opt.MapFrom(src => src.BookTitle));
        }
    }
}
