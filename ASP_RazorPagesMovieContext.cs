using Microsoft.EntityFrameworkCore;

public class ASP_RazorPagesMovieContext(DbContextOptions<ASP_RazorPagesMovieContext> options) : DbContext(options)
{
    public DbSet<ASP_RazorPagesMovie.Models.Movie> Movie { get; set; } = default!;
}
