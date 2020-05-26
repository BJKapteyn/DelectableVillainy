using System;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VillainsWebAPI.Models
{
    public partial class Villain
    {
      public Villain(string firstName, string lastName, string gender, short? age, string nemesis, string hometown, string weaponOfChoice, string background , string description, ICollection<Abilities> abilities, ICollection<BaseStats> baseStats, string imgFileName)
      {
        FirstName = firstName;
        LastName = lastName;
        FullName = $"{FirstName} {LastName}";
        Gender = gender;
        Age = age;
        Nemesis = nemesis;
        Hometown = hometown;
        WeaponOfChoice = weaponOfChoice;
        Background = background;
        Description = description;
        ImgFileName = imgFileName;
    }

      public Villain()
        {
        }

        public int VillainId { get; set; }

        public string FullName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string Gender { get; set; }
        public short? Age { get; set; }
        public string Nemesis { get; set; }
        public string Hometown { get; set; }
        public string Background { get; set; }
        public string WeaponOfChoice { get; set; }
        public string Description { get; set; }
        public string SelfPortrait { get; set; }
        public string ImgFileName { get; set; }

        public virtual ICollection<Abilities> Abilities { get; set; } = new HashSet<Abilities>();
        public virtual ICollection<BaseStats> BaseStats { get; set; } = new HashSet<BaseStats>();

        private string GetFullName()
        {
          return $"{FirstName} {LastName}";
        }

    }
}
