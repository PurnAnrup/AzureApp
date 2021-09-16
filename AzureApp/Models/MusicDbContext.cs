using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureApp.Models
{
    public class MusicDbContext : DbContext
    {
        public DbSet<Music> Musics {get; set;}
        public MusicDbContext(DbContextOptions<MusicDbContext> options):base(options)
        {

        }
    }
}
