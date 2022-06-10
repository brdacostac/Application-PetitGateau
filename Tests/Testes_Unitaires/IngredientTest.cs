using Modele;
using System;
using Xunit;

namespace Testes_Unitaires
{
    public class IngredientTest
    {

        [Theory]
        [InlineData("viande", 500, Unité.KG, false)]
        [InlineData("orange", -85, Unité.ML, true)]
        public void TestConstructor(string aliment, double quantite, Unité unite, bool shouldThrowException)
        {
            if (shouldThrowException)
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => new Quantité(quantite, unite));
                return;
            }
            
            Quantité q = new Quantité(quantite, unite);
            Ingredient ingredient = new Ingredient(aliment, q);
            Assert.Equal(aliment, ingredient.Aliment);
            Assert.Equal(quantite, ingredient.Quant.Nombre);
            Assert.Equal(unite, ingredient.Quant.Uni);
        }
    }
}
