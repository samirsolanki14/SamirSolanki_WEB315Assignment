using Microsoft.EntityFrameworkCore;
using RazorPagesMusic.Models;

namespace RazorPagesMusic.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMusicContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesMusicContext>>()))
            {
                if (context == null || context.Music == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMusicContext");
                }

                // Look for any movies.
                if (context.Music.Any())
                {
                    return;   // DB has been seeded
                }

                context.Music.AddRange(
                    new Music
                    {
                        NameofArtists = "Lucky Ali",
                        MusicReleaseDate = DateTime.Parse("1988-2-12"),
                        MusicGenre = "Music",
                        Review = 7.99M
                    },

                    new Music
                    {
                        NameofArtists = "Sonu ",
                        MusicReleaseDate = DateTime.Parse("1984-3-13"),
                        MusicGenre = "Music",
                        Review = 8.99M
                    },

                    new Music
                    {
                        NameofArtists = "Uditnarayan",
                        MusicReleaseDate = DateTime.Parse("1986-2-23"),
                        MusicGenre = "Music",
                        Review = 9.99M
                    },

                    new Music
                    {
                        NameofArtists = "Bruno mars",
                        MusicReleaseDate = DateTime.Parse("1959-4-15"),
                        MusicGenre = "Western",
                        Review = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}