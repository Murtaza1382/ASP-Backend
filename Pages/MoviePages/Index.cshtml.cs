using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASP_RazorPagesMovie.Models;

namespace ASP_RazorPagesMovie.Pages.MoviePages;

public class IndexModel : PageModel
{
    private readonly ASP_RazorPagesMovieContext _context;

    public IndexModel(ASP_RazorPagesMovieContext context)
    {
        _context = context;
    }

    public IList<Movie> Movie { get; set; } = default!;

    public async Task OnGetAsync()
    {
        Movie = await _context.Movie.ToListAsync();
    }
}
