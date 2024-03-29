using InterfaceCustomer;
using MiddleLayer;
using Unity;
using Unity.Injection;
using ValidationStrategies;

namespace FactoryCustomer
{
    public static class Factory
    {
        private static IUnityContainer? custs = null;
        
        public static ICustomer Create(int typeCust)
        {
            if (custs==null)
            {
                custs = new UnityContainer();
                custs.RegisterType<ICustomer,Customer>(typeCust.ToString(),new InjectionConstructor(new CustomerValidationAll()));
                custs.RegisterType<ICustomer, Lead>(typeCust.ToString(), new InjectionConstructor(new LeadValidation())); 
            }
             
            return custs.Resolve<ICustomer>(typeCust.ToString());
        }
    }
}
