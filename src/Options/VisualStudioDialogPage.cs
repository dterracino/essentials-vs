using System.ComponentModel;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

namespace Essentials.VS.Options
{
    using static PackageGuids;
    using static PackageConstants;

    [Guid(VisualStudioDialogPageString)]
    public class VisualStudioDialogPage : DialogPage
    {
        [Category(VisualStudioFeatures)]
        [DisplayName("Activity Log Enabled")]
        [Description("")]
        [DefaultValue(true)]
        public bool ActivityLogCommandEnabled { get; set; } = true;

        [Category(VisualStudioFeatures)]
        [DisplayName("Diagnnostics Log Enabled")]
        [Description("")]
        [DefaultValue(true)]
        public bool DiagnosticLogCommandEnabled { get; set; } = true;

        [Category(VisualStudioFeatures)]
        [DisplayName("Path Variables Enabled")]
        [Description("")]
        [DefaultValue(true)]
        public bool PathVariablsCommandEnabled { get; set; } = true;

        //protected override void OnApply(PageApplyEventArgs e)
        //{

        //    base.OnApply(e);
        //}
    }
}