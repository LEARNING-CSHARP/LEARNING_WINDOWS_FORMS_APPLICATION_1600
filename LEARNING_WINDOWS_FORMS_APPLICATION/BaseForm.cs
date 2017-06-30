namespace LEARNING_WINDOWS_FORMS_APPLICATION
{
	public partial class BaseForm : System.Windows.Forms.Form
	{
		public BaseForm()
		{
			InitializeComponent();
		}

		private void BaseForm_Load(object sender, System.EventArgs e)
		{
		}

		//private void exitButton_Click(object sender, System.EventArgs e)
		//{
		//	System.Windows.Forms.Application.Exit();
		//}

		protected virtual void exitButton_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}
	}
}
