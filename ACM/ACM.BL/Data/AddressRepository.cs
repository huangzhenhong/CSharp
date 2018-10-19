using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL.Data
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId) {

            Address address = new Address(addressId);
            if (addressId == 1) {
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "Bagshot row";
                address.City = "Hobbiton";
                address.State = "Shire";
                address.Country = "Middle Earth";
                address.PostalCode = "144";
            }
            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId) {
            var addressList = new List<Address>();

            Address address1 = new Address(1)
            {
                StreetLine1 = "Bag End",
                StreetLine2 = "Bagshot row",
                City = "Hobbiton",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "144"
            };
            addressList.Add(address1);

            Address address2 = new Address(2)
            {
                StreetLine1 = "Green Dragon",
                StreetLine2 = "",
                City = "Bywater",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "144"
            };
            addressList.Add(address2);

            return addressList;
        }

        public bool Save(Address address)
        {
            var success = true;

            if (address.HasChanges && address.IsValid)
            {
                if (address.IsNew)
                {

                }
                else
                {

                }
            }
            return success;
        }
    }
}
