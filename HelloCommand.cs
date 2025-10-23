// HelloCommand.cs
using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

// ✅ Must be at very top of file and outside all namespaces
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: ComVisible(false)]

namespace MyRevitAddin
{
    [Transaction(TransactionMode.Manual)]
    public class HelloCommand : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            TaskDialog.Show("TESTPLUGIN", "🎉 Hello from working Revit plugin!");
            return Result.Succeeded;
        }
    }
}
