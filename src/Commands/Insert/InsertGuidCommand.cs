using Microsoft.VisualStudio.Shell;
using static System.Guid;

namespace Essentials.VS.Commands.Insert
{
    using YD.Framework.VisualStudio.Commands;
    using YD.Framework.VisualStudio.Packages;

    internal sealed class InsertGuidCommand : DynamicCommand
    {
        //***

        private static int CommandId
            => PackageIds.InsertGuidCommand;

        //===M

        private InsertGuidCommand(PackageBase package) : base(package, CommandId)
        { }

        //===M

        public static void Instantiate(PackageBase package)
            => Instantiate(new InsertGuidCommand(package));

        //---

        protected override void OnExecute(OleMenuCommand command)
            => ExecuteCommand()
                .ShowProblem()
                .ShowInformation();

        //---

        private CommandResult ExecuteCommand()
            => Package?.ReplaceSelectedText(
                () => NewGuid().ToString(), problem: "Unable to insert guid");

        //***
    }
}