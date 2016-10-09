using Microsoft.VisualStudio.Shell;

namespace Essentials.VS.Commands.Options
{
    using YD.Framework.VisualStudio.Commands;
    using YD.Framework.VisualStudio.Packages;
    using VS.Options;

    internal sealed class EssentialsOptionsCommand : DynamicCommand
    {
        //***
        //===M

        private EssentialsOptionsCommand(PackageBase package) : base(package, PackageIds.EssentialsOptionsCommand)
        { }

        //===M

        public static void Instantiate(PackageBase package)
            => Instantiate(new EssentialsOptionsCommand(package));

        //---

        protected override void OnExecute(OleMenuCommand command)
            => ExecuteCommand()
                .ShowProblem()
                .ShowInformation();

        //---

        private CommandResult ExecuteCommand()
            => Package?.ShowOptionsPage<GeneralDialogPage>();

        //***
    }
}