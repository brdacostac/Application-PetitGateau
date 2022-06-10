using Modele;
using System;
using Xunit;

namespace Testes_Unitaires
{
    public class ChefTest
    {
        [Fact]
        public void TestConstructor()
        {
            
            Chef chef = new Chef();
            Assert.Equal(1, chef.Level.Indice);
            Assert.Equal(100, chef.Level.ExperienceNecessaire);
            Assert.Equal(0, chef.ExperienceActuel);
        }



        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        public void LevelUp(int level, int levelExpected)
        {
            Chef chef = new Chef();
            Assert.Equal(level, levelExpected);
            chef.LevelUp();
            Assert.Equal(level,levelExpected);
        }
    }
}
