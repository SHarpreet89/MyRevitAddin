namespace MyRevitAddin
{
    public class HelloCommand : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            System.Windows.Forms.MessageBox.Show("Hello from ExternalCommand", "MyRevitAddin");
            return Result.Succeeded;
        }
    }
}
