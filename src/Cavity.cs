using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;

[assembly: AssemblyCompany("Cavity")]
[assembly: AssemblyProduct("http://code.google.com/p/cavity/")]
[assembly: AssemblyCopyright("Copyright © 2010 - 2011 Alan Dean")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: NeutralResourcesLanguage("en-GB")]
[assembly: ComVisible(false)]

#if (DEBUG)

[assembly: AssemblyConfiguration("Debug Build")]

#else

[assembly: AssemblyConfiguration("Release Build")]

#endif