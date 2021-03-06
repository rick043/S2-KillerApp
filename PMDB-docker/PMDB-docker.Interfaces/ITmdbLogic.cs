﻿using System;
using System.Collections.Generic;
using System.Text;
using PMDB_docker.Models;
using TMDbLib.Objects.Credit;
using TMDbLib.Objects.General;
using TMDbLib.Objects.Movies;

namespace PMDB_docker.Interfaces
{
    public interface ITmdbLogic
    {
        MovieDto UpdateMovie(MovieDto movie);
        //string UpdateTitle(string title);
        //string UpdateOverview(string overview);
        //string UpdatePosterPath(string image);
        //int? UpdateRuntime(int? runtime);
        //DateTime? UpdateReleaseDate(DateTime? releaseDate);
        //string UpdateWebSite(string website);
        //long? UpdateBudget(long? budget);
        //int UpdateRevenue(int revenue);
        //string UpdateStatus(string status);
        //string UpdatePosterBackdrop(string posterBackdrop);
        //double? UpdateAverageRating(double? averageRating);

        // TODO: Implement following methods
        List<GenreDto> UpdateGenre(List<Genre> genres);
        List<ProductionCompany> UpdateProductionCompanies(List<ProductionCompany> productionCompanies);
        List<RoleDto> UpdatePeopleMovie(List<Credits> credits);
        PeopleDto UpdatePeople(int tmdbId);
        List<ReviewDto> GetReviews(int tmdbId);
        List<VideosDto> GetVideos(int tmdbId);
        List<ImageDto> GetBackdrops(int tmdbId);
        List<ImageDto> GetPosters(int tmdbId);
    }
}
