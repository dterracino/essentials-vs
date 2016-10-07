using System.ComponentModel;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

namespace Essentials.VS.Options
{
    using static PackageConstants;

    [Guid(PackageGuids.GeneralDialogPageString)]
    public class GeneralDialogPage : DialogPage
    {
        //***

        [Category(OneDotSpace + GeneralFeatures)]
        [DisplayName(Vsix.Name + " Features Enabled")]
        [Description("All features for the " + Vsix.Name + " package")]
        public bool EssentialsPackageEnabled { get; set; } = true;

        //---

        [Category(TwoDotSpace + GroupFeatures)]
        [DisplayName(BuildFeatures + " Enabled")]
        [Description("Rebuild Solution, Rebuild Project, Cancel Build")]
        public bool BuildCommandsEnabled { get; set; } = true;

        //---

        [Category(TwoDotSpace + GroupFeatures)]
        [DisplayName(DeveloperFeatures + " Enabled")]
        [Description("Activity Log, Disgnostics Log, Path Variables")]
        public bool DeveloperCommandsEnabled { get; set; } = true;

        //---

        [Category(TwoDotSpace + GroupFeatures)]
        [DisplayName(VisualStudio + " Features Enabled")]
        [Description("Rebuild Project, Rebuild Solution, Cancel Build")]
        public bool VisualStudioCommandsEnabled { get; set; } = true;

        //---

        //protected override void OnApply(PageApplyEventArgs e)
        //{

        //    base.OnApply(e);
        //}

        //***
    }
}