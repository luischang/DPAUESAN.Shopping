using DPAUESAN.Shopping.DOMAIN.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DPAUESAN.Shopping.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavoriteController : ControllerBase
    {
        private readonly IFavoriteRepository _favoriteRepository;

        public FavoriteController(IFavoriteRepository favoriteRepository)
        {
            _favoriteRepository = favoriteRepository;
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetByUser(int userId)
        {
            var favorites = await _favoriteRepository.GetAll(userId);
            return Ok(favorites);
        }
    }
}
