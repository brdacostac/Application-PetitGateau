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
        public string FilePath => Path.Combine(Directory.GetCurrentDirectory(), RelativePath);

        public string RelativePath { get; set; } = "XML";

        public string FileName { get; set; } = "petitGateau.xml";

        protected string PersFile => Path.Combine(FilePath, FileName);

        protected XmlObjectSerializer Serializer { get; set; } = new DataContractSerializer(typeof(DataToPersist));

        public virtual IEnumerable<Compte> LoadComptes()
        {
            if (!File.Exists(PersFile))
            {
                throw new FileNotFoundException();
            }

            DataToPersist data;

            using (Stream s = File.OpenRead(PersFile))
            {
                data = Serializer.ReadObject(s) as DataToPersist;
            }

            return (data.Comptes);
        }

        public virtual IEnumerable<Recette> LoadRecettes()
        {
            if (!File.Exists(PersFile))
            {
                throw new FileNotFoundException();
            }

            DataToPersist data;

            using (Stream s = File.OpenRead(PersFile))
            {
                data = Serializer.ReadObject(s) as DataToPersist;
            }

            return (data.Recettes);
        }


        public virtual void SauvegardeDonnées(IEnumerable<Recette> recettes, IEnumerable<Compte> comptes)
        {
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
                    Serializer.WriteObject(writer, data);
                }
            }

        }
    }
}