using InterfaceCustomer;

namespace MiddleLayer
{
    public class CustomerBase : ICustomer
    {
        private IValidation<ICustomer>? _validation = null;
        public CustomerBase(IValidation<ICustomer> obj)
        {
            _validation = obj;
        }
        public string? CustomerName { get; set; }
        public string? PhoneNumber { get; set; }
        public decimal BillAmount { get; set; }
        public DateTime BillDate { get; set; }
        public string? Address { get; set; }
        public virtual void Validate()
        {
            _validation?.Validate(this);
        }
    }
    public class Customer : CustomerBase
    {
        public Customer(IValidation<ICustomer> obj):base(obj)
        {
                
        }
    }

    public class Lead : CustomerBase
    {
        public Lead(IValidation<ICustomer> obj) : base(obj)
        {
            
        }
    }

}
