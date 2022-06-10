using System;
using System.Runtime.Serialization;

namespace Modele
{
    /// <summary>
    /// represente les differentes unitées
    /// </summary>
    [DataContract]
    public enum Unité : short
    {
        [EnumMember]
        Inconnue,
        [EnumMember]
        KG,
        [EnumMember]
        G,
        [EnumMember]
        L,
        [EnumMember]
        DL,
        [EnumMember]
        CL,
        [EnumMember]
        ML,
        [EnumMember]
        UNITE
    }
}
