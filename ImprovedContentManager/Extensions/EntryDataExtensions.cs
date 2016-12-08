﻿using System;

namespace ImprovedContentManager.Extensions
{
    public static class EntryDataExtensions
    {
        public static int CompareNames(this EntryData a, EntryData b)
        {
            if (a?.entryName == null)
            {
                return 1;
            }

            if (b?.entryName == null)
            {
                return -1;
            }
            return string.Compare(a.entryName, b.entryName, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}