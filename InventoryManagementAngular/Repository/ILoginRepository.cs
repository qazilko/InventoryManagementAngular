using InventoryManagementAngular.Models;

namespace InventoryManagementAngular.Repository
{
    public interface ILoginRepository
    {
        //public IEnumerable<Login> Getcitys();
        public Login LoginByEmail(string email,string password);

        //public string InsertCity(city data);
        //public string InsertUpdateCity(int id, city data);
        //public string DeleteCity(int id);
    }
}
