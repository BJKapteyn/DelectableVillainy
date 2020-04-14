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

    [HttpGet("Attack")]
    public IActionResult Attack(int mass)
    {
      //int attackDamage;
      //string k;
      //if (mass > 0)
      //{
      //  //change once defense is implemented
      //  attackDamage = StatCalculator.Attack(mass, 5);
      //  k = JsonConvert.SerializeObject(attackDamage);
      //}
      //else
      //{
      //  k = JsonConvert.SerializeObject("Yah blew it");
      //}
      //return Json;
      string massStr = mass.ToString();
      return Content(massStr);
    }
  }
}
