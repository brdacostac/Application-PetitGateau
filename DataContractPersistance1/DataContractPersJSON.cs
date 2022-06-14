using Modele;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Xml;

namespace DataContractPersistance1
{

    public class DataContractPersJSON : DataContractPers
    {
        public DataContractPersJSON()
        {
            RelativePath = "JSON";
            FileName = "petitGateau.json";
            Serializer
                = new DataContractJsonSerializer(typeof(DataToPersist));
        }
        public override void SauvegardeDonnées(IEnumerable<Recette> recettes, IEnumerable<Compte> comptes)
        {
            if (!Directory.Exists(FilePath))
            {
                Directory.CreateDirectory(FilePath);
            }

            DataToPersist data = new DataToPersist();
            data.Comptes.AddRange(comptes);
            data.Recettes.AddRange(recettes);
            using (Stream wirter = File.Create(PersFile))
            {
                Serializer.WriteObject(wirter, data);
            }
        }

    }
}