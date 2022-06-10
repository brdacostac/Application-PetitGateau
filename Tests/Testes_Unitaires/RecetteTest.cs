using Modele;
using System;
using Xunit;

namespace Testes_Unitaires
{
    public class RecetteTest
    {
        [Theory]
        [InlineData("receita1", Modele.Type.Entree, Region.Sud, 10, 1, "Images/Recettes/amazonie.jpg", false)]
        [InlineData("receita2", Modele.Type.Dessert, Region.Nord, -10, 1, "Images/Recettes/amazonie.jpg", true)]
        [InlineData("receita3", Modele.Type.Plat, Region.Sudest, 10, -1, "Images/Recettes/amazonie.jpg", true)]
        public void TestConstructor(string nom, Modele.Type type, Region og, int t, int couv, string img, bool shouldThrowException)
        {
            if (shouldThrowException)
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => new Recette(nom, type, null, null, og, t, couv, img));
                return;
            }

            Recette recette = new Recette(nom, type, null, null, og, t, couv, img);
            Assert.Equal(nom, recette.Nom);
            Assert.Equal(type, recette.Filtre);
            Assert.Equal(og, recette.Origine);
            Assert.Equal(t, recette.Temps);
            Assert.Equal(couv, recette.Couverts);
            Assert.Equal(img, recette.Img);
        }
    }
}
