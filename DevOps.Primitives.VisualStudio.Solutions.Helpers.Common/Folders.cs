using System;

namespace DevOps.Primitives.VisualStudio.Solutions.Helpers.Common
{
    public static class Folders
    {
        public const string SourceFolder = "src";
        public const string TestsFolder = "test";

        public static SolutionFolder Create(string name, SolutionProjectList projects)
            => new SolutionFolder(Guid.NewGuid(), name, projects);

        public static SolutionFolder Source(SolutionProjectList projects)
            => Create(SourceFolder, projects);

        public static SolutionFolder Tests(SolutionProjectList projects)
            => Create(TestsFolder, projects);
    }
}
