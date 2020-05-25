using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillainsWebAPI.Models;

namespace VillainsWebAPI.Utilities
{
  public class SaveImage
  {

    public static async Task SaveImageToDbAsync()
    {
      string currentDirectory = Directory.GetCurrentDirectory();
      string[] files = Directory.GetFiles($"{currentDirectory}\\Assets\\VillainDrawings");

      await using (var context = new DelectableVillainyContext())
      {
        foreach (var file in files)
        {

          byte[] byteArrayVillainImg = LoadPictureFromFile(file);
          string base64VillainImg = Convert.ToBase64String(byteArrayVillainImg);
          string fileName = file.Substring(file.LastIndexOf('\\') + 1);
          Villain villain = context.Villains.FirstOrDefault(v => v.ImgFileName.Equals(fileName));
          if (villain != null && villain.SelfPortrait == null)
          {
            villain.SelfPortrait = base64VillainImg;
            context.Villains.Update(villain);
            Console.WriteLine($"{villain.FullName} has been updated!");
          }
        }
        await context.SaveChangesAsync();
      }
    }

    private static byte[] LoadPictureFromFile(string filePath)
    {
      if (!File.Exists(filePath))
        return new byte[0];

      return File.ReadAllBytes(filePath);
    }
  }
}
