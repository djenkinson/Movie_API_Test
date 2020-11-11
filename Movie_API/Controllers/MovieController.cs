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
    [Route("[controller]/metadata")]
    public class MovieController : ControllerBase
    {
        private readonly ILogger<MovieController> _logger;
        private DataManager dm = new DataManager();


        public MovieController(ILogger<MovieController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{id}")]
        public List<Movie> GetMetadata(int id = 1)
        {
            List<Movie> movieList = dm.getMovieById(id);

            return movieList;
        }
    }
}
