using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

namespace Essentials.VS
{
    using YD.Framework.VisualStudio.Packages;
    using Commands;

    using static PackageGuids;
    using static Vsix;

    [InstalledProductRegistration("110", "112", Version, IconResourceID = 400)]
    [Guid(EvsPackageString)]

    public sealed class EvsPackage : PackageBase
    {
        public EvsPackage() : base(EvsCommandSet, Name, Description)
        { }

        protected override void Initialize()
        {
            base.Initialize();

            RebuildProjectCommand.Instantiate(this);
            RebuildSolutionCommand.Instantiate(this);
            CancelBuildCommand.Instantiate(this);

            RestartNormalCommand.Instantiate(this);
            RestartElevatedCommand.Instantiate(this);
        }
    }
}
