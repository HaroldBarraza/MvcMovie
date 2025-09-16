using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Rating = "R", 
                    Price = 7.99M
                },
                new Movie
                {
                    Title = "Ghostbusters ",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Rating = "R", 
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Rating = "R", 
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Rating = "R", 
                    Price = 3.90M
                },
                new Movie
                {
                    Title = "The Godfather",
                    ReleaseDate = DateTime.Parse("1972-3-24"),
                    Genre = "Crime, Drama",
                    Rating = "R",
                    Price = 4.99M
                },
                new Movie
                {
                    Title = "Inception",
                    ReleaseDate = DateTime.Parse("2010-7-16"),
                    Genre = "Action, Sci-Fi, Thriller",
                    Rating = "PG-13",
                    Price = 5.99M
                },
                new Movie
                {
                    Title = "Parasite",
                    ReleaseDate = DateTime.Parse("2019-5-30"),
                    Genre = "Drama, Thriller",
                    Rating = "R",
                    Price = 6.99M
                },
                new Movie
                {
                    Title = "Mad Max: Fury Road",
                    ReleaseDate = DateTime.Parse("2015-5-15"),
                    Genre = "Action, Adventure, Sci-Fi",
                    Rating = "R",
                    Price = 4.49M
                },
                new Movie
                {
                    Title = "La La Land",
                    ReleaseDate = DateTime.Parse("2016-12-9"),
                    Genre = "Comedy, Drama, Music",
                    Rating = "PG-13",
                    Price = 5.49M
                }
            );
            context.SaveChanges();
        }
    }
}