using InventoryManagementAngular.Models;

namespace InventoryManagementAngular.Repository
{
    public interface IusersRepository
    {
        //public IEnumerable<users> Getcitys();
        public users usersByEmail(string email, string password);

        //public string InsertCity(city data);
        //public string InsertUpdateCity(int id, city data);
        //public string DeleteCity(int id);
    }
}
