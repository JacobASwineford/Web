using Core.Contracts.Repository;
using Core.Contracts.Service;
using Microsoft.AspNetCore.Mvc;

namespace MovieShopAPI.Controllers
{
    [ApiController]
    [Route("user")]
    public class UserController : ControllerBase
    {
        IPurchasesServiceAsync purchase_service;
        IFavoriteServiceAsync favorite_service;

        public UserController(IPurchasesServiceAsync p, IFavoriteServiceAsync f)
        {
            purchase_service = p;
            favorite_service = f;
        }

        [HttpGet]
        [Route("purchases/{userId}")]
        public async Task<IActionResult> GetPurchases(int userId)
        {
            var r = await purchase_service.getPurchasesByUserId(userId);
            return Ok(r);
        }

        [HttpGet]
        [Route("favorites/{userId}")]
        public async Task<IActionResult> GetFavorites(int userId)
        {
            var r = await favorite_service.getFavoritesByUserId(userId);
            return Ok(r);
        }

        [HttpDelete]
        [Route("deleteP/{id}")]
        public async Task<IActionResult> DeletePurchase(int id)
        {
            var r = await favorite_service.deleteFavoritesById(id);
            return Ok(r);
        }

        [HttpDelete]
        [Route("deleteF/{id}")]
        public async Task<IActionResult> DeleteFavorite(int id)
        {
            var r = await favorite_service.deleteFavoritesById(id);
            return Ok(r);
        }
    }
}
