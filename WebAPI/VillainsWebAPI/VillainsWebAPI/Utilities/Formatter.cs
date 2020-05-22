using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillainsWebAPI
{
  public class Formatter
  {
    public static string DashToSpace(string villainName)
    {
      string[] villainFullNameArr = villainName.Split('-');
      string result = "";
      for(int i = 0; i < villainFullNameArr.Length; i++)
      {
        //capitalize first letter
        StringBuilder sb = new StringBuilder(villainFullNameArr[i]);
        sb[0] = char.ToUpper(sb[0]);
        villainFullNameArr[i] = sb.ToString();

        //put it name back together with spaces
        if(i != villainFullNameArr.Length - 1)
        {
          result += villainFullNameArr[i] + " ";
        }
        else
        {
          result += villainFullNameArr[i];
        }
      }
      return result;
    }
  }
}
