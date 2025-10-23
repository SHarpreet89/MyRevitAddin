using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

// 🔥 INLINE ASSEMBLY ATTRIBUTES - Bypasses AssemblyInfo.cs issues!
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: AssemblyTitle("TESTPLUGIN")]
[assembly: AssemblyProduct("TESTPLUGIN")]
[assembly: ComVisible(false)]
[assembly: Guid("a7d0e1f3-4b2c-4e5d-8f9a-1c3d5e6f7a8b")]

namespace TESTPLUGIN
{
    [Transaction(TransactionMode.Manual)]
    public class HelloCommand : IExternalCommand
    {
        public Result Execute(
            ExternalCommandData commandData,
            ref string message,
            ElementSet elements)
        {
            try
            {
                TaskDialog.Show("TESTPLUGIN", "Hello from TESTPLUGIN! Line 146 defeated!");
                return Result.Succeeded;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return Result.Failed;
            }
        }
    }
}
