namespace LEARNING_WINDOWS_FORMS_APPLICATION
{
	public partial class Form2 : BaseForm
	{
		public Form2()
		{
			InitializeComponent();
		}

		//protected override void exitButton_Click(object sender, System.EventArgs e)
		//{
		//	base.exitButton_Click(sender, e);
		//}

		protected override void exitButton_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.DialogResult enmResult =
				System.Windows.Forms.MessageBox.Show
				(text: "آیا به خروج از برنامه اطمینان دارید؟",
				caption: "سوال",
				buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
				icon: System.Windows.Forms.MessageBoxIcon.Question,
				defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button2,
				options: System.Windows.Forms.MessageBoxOptions.RightAlign |
				System.Windows.Forms.MessageBoxOptions.RtlReading);

			if (enmResult == System.Windows.Forms.DialogResult.Yes)
			{
				base.exitButton_Click(sender, e);
			}
		}
	}
}
