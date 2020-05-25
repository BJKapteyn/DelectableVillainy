using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VillainsWebAPI.Models;

namespace VillainsWebAPI.DAL
{
  public static class InitializeDb
  {

    public static async Task SeedDevDb()
    {
      await using (var context = new DelectableVillainyContext())
      {
        await context.Database.MigrateAsync();

        Villain beastWellington = context.Villains.FirstOrDefault(v => v.FullName.Equals("Beast Wellington"));
          if (beastWellington == null)
          {
            await context.Villains.AddAsync(new Villain
            (
              "Beast","Wellington","M",53, "Bums", "London","Chefs Mallet","",
              "Once a master of the culinary arts, Beast took the law into his own twisted hands after someone \"popped\" all of his bread.",
              new List<Abilities>(), new List<BaseStats>(), "Beast_Wellington.jpg"
            ));
            await context.Villains.AddAsync(new Villain
            (
              "Knifey", "Stabbsyu", "M", 24,
              "Shields", "Dunnville",
              "Butter Knife", "",
              "This man just likes to stab people.",
              new List<Abilities>(),new List<BaseStats>(), "Knifey.jpg"
            ));
            await context.Villains.AddAsync(new Villain
            (
              "The", "Sword", "M", 33,
              "Knifey Stabbsyu", "Osaka",
              "BroadSword", "",
              "This super villain is shrouded in mystery. Many say the his real Name is Steve.",
              new List<Abilities>(), new List<BaseStats>(), "S_Word.jpg"
            ));
            await context.Villains.AddAsync(new Villain
            (
              "Rex", "Bamboo", "M", 28 ,
              "Your Mom", "Grand Rapids",
              "Bamboo Battle Tank", "",
              "Once a military man, Rex turned against his own government and staged a coup spearheaded by his bamboo battle tank that fires bamboo splinters from it's many bamboo turrets.",
              new List<Abilities>(), new List<BaseStats>(), "Rex_Bamboo.jpg"

            ));
            await context.Villains.AddAsync(new Villain
            (
              "The", "WeirdShadow", "F", 22  ,
              "Rex Bamboo", "Darkness",
              "Unknown", "",
              "Said to be able to create any shadow puppet imaginable, even ones from your deepest nightmares.",
              new List<Abilities>(), new List<BaseStats>(), ""
            ));
          await context.Villains.AddAsync(new Villain
            (
              "Dr", "OppedMic", "M", 20,
              "Dr OppedMic", "The Streets",
              "Bazooka Mic", "",
              "His special power is the ability to dis an opponent so bad they never leave their house again.",
              new List<Abilities>(), new List<BaseStats>(), "DR_Optmic.jpg"
            ));

          }
        await context.SaveChangesAsync();
      }
    }

  }
}
