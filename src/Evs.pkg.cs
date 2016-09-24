using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

using static Microsoft.VisualStudio.Shell.Interop.UIContextGuids80;

namespace Essentials.VS
{
    using YD.Framework.VisualStudio.Packages;
    using Commands.Insert;
    using Commands.Build;
    using Commands.VisualStudio;
    using Commands.Restart;
    using Commands.Options;
    using Commands.SolutionNode;
    using Commands.ProjectNode;
    using Commands.Developer;

    using static PackageGuids;
    using static Vsix;

    [InstalledProductRegistration("110", "112", Version, IconResourceID = 400)]
    [Guid(EvsPackageString)]

    [ProvideAutoLoad(NoSolution)]
    [ProvideAutoLoad(SolutionExists)]

    public sealed class EvsPackage : PackageBase
    {
        public EvsPackage() : base(EvsCommandSet, Name, Description)
        { }

        protected override void Initialize()
        {
            base.Initialize();

            InsertGuidCommand.Instantiate(this);

            RebuildProjectCommand.Instantiate(this);
            RebuildSolutionCommand.Instantiate(this);
            CancelBuildCommand.Instantiate(this);

            ActivityLogCommand.Instantiate(this);
            DiagnosticLogCommand.Instantiate(this);
            PathVariablesCommand.Instantiate(this);

            ExtensionsAndUpdatesCommand.Instantiate(this);

            RestartNormalCommand.Instantiate(this);
            RestartElevatedCommand.Instantiate(this);

            KeyboardOptionsCommand.Instantiate(this);

            EditSolutionCommand.Instantiate(this);
            CloseSolutionCommand.Instantiate(this);

            EditProjectCommand.Instantiate(this);
        }
    }
}
