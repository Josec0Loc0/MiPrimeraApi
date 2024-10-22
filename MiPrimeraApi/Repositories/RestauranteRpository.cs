using MiPrimeraApi.Modeld;
using MiPrimeraApi.Controllers;

namespace API_PruebaSL.Repositories
{
    public class RestauranteRepository
    {
        public List<Restaurante> DevuelveRestaurantes()
        {
            List<Restaurante> restaurantes = new List<Restaurante>();
            Restaurante restaurante = new Restaurante
            {
                Id = 1,
                Name = "McDonadls",
                CostoComercial = 100000,
                Direccion = "Orellana",
                Petfriendly = false
            };
            Restaurante restaurante2 = new Restaurante
            {
                Id = 1,
                Name = "McDonadls",
                CostoComercial = 100000,
                Direccion = "Orellana",
                Petfriendly = false
            };

            restaurantes.Add(restaurante);
            restaurantes.Add(restaurante2);
            return restaurantes;

        }
        public Restaurante DevuelveRestaurante()
        {
            Restaurante restaurante = new Restaurante()
            {
                Id = 1,
                Name = "McDonadls",
                CostoComercial = 100000,
                Direccion = "Orellana",
                Petfriendly = false
            };
            return restaurante;
        }
    }
}