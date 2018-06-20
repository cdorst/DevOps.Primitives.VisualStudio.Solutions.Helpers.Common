using System;
using static System.Data.HashFunction.xxHash.xxHashFactory;
using static System.Guid;
using static System.String;
using static System.Text.Encoding;

namespace DevOps.Primitives.VisualStudio.Solutions.Helpers.Common
{
    public static class SolutionGuidGetter
    {
        public static Guid GetGuid(in string name)
        {
            var hexString = GetHexString(in name);
            return ParseExact(Concat(hexString, hexString, hexString, hexString), "N");
        }

        private static string GetHexString(in string name)
            => Instance.Create()
                .ComputeHash(UTF8.GetBytes(name))
                .AsHexString(true);
    }
}
