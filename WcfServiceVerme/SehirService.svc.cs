using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceVerme
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SehirService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SehirService.svc or SehirService.svc.cs at the Solution Explorer and start debugging.
    public class SehirService : ISehirService
    {
        public List<SehirBilgi> SehirGetir()
        {
            var Sehirler = new List<SehirBilgi>() {
                new SehirBilgi{Id = 1, SehirAdi="Ankara"},
                new SehirBilgi{Id = 2, SehirAdi="İstanbul"},
                new SehirBilgi{Id = 3, SehirAdi="İzmir"},
                new SehirBilgi{Id = 5, SehirAdi="Adana"}
            };
            return Sehirler;
        }
    }


    public class SehirBilgi
    {
        public int Id { get; set; }
        public string SehirAdi { get; set; }
    }
}
