using System;
using System.Text;

namespace DevOps.Primitives.VisualStudio.Solutions.Helpers.Common
{
    public static class SolutionGuidGetter
    {
        public static Guid GetGuid(string name)
        {
            var hexString = GetHexString(name);
            return Guid.ParseExact($"{hexString}{hexString}{hexString}{hexString}", "N");
        }

        private static string GetHexString(string name)
            => System.Data.HashFunction.xxHash.xxHashFactory.Instance.Create()
                .ComputeHash(Encoding.UTF8.GetBytes(name))
                .AsHexString(true);
    }
}
