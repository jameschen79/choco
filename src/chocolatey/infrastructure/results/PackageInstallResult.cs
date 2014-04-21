namespace chocolatey.infrastructure.results
{
    using System.Linq;

    /// <summary>
    ///   Outcome of package installation
    /// </summary>
    public sealed class PackageInstallResult : Result
    {
        public bool Inconclusive
        {
            get { return _messages.Value.Any(x => x.MessageType == ResultType.Inconclusive); }
        }

        public string Name { get; private set; }
        public string Version { get; private set; }

        public PackageInstallResult(string name, string version)
        {
            Name = name;
            Version = version;
        }
    }
}