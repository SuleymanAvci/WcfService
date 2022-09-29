using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceVerme
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IKurService" in both code and config file together.
    [ServiceContract]
    public interface IKurService
    {
        [OperationContract]
        List<string> ParaBirimleriGetir();

        [OperationContract]
        List<double> KurlarGetir(string kurTipi);
    }
}
