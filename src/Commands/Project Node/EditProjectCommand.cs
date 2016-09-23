using Microsoft.VisualStudio.Shell;

namespace Essentials.VS.Commands.ProjectNode
{
    using YD.Framework.VisualStudio.Commands;
    using YD.Framework.VisualStudio.Packages;
    using YD.Framework.VisualStudio.SelectedItemsExtensions;
    using YD.Framework.VisualStudio.Solutions;

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
            //return EditSelectedProject_();
        }

        //public CommandResult EditSelectedProject_(string success = null, string problem = null)
        //{
        //    try
        //    {
        //        var dte = PackageBase.GetDte();
        //        var selectedItems = dte?.SelectedItems;
        //        var name = selectedItems.GetSelectedProject().FullName;
        //        var itemType = selectedItems.GetCurrentSelectionKind();

        //        if (itemType != SolutionExplorerItemType.Project)
        //            return new ProblemResult(problem ?? $"Selection is not a project ({itemType})");

        //        var result = Package?.ExecuteCommand("Project.UnloadProject", success: success, problem: problem);
        //        if (!result.Succeeded)
        //            return result;

        //        return Package?.OpenCodeFile(name, success, problem);
        //    }
        //    catch (Exception ex)
        //    {
        //        return new ProblemResult(problem ?? ex.ExtendedMessage());
        //    }
        //}

        //***
    }
}