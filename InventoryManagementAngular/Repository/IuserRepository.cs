using InventoryManagementAngular.Models;

namespace InventoryManagementAngular.Repository
{
    public interface IuserRepository
    {
        public IEnumerable<user> Getusers();
        public user GetuserById(int Id);

        //public string Insertuser(user data);
        public string InsertUpdateuser(int id, user data);
        public string Deleteuser(int id);
    }
}
