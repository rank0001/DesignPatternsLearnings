using MiddleLayer;
using Unity;

namespace FactoryCustomer
{
    public static class Factory
    {
        private static IUnityContainer? custs = null;
        
        public static CustomerBase Create(int typeCust)
        {
            if (custs==null)
            {
                custs = new UnityContainer();
                custs.RegisterType<CustomerBase,Customer>(typeCust.ToString());
                custs.RegisterType<CustomerBase, Lead>(typeCust.ToString()); 
            }
             
            return custs.Resolve<CustomerBase>(typeCust.ToString());
        }
    }
}
