/**/
namespace MinimalWinForms;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
    }    
}
/**/

/**

new Thread(() =>
{
ApplicationConfiguration.Initialize();
Application.Run(new MinimalWinForms.Form1());
})
{ ApartmentState = ApartmentState.STA}.Start();

**/