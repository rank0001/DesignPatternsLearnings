using MiddleLayer;

namespace FactoryCustomer
{
    public static class Factory
    {
        private static Dictionary<int, CustomerBase> custs = new Dictionary<int, CustomerBase>();
        public static CustomerBase Create(int typeCust)
        {
            if (custs.Count == 0)
            {
                custs.Add(1, new Customer());
                custs.Add(2, new Lead());
            }

            return custs[typeCust];
        }
    }
}
