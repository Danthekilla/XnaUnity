﻿namespace System
{
    public static class S_Path
    {
        public static string Combine(string[] parts)
        {
            string res = parts[0];
            for (int i = 1; i < parts.Length; ++i)
                res = IO.Path.Combine(res, parts[i]);
            return res;
        }
    }
}