using InterfaceCustomer;
using System.Net;

namespace ValidationStrategies
{
    public class CustomerValidationAll : IValidation<ICustomer>
    {
        public void Validate(ICustomer obj)
        {
            if (obj.CustomerName?.Length == 0)
            {
                throw new Exception("Customer name is required");
            }

            if (obj.PhoneNumber?.Length == 0)
            {
                throw new Exception("Phone Number is required");
            }

            if (obj.Address?.Length == 0)
            {
                throw new Exception("Address is required");
            }

            if (obj.BillAmount == 0)
            {
                throw new Exception("Bill Amount is required");
            }

            if (obj.BillDate > DateTime.Now)
            {
                throw new Exception("Invalid Bill Date");
            }
        }
    }

    public class LeadValidation : IValidation<ICustomer>
    {
        public void Validate(ICustomer obj)
        {
            if (obj.CustomerName?.Length < 10)
            {
                throw new Exception("Invalid Lead name Found!");
            }

            if (obj.PhoneNumber?.Length < 10)
            {
                throw new Exception("Invalid Lead Phone Number Found!");
            }
        }
    }
}
