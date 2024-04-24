﻿namespace System
{
    internal static class StringExtensions
    {
        public static string Cut(this String thisObj, int count)
        {
            if (thisObj.Length <= count)
            {
                return thisObj;
            }

            return thisObj.Substring(0, count) + "...";
        }
    }
}
