
namespace GOG_Intergalactic;

internal static class Program
{
	/// <summary>
	///  The main entry point for the application.
	/// </summary>
	[STAThread]
	static async Task Main(string[] args)
	{
		// To customize application configuration such as set high DPI settings or default font,
		// see https://aka.ms/applicationconfiguration.
		ApplicationConfiguration.Initialize();

		if (args.Length == 0)
		{
			Application.Run(new Form1());
		}
		else if (args.Length == 2)
		{
			await new ShellUtil().CreateShortcut(args[1]);
		}
	}
}
