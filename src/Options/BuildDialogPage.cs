using System.ComponentModel;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

namespace Essentials.VS.Options
{
    using static PackageGuids;
    using static PackageConstants;

    [Guid(BuildDialogPageString)]
    public class BuildDialogPage : DialogPage
    {
        [Category(BuildFeatures)]
        [DisplayName("Rebuild Solution Enabled")]
        [Description("")]
        [DefaultValue(true)]
        public bool RebuildSolutionCommandEnabled { get; set; } = true;

        [Category(BuildFeatures)]
        [DisplayName("Rebuild Project Enabled")]
        [Description("")]
        [DefaultValue(true)]
        public bool RebuildProjectCommandEnabled { get; set; } = true;

        [Category(BuildFeatures)]
        [DisplayName("Cancel Build Enabled")]
        [Description("")]
        [DefaultValue(true)]
        public bool CancelBuildCommandEnabled { get; set; } = true;

        //protected override void OnApply(PageApplyEventArgs e)
        //{

        //    base.OnApply(e);
        //}
    }
}