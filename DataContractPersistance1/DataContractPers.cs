using Modele;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;

namespace DataContractPersistance1
{
    public class DataContractPers : IPersistanceManager
    {
        public string FilePath { get; set; } = Path.Combine(Directory.GetCurrentDirectory(), "..//XML");

        public string FileName { get; set; } = "petitGateau.xml";

        string PersFile => Path.Combine(FilePath, FileName);
        public IEnumerable<Compte> LoadComptes()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Recette> LoadRecettes()
        {
            throw new NotImplementedException();
        }

        public (IEnumerable<Recette> recettes, IEnumerable<Compte> comptes) ChargeDonnees()
        {
            
            if (!File.Exists(PersFile))
            {
                throw new FileNotFoundException();
            }

            var serializer = new DataContractSerializer(typeof(DataToPersist));

            DataToPersist data;

            using (Stream s = File.OpenRead(PersFile))
            {
                data = serializer.ReadObject(s) as DataToPersist;
            }

            return (data.Recettes, data.Comptes);

            
        }

        public void SauvegardeDonnées(IEnumerable<Recette> recettes, IEnumerable<Compte> comptes)
        {
            var serializer = new DataContractSerializer(typeof(DataToPersist));
            if (!Directory.Exists(FilePath))
            {
                Directory.CreateDirectory(FilePath);
            }


            DataToPersist data = new DataToPersist();
            data.Comptes.AddRange(comptes);
            data.Recettes.AddRange(recettes);

            var settings = new XmlWriterSettings() { Indent = true };

            using (TextWriter tw = File.CreateText(PersFile))
            {
                using (XmlWriter writer = XmlWriter.Create(tw, settings))
                {
                    serializer.WriteObject(writer, data);
                }
            }

        }
    }
}