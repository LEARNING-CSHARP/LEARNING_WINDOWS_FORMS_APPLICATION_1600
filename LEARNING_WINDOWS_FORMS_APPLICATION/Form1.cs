﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEARNING_WINDOWS_FORMS_APPLICATION
{
	public partial class Form1 : BaseForm
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			exitButton.ForeColor = System.Drawing.Color.Red;
		}
	}
}
