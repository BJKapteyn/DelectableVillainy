using System;
using Xunit;
using VillainsWebAPI;

namespace VillainsWebAPIUnitTests
{
  public class VillainAPIUnitTests
  {
    [Theory]
    [InlineData(5, 500, 5)]
    public void AttackTest(int mass, int opponentEgo, int expected)
    {
      int actual = StatCalculator.Attack(mass, opponentEgo);

      Assert.Equal(expected, actual);
    }
  }
}
