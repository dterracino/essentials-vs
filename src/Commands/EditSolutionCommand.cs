using Microsoft.VisualStudio.Shell;
using YD.Framework.VisualStudio.Commands;
using YD.Framework.VisualStudio.Packages;

namespace Essentials.VS.Commands
{
    internal sealed class EditSolutionCommand : DynamicCommand
    {
        //***

        private static int CommandId
            => PackageIds.EditSolutionCommand;

        //===M

        private EditSolutionCommand(PackageBase package) : base(package, CommandId)
        { }

        //===M

        public static void Instantiate(PackageBase package)
            => Instantiate(new EditSolutionCommand(package));

        //---

        protected override void OnExecute(OleMenuCommand command)
            => ExecuteCommand()
                .ShowProblem()
                .ShowInformation();

        protected override bool IsActive
            => base.IsActive
                && SolutionIsNotBuilding;

        //---

        private CommandResult ExecuteCommand()
            => Package?.EditSolution();

        //***
    }
}