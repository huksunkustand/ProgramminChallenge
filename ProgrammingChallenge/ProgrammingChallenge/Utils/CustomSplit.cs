using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProgrammingChallenge.Utils
{
 public static class StringExtensions
  {
        public static string[] CustomSplit(this string myString)
      {
        var matchList = new List<string> { };
        var regex = new Regex("[^\\s\"']+|\"([^\"]*)\"|'([^']*)'");
        var matchCollection = regex.Matches(myString);
          foreach (var match in matchCollection)
          {
            matchList.Add(match.ToString().Trim('"'));
          }
        return matchList.ToArray();
      }
    }

  
}
