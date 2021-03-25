using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Movie_WebAPI_Application.Data;
using Microsoft.AspNetCore.Cors;
using Movie_WebAPI_Application.Models;
using Microsoft.EntityFrameworkCore;

namespace Movie_WebAPI_Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MoviePolicy")]
    public class MoviesController : ControllerBase
    {
        private readonly MoviesDbContext _context;

        public MoviesController(MoviesDbContext context)
        {
            _context = context;

        }

        // GET: api/Movies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movie>>> Get()
        {
            return await _context.Movies
            .ToListAsync();
        }
    }
}
