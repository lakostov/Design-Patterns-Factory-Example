using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiddleLayer;

namespace FactoryCustomer
{
    public static class Factory //DP Simple Factory pattern
    {
        private static Dictionary<string, CustomerBase> custs = new Dictionary<string, CustomerBase>();
       
        public static CustomerBase Create(string TypeCustomer)
        {
            //DP Lazy loading
            if (custs.Count == 0)
            {
                custs.Add("Customer", new Customer());
                custs.Add("Lead", new Lead());
            }
                //DP RIP pattern Return if with polymorphism
                return custs[TypeCustomer];
        }
    }
}
