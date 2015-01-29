﻿using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.VisualStudio.Shell;

namespace GitFlowVS.Extension
{
    [PackageRegistration(UseManagedResourcesOnly = true)]
    [InstalledProductRegistration("#110", "#112", "1.0", IconResourceID = 400)]
    [ProvideAutoLoad(UIContextGuids80.NoSolution)]
    [Guid(GuidList.guidGitFlow_VS_ExtensionPkgString)]
    public sealed class GitFlow_VS_ExtensionPackage : Package
    {
        public GitFlow_VS_ExtensionPackage()
        {
        }

        protected override void Initialize()
        {
            base.Initialize();

        }

    }
}
