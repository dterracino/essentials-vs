using System;
using Microsoft.VisualStudio.Shell;
using EnvDTE;

using static System.Environment;

namespace Essentials.VS.Commands.Developer
{
    using YD.Framework.Exceptions.ExceptionExtensions;
    using YD.Framework.VisualStudio.Commands;
    using YD.Framework.VisualStudio.Packages;
    //using Framework.Exceptions.ExceptionExtensions;
    //using Framework.VisualStudio.Dte.DTE2Extensions;

    internal sealed class PathVariablesCommand : DynamicCommand
    {
        //***

        private static int CommandId
            => PackageIds.PathVariablesCommand;

        //===M

        private PathVariablesCommand(PackageBase package) : base(package, CommandId)
        { }

        //===M

        public static void Instantiate(PackageBase package)
            => Instantiate(new PathVariablesCommand(package));

        //---

        protected override void OnExecute(OleMenuCommand command)
            => ExecuteCommand()
                .ShowProblem()
                .ShowInformation();

        //---

        private CommandResult ExecuteCommand()
        {
            CommandResult result = null;

            try
            {
                const string semi_colon = ";";
                var colonNewline = semi_colon + NewLine;
                OutputWindowPane pane = null;// Package?.PackageOutputPane(YannsEssentials);
                var expanded = ExpandEnvironmentVariables("%path%");
                var text = expanded.Replace(semi_colon, colonNewline);

                text += colonNewline;

                //result = Package?.ActivateOutputWindow();
                if (!result.Succeeded) return result;

                pane.Activate();
                pane.Clear();
                pane.OutputString("Path Variables" + NewLine);
                pane.OutputString("==============" + NewLine + NewLine);
                pane.OutputString(text);

                result = new SuccessResult();
            }
            catch (Exception ex)
            {
                result = new ProblemResult(ex.ExtendedMessage());
            }

            return result;
        }

        //***
    }
}