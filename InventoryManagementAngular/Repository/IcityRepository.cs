using InventoryManagementAngular.Models;

namespace InventoryManagementAngular.Repository
{
    public interface IcityRepository
    {
        public IEnumerable<city> Getcitys();
        public city GetcityById(int Id);

        //public string InsertCity(city data);
        public string InsertUpdateCity(int id, city data);
        public string DeleteCity(int id);
    }
}
