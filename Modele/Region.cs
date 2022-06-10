using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Modele
{
    /// <summary>
    /// cette classe contient les regions qui peuvent etre attribuées a une recette
    /// </summary>
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
