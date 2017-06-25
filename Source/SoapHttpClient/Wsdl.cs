using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace SoapHttpClient
{
    public struct SoapFuncArgs
    {
        public XElement Body;
        public XElement Header;
    }

    class WsdlOperation
    {
        public string Name;
    }
    class WsdlPort
    {
        public string Name;
        public Uri Endpoint;
    }
    class WsdlService
    {
        public string Name;
        public Dictionary<string,WsdlPort> Ports;
    }
    public class Wsdl
    {
        readonly XDocument wsdl;
        public Wsdl(XDocument wsdl) {
            this.wsdl = wsdl ?? throw new ArgumentNullException("wsdl");
        }

        public SoapFuncArgs CallFunc(string functionName, object args) {
            return new SoapFuncArgs();
        }
    }
}