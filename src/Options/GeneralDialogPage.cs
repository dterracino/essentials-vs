using System.ComponentModel;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

namespace Essentials.VS.Options
{
    using static PackageGuids;
    using static PackageConstants;

    [Guid(EssentialsOptionsPageString)]
    public class GeneralDialogPage : DialogPage
    {
        [Category(Commands)]
        [DisplayName("Enable build commands")]
        [Description("Rebuild Project, Rebuild Solution, Cancel Build")]
        [DefaultValue(true)]
        public bool BuildCommandsEnabled { get; set; } = true;

        [Category(Commands)]
        [DisplayName("Enable Visual Studio commands")]
        [Description("")]
        [DefaultValue(true)]
        public bool VisualStudioCommandsEnabled { get; } = true;

        //protected override void OnApply(PageApplyEventArgs e)
        //{

        //    base.OnApply(e);
        //}
    }
}