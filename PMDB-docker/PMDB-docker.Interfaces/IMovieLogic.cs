﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PMDB_docker.Models;

namespace PMDB_docker.Interfaces
{
    public interface IMovieLogic
    {
        MovieDto GetMovie(int Id);
        List<MovieDto> GetAllMovies();
        MovieDto Add(MovieDto movie);
        List<MovieDto> GetAllMoviesForListPage();
        List<MovieDto> RemoveMovie(MovieDto movie);
        void UpdateMovie(MovieDto movie);
        string FormatRuntime(int? runtime);
        void UpdateGenres(List<GenreDto> genres, int movieId);
    }
}
