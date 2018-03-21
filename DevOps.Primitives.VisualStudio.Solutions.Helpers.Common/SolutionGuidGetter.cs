using System;
using System.Text;

namespace DevOps.Primitives.VisualStudio.Solutions.Helpers.Common
{
    internal static class SolutionGuidGetter
    {
        public static Guid GetGuid(string name)
            => Guid.ParseExact(
                System.Data.HashFunction.xxHash.xxHashFactory.Instance.Create()
                .ComputeHash(Encoding.UTF8.GetBytes(name))
                .AsHexString(true)
                .Substring(0, 32), "N");
    }
}
