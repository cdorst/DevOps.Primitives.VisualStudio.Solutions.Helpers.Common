using System.Collections.Generic;
using System.Linq;

namespace DevOps.Primitives.VisualStudio.Solutions.Helpers.Common
{
    public static class FolderLists
    {
        public static SolutionFolderList Create(params SolutionFolder[] folders)
            => new SolutionFolderList(GetListItems(folders));

        public static SolutionFolderList SourceAndTests(SolutionProjectList sourceProjects, SolutionProjectList testsProjects)
            => Create(
                Folders.Source(sourceProjects),
                Folders.Tests(testsProjects));

        private static List<SolutionFolderListAssociation> GetListItems(params SolutionFolder[] folders)
            => folders.Select(folder => new SolutionFolderListAssociation(folder)).ToList();
    }
}
