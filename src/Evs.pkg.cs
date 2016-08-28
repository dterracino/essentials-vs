﻿using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

namespace Essentials.VS
{
    using YD.Framework.VisualStudio.Packages;

    using static PackageGuids;
    using static Vsix;

    [InstalledProductRegistration(Name, Description, Version, IconResourceID = 400)]
    [Guid(EvsPackageString)]

    public sealed class EvsPackage : PackageBase
    {
        public EvsPackage() : base(EvsCommandSet, Name, Description)
        { }

        protected override void Initialize()
        {
            base.Initialize();

            RestartNormalCommand.Instantiate(this);
            RestartElevatedCommand.Instantiate(this);
        }
    }
}
