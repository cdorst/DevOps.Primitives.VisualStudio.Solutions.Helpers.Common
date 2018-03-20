namespace DevOps.Primitives.VisualStudio.Solutions.Helpers.Common
{
    public class VisualStudioVersionInfo
    {
        public VisualStudioVersionInfo(
            string versionComment,
            string visualStudioVersion,
            string solutionFileFormatVersion = "12.00",
            string minimumVisualStudioVersion = "10.0.40219.1")
        {
            MinimumVisualStudioVersion = minimumVisualStudioVersion;
            SolutionFileFormatVersion = solutionFileFormatVersion;
            VersionComment = versionComment;
            VisualStudioVersion = visualStudioVersion;
        }

        public string MinimumVisualStudioVersion { get; set; }
        public string SolutionFileFormatVersion { get; set; }
        public string VersionComment { get; set; }
        public string VisualStudioVersion { get; set; }

        public string GetVersionInfo()
            => $"Microsoft Visual Studio Solution File, Format Version {SolutionFileFormatVersion}\r\n# {VersionComment}\r\nVisualStudioVersion = {VisualStudioVersion}\r\nMinimumVisualStudioVersion = {MinimumVisualStudioVersion}";
    }
}
