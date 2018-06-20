using System.Collections.Generic;
using System.Linq;
using static DevOps.Primitives.VisualStudio.Solutions.Helpers.Common.SolutionGuidGetter;

namespace DevOps.Primitives.VisualStudio.Solutions.Helpers.Common
{
    public static class Solutions
    {
        public static Solution Create(
            in string name,
            in VisualStudioVersionInfo version,
            in SolutionProjectList sourceProjects,
            in SolutionProjectList testsProjects)
            => new Solution(
                GetGuid(in name),
                in name,
                version.GetVersionInfo(),
                FolderLists.SourceAndTests(in sourceProjects, in testsProjects));

        public static Solution Create(
            in string name,
            in VisualStudioVersionInfo version,
            in IEnumerable<SolutionProject> sourceProjects,
            in IEnumerable<SolutionProject> testsProjects)
            => Create(
                in name,
                in version,
                ProjectLists.Create(sourceProjects.ToArray()),
                ProjectLists.Create(testsProjects.ToArray()));

        public static Solution SingleProject(
            in string name,
            in VisualStudioVersionInfo version,
            in SolutionProject project)
            => new Solution(
                GetGuid(in name),
                in name,
                version.GetVersionInfo(),
                in project);
    }
}
