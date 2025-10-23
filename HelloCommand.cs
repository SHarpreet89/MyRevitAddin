using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

// 🔥 INLINE VERSION ATTRIBUTES (CRITICAL)
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: ComVisible(false)]

namespace TESTPLUGIN
{
    [Transaction(TransactionMode.Manual)]
    public class HelloCommand : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            TaskDialog.Show("Hello", "Hello from Revit Add-in!");
            return Result.Succeeded;
        }
    }
}
