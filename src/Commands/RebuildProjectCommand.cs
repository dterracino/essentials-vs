using Microsoft.VisualStudio.Shell;

namespace Essentials.VS.Commands
{
    using YD.Framework.VisualStudio.Commands;
    using YD.Framework.VisualStudio.Packages;

    internal sealed class RebuildProjectCommand : DynamicCommand
    {
        //***
        //===M

        private RebuildProjectCommand(PackageBase package) : base(package, PackageIds.RebuildProjectCommand)
        { }

        //===M

        public static void Instantiate(PackageBase package)
            => Instantiate(new RebuildProjectCommand(package));

        //---

        //protected override bool IsActive
        //    => base.IsActive && SolutionIsNotBuilding; //&& SolutionHasProject;


        protected override void OnExecute(OleMenuCommand command)
            => ExecuteCommand()
                .ShowProblem()
                .ShowInformation();

        //---

        private CommandResult ExecuteCommand()
            => Package?.RebuildProject(problem: "Unable to rebuild the current project");

        //***
    }
}