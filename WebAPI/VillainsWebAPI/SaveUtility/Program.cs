using System;
using System.IO;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace SaveUtility
{
  class Program
  {
    static void Main(string[] args)
    {
      string currentDirectory = Directory.GetCurrentDirectory();
      string[] files = Directory.GetFiles($"{currentDirectory}\\Assets\\VillainDrawings");

      foreach (var file in files)
      {

        byte[] newpics = LoadPictureFromFile(file);
        Console.WriteLine("checking this point");
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
