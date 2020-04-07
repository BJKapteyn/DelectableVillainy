using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VillainsWebAPI
{
  public class StatCalculator
  {
    //calculation for a straight up attack
    public static int Attack(int mass, int opponentEgo)
    {
      int result = 0;
      int minAttack = 5;
      int baseAttack = 10;
      int attackModifier = mass;
      int defense = opponentEgo;
      Random rng = new Random();
      int rngModifier = rng.Next(1, 5);
      double defenseModifier = opponentEgo * .5;

      attackModifier += rngModifier;

      result = baseAttack + attackModifier;

      result -= Convert.ToInt32(Math.Round(defenseModifier));
      //return a minimum attack if the calculation ends up being very low
      if(result < minAttack)
      {
        return minAttack;
      }

      return result;
    }
  }
  
}
