#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMusic.Models;

    public class RazorPagesMusicContext : DbContext
    {
        public RazorPagesMusicContext (DbContextOptions<RazorPagesMusicContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMusic.Models.Music> Music { get; set; }
    }
