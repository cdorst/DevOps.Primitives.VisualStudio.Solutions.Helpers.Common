using System.Collections.Generic;
using System.Linq;

namespace DevOps.Primitives.VisualStudio.Solutions.Helpers.Common
{
    public static class ProjectLists
    {
        public static SolutionProjectList Create(params SolutionProject[] projects)
            => new SolutionProjectList(GetListItems(in projects));

        private static List<SolutionProjectListAssociation> GetListItems(in SolutionProject[] projects)
            => projects.Select(project => new SolutionProjectListAssociation(in project)).ToList();
    }
}
