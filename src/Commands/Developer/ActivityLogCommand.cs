using Microsoft.VisualStudio.Shell;

namespace Essentials.VS.Commands.Developer
{
    using YD.Framework.VisualStudio.Commands;
    using YD.Framework.VisualStudio.Packages;

    using static YD.Framework.VisualStudio.Commands.CommandKeys;

    internal sealed class ActivityLogCommand : DynamicCommand
    {
        //***

        public static int CommandId
            => PackageIds.ActivityLogCommand;

        private string Path
            => $"{Package.UserDataPath}\\ActivityLog.xml";

        //===M

        private ActivityLogCommand(PackageBase package) : base(package, CommandId)
        { }

        //===M

        public static void Instantiate(PackageBase package)
            => Instantiate(new ActivityLogCommand(package));

        //---

        protected override void OnExecute(OleMenuCommand command)
            => ExecuteCommand()
                .ShowProblem()
                .ShowInformation();

        //---

        private CommandResult ExecuteCommand()
            => Package?.ExecuteCommand(ViewWebBrowser, Path, problem: "Unable to view activity log");

        //***
    }
}