using Modele;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;

namespace DataContractPersistance
{
    public class DataContractPers : IPersistanceManager
    {
        public string FilePath { get; set; } = Path.Combine(Directory.GetCurrentDirectory(), "..//XML");

        public string FileName { get; set; } = "petitGateau.xml";
        public IEnumerable<Compte> LoadComptes()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Recette> LoadRecettes()
        {
            throw new NotImplementedException();
        }

        public void SauvegardeDonnées(IEnumerable<Recette> recettes, IEnumerable<Compte> comptes)
        {
            var serializer = new DataContractSerializer(typeof(IEnumerable<Recette>));
            if (!Directory.Exists(FilePath))
            {
                Directory.CreateDirectory(FilePath);
            }

            var settings = new XmlWriterSettings() { Indent = true };

            using (TextWriter tw = File.CreateText(Path.Combine(FilePath, FileName)))
            {
                using (XmlWriter writer = XmlWriter.Create(tw, settings))
                {
                    serializer.WriteObject(writer, recettes);
                }
            }

        }
    }
}