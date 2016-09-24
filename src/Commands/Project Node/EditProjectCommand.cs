using Microsoft.VisualStudio.Shell;

namespace Essentials.VS.Commands.ProjectNode
{
    using YD.Framework.VisualStudio.Commands;
    using YD.Framework.VisualStudio.Packages;

    internal sealed class EditProjectCommand : DynamicCommand
    {
        //***

        private static int CommandId
            => PackageIds.EditProjectCommand;

        //===M

        private EditProjectCommand(PackageBase package) : base(package, CommandId)
        { }

        //===M

        public static void Instantiate(PackageBase package)
            => Instantiate(new EditProjectCommand(package));

        //---

        protected override void OnExecute(OleMenuCommand command)
            => ExecuteCommand()
                .ShowProblem()
                .ShowInformation();

        protected override bool IsActive
        {
            get
            {
                if (!base.IsActive)
                    return false;

                if (!Package.ProjectSelected())
                    return false;

                return base.IsActive && SolutionIsNotBuilding;
            }
        }

        //---

        private CommandResult ExecuteCommand()
        {
            return Package?.EditSelectedProject();
        }

        //***
    }
}