using Modele;
using System;
using Xunit;

namespace Testes_Unitaires
{
    public class IngredientTest
    {

        [Theory]
        [InlineData("viande", 500, Unit�.KG, false)]
        [InlineData("orange", -85, Unit�.ML, true)]
        public void TestConstructor(string aliment, double quantite, Unit� unite, bool shouldThrowException)
        {
            if (shouldThrowException)
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => new Quantit�(quantite, unite));
                return;
            }
            
            Quantit� q = new Quantit�(quantite, unite);
            Ingredient ingredient = new Ingredient(aliment, q);
            Assert.Equal(aliment, ingredient.Aliment);
            Assert.Equal(quantite, ingredient.Quant.Nombre);
            Assert.Equal(unite, ingredient.Quant.Uni);
        }
    }
}
