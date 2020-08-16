using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using nozama.Service.Book;

namespace nozama.Controllers.Book
{
    [ApiController]
    public class Get : Controller
    {
        private readonly ILogger<Get> _logger;
        private readonly IMapper _mapper;
        private readonly IBookService _service;

        public Get(ILogger<Get> logger, IMapper mapper, IBookService service)
        {
            _logger = logger;
            _mapper = mapper;
            _service = service;
        }

        [HttpGet("/Book/{ID}")]
        public GetBookResponse GetBook(long ID)
        {
            // log it
            _logger.LogInformation("GetBook");
            // get it           
            var book = _service.Factory<BookService.BookByIDAction>().BookByID(ID);
            // transform it
            var model = _mapper.Map<GetBookModel>(book);
            // return it
            return new GetBookResponse()
            {
                Book = model
            };
        }
    }
}
