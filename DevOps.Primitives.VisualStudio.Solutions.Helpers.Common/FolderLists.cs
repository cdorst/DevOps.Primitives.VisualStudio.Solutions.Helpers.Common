using System.Collections.Generic;
using System.Linq;

using static DevOps.Primitives.VisualStudio.Solutions.Helpers.Common.Folders;

namespace DevOps.Primitives.VisualStudio.Solutions.Helpers.Common
{
    public static class FolderLists
    {
        public static SolutionFolderList Create(params SolutionFolder[] folders)
            => new SolutionFolderList(GetListItems(in folders));

        public static SolutionFolderList SourceAndTests(
            in SolutionProjectList sourceProjects,
            in SolutionProjectList testsProjects)
            => Create(
                Source(in sourceProjects),
                Tests(in testsProjects));

        private static List<SolutionFolderListAssociation> GetListItems(in SolutionFolder[] folders)
            => folders.Select(folder => new SolutionFolderListAssociation(in folder)).ToList();
    }
}
