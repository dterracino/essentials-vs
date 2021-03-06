﻿using Microsoft.VisualStudio.Shell;

namespace Essentials.VS.Commands.Build
{
    using YD.Framework.VisualStudio.Commands;
    using YD.Framework.VisualStudio.Packages;

    internal sealed class RebuildSolutionCommand : BuildCommand
    {
        //***
        //===M

        private RebuildSolutionCommand(PackageBase package) : base(package, PackageIds.RebuildSolutionCommand)
        { }

        //===M

        public static void Instantiate(PackageBase package)
            => Instantiate(new RebuildSolutionCommand(package));

        //---

        protected override bool CanExecute
        => (base.CanExecute && BuildOptions.RebuildSolutionCommandEnabled);

        protected override bool IsActive
            => base.IsActive && SolutionHasProjects && SolutionIsNotBuilding;

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