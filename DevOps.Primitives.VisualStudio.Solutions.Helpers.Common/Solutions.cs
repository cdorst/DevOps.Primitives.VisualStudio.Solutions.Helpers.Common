using System;
using System.Collections.Generic;
using System.Linq;

namespace DevOps.Primitives.VisualStudio.Solutions.Helpers.Common
{
    public static class Solutions
    {
        public static Solution Create(
            string name,
            VisualStudioVersionInfo version,
            SolutionProjectList sourceProjects,
            SolutionProjectList testsProjects)
            => new Solution(
                Guid.NewGuid(),
                name,
                version.GetVersionInfo(),
                FolderLists.SourceAndTests(sourceProjects, testsProjects));

        public static Solution Create(
            string name,
            VisualStudioVersionInfo version,
            IEnumerable<SolutionProject> sourceProjects,
            IEnumerable<SolutionProject> testsProjects)
            => Create(
                name,
                version,
                ProjectLists.Create(sourceProjects.ToArray()),
                ProjectLists.Create(sourceProjects.ToArray()));
    }


}
