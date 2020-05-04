using System;
using System.Collections.Generic;

namespace VillainsWebAPI.Models
{
    public partial class Villain
    {
        public Villain()
        {
            Abilities = new HashSet<Abilities>();
            BaseStats = new HashSet<BaseStats>();
        }

        public int VillainId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public short? Age { get; set; }
        public string Nemesis { get; set; }
        public string Hometown { get; set; }
        public string Background { get; set; }
        public string WeaponOfChoice { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Abilities> Abilities { get; set; }
        public virtual ICollection<BaseStats> BaseStats { get; set; }
    }
}
