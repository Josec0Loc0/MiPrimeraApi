using API_PruebaSL.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MiPrimeraApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantesControler : ControllerBase
    {
        [HttpGet]
        [Route("InformacionRestaurante")]
        public ActionResult DevuelveRestaurante(int id)
        {
            RestauranteRepository repo = new RestauranteRepository();
            var restaurantes = repo.DevuelveRestaurantes();
            var info_restaurante = restaurantes.Find(x => x.Id == id);
            return Ok(info_restaurante);
        }



        [HttpGet]
        [Route("ListadoRestaurantes")]
        public List<Restaurante> DevuelveRestaurantes()
        {
            RestauranteRepository repo = new RestauranteRepository();
            return repo.DevuelveRestaurantes();
        }
    }
}
