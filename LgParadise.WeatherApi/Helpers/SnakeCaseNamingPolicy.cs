using System;
using System.Text.Json;

namespace LgParadise.WeatherApi.Helpers
{
    public class SnakeCaseNamingPolicy : JsonNamingPolicy
    {
        public override string ConvertName(string name)
        {
            int maxLength = (int)Math.Ceiling(1.5 * name.Length) - 1;
            char[] chars = new char[maxLength];
            var charIndex = 0;
            var capChar = true;

            foreach (var c in name)
            {
                if (char.IsUpper(c))
                {
                    if (!capChar)
                    {
                        chars[charIndex++] = '_';
                        capChar = true;
                    }

                }
                else
                {
                    capChar = false;
                }
                chars[charIndex++] = char.ToLower(c);
            }
            return new string(chars, 0, charIndex);
        }
    }
}
