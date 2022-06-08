using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Modele
{
    [DataContract]
    public enum Region
    {
        [EnumMember]
        Nord,
        [EnumMember]
        Nordest,
        [EnumMember]
        Sud,
        [EnumMember]
        Sudest,
        [EnumMember]
        CentreOuest
    }
}
