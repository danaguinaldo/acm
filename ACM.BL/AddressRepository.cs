﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
     public class AddressRepository
     {
          /// <summary>
          /// Retrieve one address.
          /// </summary>
          /// <param name="addressId"></param>
          /// <returns></returns>
          public Address Retrieve(int addressId)
          {
               // Create the instance of the Address class
               // Pass inthe requested Id
               Address address = new Address(addressId);

               // Code that retrieves the defined address

               // Temp hard code for return
               if (addressId == 1)
               {
                    address.AddressType = 1;
                    address.StreetLine1 = "Bag End";
                    address.StreetLine2 = "Bagshot row";
                    address.City = "Hobbiton";
                    address.State = "Shire";
                    address.Country = "Middle Earth";
                    address.PostalCode = "144";
               }

               return address;
          }

          public IEnumerable<Address> RetrieveByCustomerID(int customerId)
          {
               // Code that retireves the defined addresses
               // for the customer

               // Temp hard code for return
               var addressList = new List<Address>();

               Address address = new Address(1)
               {
                    AddressType = 1,
                    StreetLine1 = "Bag End",
                    StreetLine2 = "Bagshot row",
                    City = "Hobbiton",
                    State = "Shire",
                    Country = "Middle Earth",
                    PostalCode = "144"
               };
               addressList.Add(address);

               address = new Address(2)
               {
                    AddressType = 2,
                    StreetLine1 = "Green Dragon",
                    City = "Bywater",
                    State = "Shire",
                    Country = "Middle Earth",
                    PostalCode = "146"
               };

               return addressList;
          }

          /// <summary>
          /// Save current address.
          /// </summary>
          /// <returns></returns>
          public bool Save()
          {
               return true;
          }
     }
}
