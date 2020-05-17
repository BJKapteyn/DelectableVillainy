using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using VillainsWebAPI.Models;

namespace VillainsWebAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class VillainController : ControllerBase
  {
    DelectableVillainyContext VillainDB;
    public VillainController(DelectableVillainyContext villainDB)
    {
      VillainDB = villainDB;
    }

    [HttpGet("{villain}")]
    public IActionResult GetVillain(string villain)
    {
      using (VillainDB)
      {
        try
        {
          string villainFirstName = villain.Split('-' )[0];
          string villainLastName = villain.Split('-' )[1];

          Villain v = VillainDB.Villains.FirstOrDefault(x => x.FirstName.Equals(villainFirstName) && x.LastName.Equals(villainLastName));

          string jsonVillain = JsonConvert.SerializeObject(v);

          return Ok(jsonVillain);
        }
        catch
        {
          return Content("Sorry I couldn't find that Villain");
        }
      }
    }


    [HttpGet("attack/{mass}")]
    [HttpGet("attack")]
    public IActionResult Attack(string mass, [FromQuery] string opponentEgo)
    {
      string result = "";
      int massInt = 0;
      int opponentEgoInt = 0;
      //
      bool massParseSuccess = int.TryParse(mass, out massInt);
      bool egoParseSuccess = int.TryParse(opponentEgo, out opponentEgoInt);

      if(massParseSuccess && egoParseSuccess)
      {
        int attackDamage = StatCalculator.Attack(massInt, opponentEgoInt);

        result = $"You did {attackDamage} damage. ALL ROIGHT";
      }
      else if(massParseSuccess && !egoParseSuccess)
      {
        result = "Ego was not in correct format";
      }
      else if(!massParseSuccess && egoParseSuccess)
      {
        result = "Mass was not in correct format";
      }
      else
      {
        result = "Both mass and ego were not in correct format";
      }


      return Content(result);
    }
  }
}
