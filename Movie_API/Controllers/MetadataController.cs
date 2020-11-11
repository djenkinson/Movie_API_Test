using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Movie_API.Data;
using Movie_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MetadataController : ControllerBase
    {
        private readonly ILogger<MetadataController> _logger;
        private DataManager dm = new DataManager();


        public MetadataController(ILogger<MetadataController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{movieid}")]
        public List<Movie> Get(int movieid = 1)
        {
            List<Movie> movieList = dm.getMovieById(movieid);

            return movieList;
        }
    }
}
