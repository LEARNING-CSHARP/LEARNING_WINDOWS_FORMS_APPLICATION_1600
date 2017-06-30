namespace LEARNING_WINDOWS_FORMS_APPLICATION
{
	static class Program
	{
		[System.STAThread]
		static void Main()
		{
			// **************************************************
			System.Windows.Forms.Application.EnableVisualStyles();
			System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
			// **************************************************

			// **************************************************
			Form2 frmStartup = new Form2();

			System.Windows.Forms.Application.Run(frmStartup);

			if (frmStartup != null)
			{
				if (frmStartup.IsDisposed == false)
				{
					frmStartup.Dispose();
				}

				frmStartup = null;
			}
			// **************************************************
		}
	}
}
