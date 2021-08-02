using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using GUSRestAPI.GusReference;

namespace GUSRestAPI.Services
{
    public class GusService
    {
        public string Get(string id)
        {
            var binding = new WSHttpBinding();

            binding.Security.Mode = SecurityMode.Transport;
            binding.MessageEncoding = WSMessageEncoding.Mtom;
            binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.None;

            var ea = new EndpointAddress("https://wyszukiwarkaregontest.stat.gov.pl/wsBIR/UslugaBIRzewnPubl.svc");
            var cc = new GusReference.UslugaBIRzewnPublClient(binding, ea);

            string sid = cc.Zaloguj("abcde12345abcde12345");
            return sid;
        }
    }
}