﻿using Microsoft.VisualStudio.Shell;

namespace Essentials.VS.Commands
{
    using YD.Framework.VisualStudio.Commands;
    using YD.Framework.VisualStudio.Packages;

    internal sealed class CancelBuildCommand : DynamicCommand
    {
        //***
        //===M

        private CancelBuildCommand(PackageBase package) : base(package, PackageIds.CancelBuildCommand)
        { }

        //===M

        public static void Instantiate(PackageBase package)
            => Instantiate(new CancelBuildCommand(package));

        //---

        //protected override bool IsActive
        //    => base.IsActive && SolutionIsNotBuilding; //&& SolutionHasProject;


        protected override void OnExecute(OleMenuCommand command)
            => ExecuteCommand()
                .ShowProblem()
                .ShowInformation();

        //---

        private CommandResult ExecuteCommand()
            => Package?.CancelBuild(problem: "Unable to rebuild the current project");

        //***
    }
}