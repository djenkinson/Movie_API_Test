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
    [Route("[controller]/stats")]
    public class MoviesController : ControllerBase
    {
        private readonly ILogger<MoviesController> _logger;
        private DataManager dm = new DataManager();

        public MoviesController(ILogger<MoviesController> logger)
        {
            _logger = logger;
        }


        [HttpGet()]
        public List<MovieStats> Get(int movieid = 1)
        {
            List<MovieStats> movieStatsList = dm.getMovieStats();

            return movieStatsList;
        }
    }
}
