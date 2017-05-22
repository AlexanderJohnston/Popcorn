﻿using System;

namespace Popcorn.YTVideoProvider.Helpers
{
    internal static class Require
    {
        public static void NotNull<T>(T obj, string name)
            where T : class
        {
            if (obj == null)
                throw new ArgumentNullException(name);
        }
    }
}