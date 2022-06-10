using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    /// <summary>
    /// cette classe contient les types qui peuvent etre attribuées a une recette
    /// </summary>
    [DataContract]
    public enum Type
    {
        [EnumMember]
        Entree,
        [EnumMember]
        Plat,
        [EnumMember]
        Dessert
    }
}
