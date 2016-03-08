using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	public void ButtonSettingsClicked (object sender, EventArgs e)
	{
		IRISLauncher.SettingsDialog settings = new IRISLauncher.SettingsDialog();
		settings.Run();
		settings.Destroy();
	}

	protected void ButtonHelpClicked (object sender, EventArgs e)
	{
		IRISLauncher.HelpDialog help = new IRISLauncher.HelpDialog();
		help.Run();
		help.Destroy();
	}

	protected void ButtonDownloadInstanceClicked (object sender, EventArgs e)
	{
		IRISLauncher.DownloadInstanceDialog downloadInstance = new IRISLauncher.DownloadInstanceDialog();
		downloadInstance.Run();
		downloadInstance.Destroy();
	}

	protected void ButtonEditInstanceClicked (object sender, EventArgs e)
	{
		IRISLauncher.EditInstanceDialog editInstance = new IRISLauncher.EditInstanceDialog();
		editInstance.Run();
		editInstance.Destroy();
	}

	protected void ButtonLoadInstanceClicked (object sender, EventArgs e)
	{
		IRISLauncher.LoadInstanceDialog loadInstance = new IRISLauncher.LoadInstanceDialog();
		loadInstance.Run();
		loadInstance.Destroy();
	}

	protected void ButtonProblemsClicked (object sender, EventArgs e)
	{
		IRISLauncher.ProblemsDialog problems = new IRISLauncher.ProblemsDialog();
		problems.Run();
		problems.Destroy();
	}
}
