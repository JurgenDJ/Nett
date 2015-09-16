﻿namespace Nett.Parser.Matchers
{
    internal static class CharExtensions
    {
        public static bool InRange(this char c, char min, char max)
        {
            return min <= c && c <= max;
        }

        public static bool IsBareKeyChar(this char c)
        {
            return c.InRange('a', 'z') || c.InRange('A', 'Z') || c.InRange('0', '9') || c == '-' || c == '_';
        }
    }
}
