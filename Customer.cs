using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOP1_Scheduling_Application
{
    public  class Customer
    {
        public int CustomerID { get; set; }

        public string CustomerName { get; set; }

        public int AddressID  {get; set;}

        public bool Active { get; set; }

        public DateTime CreateDate { get; set; }

        public string CreatedBy { get; set; }

        public DateTime LastUpdate { get; set; }

        public string LastUpdatedBy { get; set; }

        public string Address { get; set; }

        public string ZipCode { get; set; }

        public string PhoneNumber { get; set; }

        public Customer(int customerId, string customerName, int addressId, bool active, 
            DateTime createDate, string createdBy, DateTime lastUpdated, string lastUpdatedBy, string address, string zipcode, string phonenumber)
        {
            CustomerID = customerId;
            CustomerName = customerName;
            AddressID = addressId;
            Active = active;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdated;
            LastUpdatedBy = lastUpdatedBy;
            Address = address;
            ZipCode = zipcode;
            PhoneNumber = phonenumber;
        }
    
        public Customer(int customerID , int addressID, string customerName, bool active, string address, string zipcode, string phonenumber, DateTime lastUpdate, string lastUpdatedBy)
        {
            CustomerID = customerID;
            AddressID = addressID;
            CustomerName = customerName;
            Active = active;
            Address = address;
            ZipCode = zipcode;
            PhoneNumber = phonenumber;
            LastUpdate = lastUpdate;
            LastUpdatedBy = lastUpdatedBy;
        }
    }
}
