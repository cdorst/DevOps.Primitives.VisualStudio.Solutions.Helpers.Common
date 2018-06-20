using static System.Guid;

namespace DevOps.Primitives.VisualStudio.Solutions.Helpers.Common
{
    public static class Folders
    {
        public const string SourceFolder = "src";
        public const string TestsFolder = "test";

        public static SolutionFolder Create(in string name, in SolutionProjectList projects)
            => new SolutionFolder(NewGuid(), in name, in projects);

        public static SolutionFolder Source(in SolutionProjectList projects)
            => Create(SourceFolder, in projects);

        public static SolutionFolder Tests(in SolutionProjectList projects)
            => Create(TestsFolder, in projects);
    }
}
