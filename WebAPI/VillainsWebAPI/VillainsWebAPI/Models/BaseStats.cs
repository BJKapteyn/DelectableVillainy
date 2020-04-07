using System;
using System.Collections.Generic;

namespace VillainsWebAPI.Models
{
  public partial class BaseStats
  {
    public int Id { get; set; }
    public int VillainId { get; set; }
    public string VillainName { get; set; }
    public int Ego { get; set; }
    public int FightingSpirit { get; set; }
    public int Mass { get; set; }
    public int SelfConfidence { get; set; }
    public int Trickery { get; set; }

    public virtual Villain Villain { get; set; }
  }
}
