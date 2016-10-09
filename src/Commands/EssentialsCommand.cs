using Microsoft.VisualStudio.Shell;

namespace Essentials.VS.Commands
{
    using VS.Options;
    using YD.Framework.VisualStudio.Commands;
    using YD.Framework.VisualStudio.Packages;

    internal abstract class EssentialsCommand : DynamicCommand
    {
        //***

        protected GeneralDialogPage EssentialsOptions
            => Package.GetDialogPage(typeof(GeneralDialogPage)) as GeneralDialogPage;

        //===M

        protected EssentialsCommand(PackageBase package, int id) : base(package, id)
        { }

        //===M

        protected override bool CanExecute
            => EssentialsOptions.EssentialsEnabled;

        //***
    }
}