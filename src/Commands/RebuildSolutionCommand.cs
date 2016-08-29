using Microsoft.VisualStudio.Shell;

namespace Essentials.VS.Commands
{
    using YD.Framework.VisualStudio.Commands;
    using YD.Framework.VisualStudio.Packages;

    internal sealed class RebuildSolutionCommand : DynamicCommand
    {
        //***
        //===M

        private RebuildSolutionCommand(PackageBase package) : base(package, PackageIds.RebuildSolutionCommand)
        { }

        //===M

        public static void Instantiate(PackageBase package)
            => Instantiate(new RebuildSolutionCommand(package));

        //---

        //protected override bool IsActive
        //    => base.IsActive && SolutionIsNotBuilding; //&& SolutionHasSolution;


        protected override void OnExecute(OleMenuCommand command)
            => ExecuteCommand()
                .ShowProblem()
                .ShowInformation();

        //---

        private CommandResult ExecuteCommand()
            => Package?.BuildSolution(rebuild: true);

        //***
    }
}