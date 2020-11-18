using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
     public class CustomerRepository
     {
          public CustomerRepository()
          {
               addressRepository = new AddressRepository();
          }

          private AddressRepository addressRepository { get; set; }

          /// <summary>
          /// Retrieve one customer.
          /// </summary>
          /// <param name="customerId"></param>
          /// <returns></returns>
          public Customer Retrieve(int customerId)
          {
               // Create the instnce of customer class
               // Pass in the requestd ID
               Customer customer = new Customer(customerId);

               // Code that retrieves the defined customer

               //Temp hard-coded values to return
               // a populated customer
               if (customerId == 1)
               {
                    customer.EmailAddress = "fbaggins@hobbiton.me";
                    customer.FirstName = "Frodo";
                    customer.LastName = "Baggins";
                    customer.AddressList = addressRepository.RetrieveByCustomerID(customerId).ToList();
               }

               return customer;
          }

          /// <summary>
          /// Saves the current customer.
          /// </summary>
          /// <param name="customer"></param>
          /// <returns></returns>
          public bool Save(Customer customer)
          {
               // Code that save the passed customer

               return true;
          }
     }
}
