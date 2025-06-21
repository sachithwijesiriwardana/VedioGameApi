using Microsoft.EntityFrameworkCore;

namespace VedioGameApi.Data
{
    public class VideoGameDbContext(DbContextOptions<VideoGameDbContext>options):DbContext(options)
    {
        public DbSet<VedioGame> VideoGames => Set<VedioGame>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<VedioGame>().HasData(
                 new VedioGame
                 {
                     Id = 1,
                     Title = "Spider-Man 2",
                     Platform = "PS5",
                     Developer = "Insomniac Games",
                     Publisher = "Sony Interactive Entertainment"
                 },
                 new VedioGame
                 {
                     Id = 2,
                     Title = "God of War Ragnafdg",
                     Platform = "PS10",
                     Developer = "Santa Monicafhghg Studio",
                     Publisher = "Sony Interactive Entertainment"
                 },
                 new VedioGame
                 {
                     Id = 3,
                     Title = "Halo Infinite",
                     Platform = "Xbox Series X",
                     Developer = "343 Industries",
                     Publisher = "Xbox Game Studios"
                 },
                 new VedioGame
                 {
                     Id = 4,
                     Title = "The Legend of Zelda: Tears of the Kingdom",
                     Platform = "Nintendo Switch",
                     Developer = "Nintendo",
                     Publisher = "Nintendo"
                 }



                );

        }
    }
}
