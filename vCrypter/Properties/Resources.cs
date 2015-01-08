namespace vCrypter.Properties
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Globalization;
    using System.Resources;
    using System.Runtime.CompilerServices;

    [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"), CompilerGenerated, DebuggerNonUserCode]
    internal class Resources
    {
        private static CultureInfo resourceCulture;
        private static System.Resources.ResourceManager resourceMan;

        internal Resources()
        {
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static CultureInfo Culture
        {
            get
            {
                return resourceCulture;
            }
            set
            {
                resourceCulture = value;
            }
        }

        internal static Bitmap LauncherBackground
        {
            get
            {
                return (Bitmap) ResourceManager.GetObject("LauncherBackground", resourceCulture);
            }
        }

        internal static Bitmap LauncherBackground2
        {
            get
            {
                return (Bitmap) ResourceManager.GetObject("LauncherBackground2", resourceCulture);
            }
        }

        internal static Bitmap LauncherBackground3
        {
            get
            {
                return (Bitmap) ResourceManager.GetObject("LauncherBackground3", resourceCulture);
            }
        }

        internal static Bitmap LauncherBackground4
        {
            get
            {
                return (Bitmap) ResourceManager.GetObject("LauncherBackground4", resourceCulture);
            }
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(resourceMan, null))
                {
                    System.Resources.ResourceManager manager = new System.Resources.ResourceManager("vCrypter.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = manager;
                }
                return resourceMan;
            }
        }

        internal static Bitmap unknownperson
        {
            get
            {
                return (Bitmap) ResourceManager.GetObject("unknownperson", resourceCulture);
            }
        }

        internal static Bitmap unknownperson2
        {
            get
            {
                return (Bitmap) ResourceManager.GetObject("unknownperson2", resourceCulture);
            }
        }
    }
}

