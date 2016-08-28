using Microsoft.VisualStudio.Shell;

namespace Essentials.VS
{
    using YD.Framework.VisualStudio.Commands;
    using YD.Framework.VisualStudio.Packages;

    internal sealed class RestartElevatedCommand : DynamicCommand
    {
        //***

        private static int CommandId
            => PackageIds.RestartElevatedCommand;

        //===M

        private RestartElevatedCommand(PackageBase package) : base(package, CommandId)
        { }

        //===M

        public static void Instantiate(PackageBase package)
            => Instantiate(new RestartElevatedCommand(package));

        //---

        protected override void OnExecute(OleMenuCommand command)
            => ExecuteCommand()
                .ShowProblem()
                .ShowInformation();

        //---

        private CommandResult ExecuteCommand()
            => Package?.RestartVisualStudio(elevated: true);

        //***
    }
}