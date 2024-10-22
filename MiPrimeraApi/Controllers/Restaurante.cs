namespace MiPrimeraApi.Controllers
{
    public class Restaurante
    {
        public int Id { get; set; }
        public string Name { get; set; }   
        public string Direccion {  get; set; }
        public double CostoComercial { get; set; }
        public Boolean Petfriendly { get; set; }
    }
}
