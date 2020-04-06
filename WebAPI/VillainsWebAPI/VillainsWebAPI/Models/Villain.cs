using System;
using System.Collections.Generic;

namespace VillainsWebAPI.Models
{
  public partial class Villain
  {
    //Update DB model WARNING will overwrite Models DO NOT USE AFTER STARTING WORK ON MODELS
    //Scaffold-DbContext "Server=LAPTOP-T6VP6L6I\SQLEXPRESS;Database=DelectableVillainy;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Force
    public int VillainId { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public short? Age { get; set; }
    public string Nemesis { get; set; }
    public string Hometown { get; set; }
    public string Background { get; set; }
    public string WeaponOfChoice { get; set; }
  }
}
