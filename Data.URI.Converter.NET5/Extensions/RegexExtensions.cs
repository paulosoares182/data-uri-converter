using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Data.URI.Extensions
{
    public static class RegexExtensions
    {
        public static List<string> GetTokens(this string input, string pattern, RegexOptions options = RegexOptions.None)
        {
            var tokens = new List<string>();
            foreach(Match match in Regex.Matches(input, pattern, options))
            {
                if(match.Groups.Count > 1)
                {
                    for(int i = 1; i < match.Groups.Count; i++)
                    {
                        tokens.Add(match.Groups[i].Value);
                    }
                }
            }

            return tokens;
        }

        public static string ReplaceTokens(this string input, string pattern, string replacement, RegexOptions options = RegexOptions.None)
        {
            return Regex.Replace(input, pattern, replacement, options);
        }
    }
}
