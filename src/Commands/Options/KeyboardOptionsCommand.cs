﻿using Microsoft.VisualStudio.Shell;

namespace Essentials.VS.Commands.Options
{
    using YD.Framework.VisualStudio.Commands;
    using YD.Framework.VisualStudio.Packages;

    internal sealed class KeyboardOptionsCommand : DynamicCommand
    {
        //***
        //===M

        private KeyboardOptionsCommand(PackageBase package) : base(package, PackageIds.KeyboardOptionsCommand)
        { }

        //===M

        public static void Instantiate(PackageBase package)
            => Instantiate(new KeyboardOptionsCommand(package));

        //---

        protected override void OnExecute(OleMenuCommand command)
            => ExecuteCommand()
                .ShowProblem()
                .ShowInformation();

        //---

        private CommandResult ExecuteCommand()
            => Package?.ShowOptions(CommandKeys.KeyboardOptions);

        //***
    }
}