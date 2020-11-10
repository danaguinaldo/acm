using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
     public class Customer
     {
          public Customer()
          {

          }

          public Customer(int customerID)
          {
               CustomerID = customerID;
          }

          public int CustomerID { get; private set; }
          public string EmailAddress { get; set; }
          public string FirstName { get; set; }
          public string FullName
          {
               get
               {
                    string fullName = LastName;
                    if (!string.IsNullOrWhiteSpace(FirstName))
                    {
                         if (!string.IsNullOrWhiteSpace(fullName))
                         {
                              fullName += ", ";
                         }
                         fullName += FirstName;
                    }
                    return fullName;
               }
          }

          public static int InstanceCount { get; set; }
          private string _lastName;
          public string LastName {
               get
               {
                    return _lastName;
               }
               set
               {
                    _lastName = value;
               }
          }

          /// <summary>
          /// Retrieve one customer.
          /// </summary>
          /// <param name="customerID"></param>
          /// <returns></returns>
          public Customer Retrieve(int customerID)
          {
               // Code that retrieves the defined customer

               return new Customer();
          }

          /// <summary>
          /// Retrieve ALL customers.
          /// </summary>
          /// <returns></returns>
          public List<Customer> Retrieve()
          {
               // Code that retrieves all customers

               return new List<Customer>();
          }

          /// <summary>
          /// Saves the current Customer.
          /// </summary>
          /// <returns></returns>
          public bool Save()
          {
               // Code that saves the defined user.

               return true;
          }

          /// <summary>
          /// Validates the current customer.
          /// </summary>
          /// <returns></returns>
          public bool Validate()
          {
               var isValid = true;

               if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
               if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

               return isValid;
          }
    }
}
