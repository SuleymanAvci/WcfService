using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceVerme
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "KurService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select KurService.svc or KurService.svc.cs at the Solution Explorer and start debugging.
    public class KurService : IKurService
    {
        public List<string> ParaBirimleriGetir()
        {
            List<string> paraBirimleriGetir = new List<string>();
            paraBirimleriGetir.Add("Dolar");
            paraBirimleriGetir.Add("Euro");
            paraBirimleriGetir.Add("Yen");

            return paraBirimleriGetir;
        }


        public List<double> KurlarGetir(string kurTipi)
        {
            Random random = new Random();
            List<double> kurlarListesi = new List<double>();
            for (int i = 0; i < 10; i++)
            {
                kurlarListesi.Add(random.NextDouble() + 2);
            }
            return kurlarListesi;
        }

    }
}
