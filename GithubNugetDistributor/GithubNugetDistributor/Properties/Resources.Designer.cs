﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.35312
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GithubNugetDistributor.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("GithubNugetDistributor.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] NuGet {
            get {
                object obj = ResourceManager.GetObject("NuGet", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot;?&gt;
        ///&lt;package &gt;
        ///  &lt;metadata&gt;
        ///    &lt;id&gt;Package&lt;/id&gt;
        ///    &lt;version&gt;1.0.0&lt;/version&gt;
        ///    &lt;authors&gt;Mathias&lt;/authors&gt;
        ///    &lt;owners&gt;Mathias&lt;/owners&gt;
        ///    &lt;licenseUrl&gt;http://LICENSE_URL_HERE_OR_DELETE_THIS_LINE&lt;/licenseUrl&gt;
        ///    &lt;projectUrl&gt;http://PROJECT_URL_HERE_OR_DELETE_THIS_LINE&lt;/projectUrl&gt;
        ///    &lt;iconUrl&gt;http://ICON_URL_HERE_OR_DELETE_THIS_LINE&lt;/iconUrl&gt;
        ///    &lt;requireLicenseAcceptance&gt;false&lt;/requireLicenseAcceptance&gt;
        ///    &lt;description&gt;Package description&lt;/description&gt;
        ///    &lt;releaseNotes&gt;Su [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string NuGetPackage {
            get {
                return ResourceManager.GetString("NuGetPackage", resourceCulture);
            }
        }
    }
}
