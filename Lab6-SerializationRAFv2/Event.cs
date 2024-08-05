using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lab6_Serialization
{
    [Serializable]
    public class Event
    {
        public int eventNumber {get;set;}
        public string location {get;set;}
    }
}
