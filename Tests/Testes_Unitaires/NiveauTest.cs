using Modele;
using System;
using Xunit;

namespace Testes_Unitaires
{
    public class NiveauTest
    {
        [Fact]
        public void TestConstructor()
        {
            Niveau niveau = new Niveau();
            Assert.Equal(1, niveau.Indice);
            Assert.Equal(100, niveau.ExperienceNecessaire);
        }

    }
}

