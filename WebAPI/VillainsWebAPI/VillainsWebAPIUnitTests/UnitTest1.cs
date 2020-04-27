using System;
using Xunit;
using VillainsWebAPI;

namespace VillainsWebAPIUnitTests
{
  public class VillainAPIUnitTests
  {
    //Attack API call test
    [Theory]
    [InlineData(5, 500, 5)]
    public void AttackTest(int mass, int opponentEgo, int expected)
    {
      int actual = StatCalculator.Attack(mass, opponentEgo);

      Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("Neville-Bamshoot", "Neville Bamshoot")]
    [InlineData("Henry-Eats-In-The-Attic", "Henry Eats In The Attic")]
    [InlineData("hey", "Hey")]
    public void NameFormatTest(string name, string expected)
    {
      string actual = Formatter.DashToSpace(name);

      Assert.Equal(expected, actual);
    }
  }
}
