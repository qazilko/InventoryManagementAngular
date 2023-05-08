using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace InventoryManagementAngular.Models
{
    public class registration
    {

        
        public int? ID
        {
            get; set;
        }

       
        public string name
        {
            get; set;
        }

        public string fname
        {
            get; set;
        }

        public DateTime dob
        {
            get; set;
        }
        public string email { get; set; }
        //public string password { get; set; }        
        //public string role { get; set; }
        public double mobileno
        {
            get; set;
        }
        public string qualification
        {
            get; set;
        }

        public string address
        {
            get; set;
        }

        public string city
        {
            get; set;
        }
        public string state
        {
            get; set;
        }

        public int zipcode
        {
            get; set;
        }

    }
}
