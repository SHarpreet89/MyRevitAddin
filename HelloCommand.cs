using Autodesk.Revit.UI;
using Autodesk.Revit.DB;
using System;

namespace MyRevitAddin
{
    public class HelloCommand : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            try
            {
                TaskDialog.Show("Debug", "HelloCommand executed successfully!");
                return Result.Succeeded;
            }
            catch (Exception ex)
            {
                TaskDialog.Show("Error", ex.Message);
                return Result.Failed;
            }
        }
    }
}
