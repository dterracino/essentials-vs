using Microsoft.VisualStudio.Shell;

namespace Essentials.VS.Commands
{
    using YD.Framework.VisualStudio.Commands;
    using YD.Framework.VisualStudio.Packages;

    internal sealed class CloseSolutionCommand : DynamicCommand
    {
        //***

        private static int CommandId
            => PackageIds.CloseSolutionCommand;

        //===M

        private CloseSolutionCommand(PackageBase package) : base(package, CommandId)
        { }

        //===M

        public static void Instantiate(PackageBase package)
            => Instantiate(new CloseSolutionCommand(package));

        //---

        //protected override bool IsActive
        //    => base.IsActive && ;

        protected override void OnExecute(OleMenuCommand command)
            => ExecuteCommand()
                .ShowProblem()
                .ShowInformation();

        //---

        private CommandResult ExecuteCommand()
            => Package?.CloseSolution(problem: $"Unable to close solution");

        //***
    }
}