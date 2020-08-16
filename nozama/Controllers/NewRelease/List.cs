using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using nozama.Service.Book;
using System.Collections.Generic;

namespace nozama.Controllers.NewRelease
{
    [ApiController]
    public class List : Controller
    {
        private readonly ILogger<List> _logger;
        private readonly IMapper _mapper;
        private readonly IBookService _service;

        public List(ILogger<List> logger, IMapper mapper, IBookService service)
        {
            _logger = logger;
            _mapper = mapper;
            _service = service;
        }

        [HttpGet("/NewReleases/")]
        public ListNewReleasesResponse ListNewReleases()
        {
            // log it
            _logger.LogInformation("NewReleases");
            // get it           
            var books = _service.Factory<BookService.NewReleasesAction>().GetNewReleases();
            // transform it
            var model = _mapper.Map<List<ListNewReleaseModel>>(books);
            // return it
            return new ListNewReleasesResponse()
            {
                NewReleases = model
            };
        }
    }
}
