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

    [HttpGet]
    public IEnumerable<string> Get()
    {
      
      using (VillainDB)
      {
        var villains = VillainDB.Villains.Select(x => x.Name).ToList();
        return villains;
      }
    }

    [HttpGet("attack/{mass}")]
    [HttpGet("attack")]
    public IActionResult Attack(string mass, [FromQuery] string opponentEgo)
    {
      string k;
      return Content("youoooooooouuuuuuuuuuuuuuuuuuuuuu" + mass);
    }
  }
}
