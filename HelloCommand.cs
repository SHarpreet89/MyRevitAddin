using System;
using System.IO;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB;
using Autodesk.Revit.Attributes;

namespace MyRevitAddin
{
    [Transaction(TransactionMode.Manual)]
    public class HelloCommand : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            string logPath = Path.Combine(Path.GetTempPath(), "MyRevitAddin_Log.txt");
            try
            {
                File.AppendAllText(logPath, "Execute called at: " + DateTime.Now + Environment.NewLine);
                TaskDialog.Show("Debug", "HelloCommand executed successfully!");
                return Result.Succeeded;
            }
            catch (Exception ex)
            {
                File.AppendAllText(logPath, "❌ Exception: " + ex.ToString() + Environment.NewLine);
                message = ex.Message;
                return Result.Failed;
            }
        }
    }
}
