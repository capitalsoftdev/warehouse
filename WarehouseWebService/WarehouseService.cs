using Logger;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WarehouseWebService
{
    [DataContract(Namespace = "http://schemas.capitalsoft.am/api/soap/2017/08/22")]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall,
                    ConcurrencyMode = ConcurrencyMode.Multiple)]
    public partial class WarehouseService : IWarehouseService
    {       
        public static void SetLogger(ILogger logger)
        {  
           WarehouseBL.LoggerBL.Logger = logger;
        }
    }
}
