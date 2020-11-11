using CsvHelper;
using Movie_API.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_API.Data
{
    public class DataManager
    {
        private List<Movie> movies = null;
        private void loadMovies()
        {
            var appRoot = AppContext.BaseDirectory.Substring(0, AppContext.BaseDirectory.LastIndexOf("\\bin"));
            //appRoot = appRoot.Substring(0, appRoot.LastIndexOf("") + 1);
            using (var reader = new StreamReader($"{appRoot}\\Data\\metadata.csv"))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    movies = csv.GetRecords<Movie>().ToList();
                }
            }
        }

        public List<Movie> getMovieById(int id)
        {
            List<Movie> movieList = new List<Movie>();
            if(movies == null)
            {
                loadMovies();
            }
            movieList = movies.Where(m => m.MovieId == id)
                .GroupBy(m => m.Language)
                .Select(m => m.LastOrDefault())
                .OrderBy(m => m.Language)
                .ToList();
            return movieList;
        }
    }
}
