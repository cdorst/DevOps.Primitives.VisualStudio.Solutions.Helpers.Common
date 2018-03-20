using System.Collections.Generic;
using System.Linq;
using static DevOps.Primitives.VisualStudio.Solutions.Helpers.Common.SolutionGuidGetter;

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
                GetGuid(name),
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

        public static Solution SingleProject(
            string name,
            VisualStudioVersionInfo version,
            SolutionProject project)
            => new Solution(
                GetGuid(name),
                name,
                version.GetVersionInfo(),
                project);
    }
}
