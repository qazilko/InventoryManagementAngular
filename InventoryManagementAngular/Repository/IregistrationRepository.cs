using InventoryManagementAngular.Models;

namespace InventoryManagementAngular.Repository
{
    public interface IregistrationRepository
    {
        public IEnumerable<registration> Getregistrations();
        public IEnumerable<registration> GetRegistrationById(int Id);
        public string InsertUpdateRegistration(int id, registration data);
       // public string UpdateRegistration(int id, registration data);
        public string DeleteRegistration(int id);

    }
}
