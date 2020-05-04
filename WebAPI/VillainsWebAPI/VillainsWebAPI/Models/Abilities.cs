using System;
using System.Collections.Generic;

namespace VillainsWebAPI.Models
{
    public partial class Abilities
    {
        public int Id { get; set; }
        public int VillainId { get; set; }
        public string VillainName { get; set; }
        public string AbilityName { get; set; }
        public short? Level { get; set; }
        public string Description { get; set; }

        public virtual Villain Villain { get; set; }
    }
}
