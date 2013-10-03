using System;
using Proxy.ExampleService;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Class Reference.cs is the proxy
            ServiceClient serviceProxy = new ServiceClient();

            var getDataResult = serviceProxy.GetData(1);
            Console.WriteLine("GetData() returned: {0}", getDataResult);


            var getDataUsingDataContractResult = serviceProxy.GetDataUsingDataContract(new CompositeType
             {
                 BoolValue = true,
                 ExtensionData = null,
                 StringValue = "Hello Composite"
             });

            Console.WriteLine("GetDataUsingDataContract() returned: {0}",
                getDataUsingDataContractResult.StringValue);

            Console.ReadKey();
        }
    }
}
