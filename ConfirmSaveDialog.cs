/*
 * X-wing series ACT Editor, Creates and edits LucasArts *.ACT image files.
 * Copyright (C) 2009 Michael Gaisser (mjgaisser@gmail.com)
 * Licensed under the MPL v2.0 or later.
 * 
 * Full notice in Program.cs
 * Version: 1.0.1
 */

/* CHANGELOG
 * v1.0.1, 150812
 * - Released under MPL 2.0
 * 
 * v1.0, 091010
 * - Release
 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Idmr.XwingSeriesActEditor
{
	public partial class ConfirmSaveDialog : Form
	{
		public ConfirmSaveDialog()
		{
			InitializeComponent();
		}

		private void chkHide_CheckedChanged(object sender, EventArgs e)
		{
			if (chkHide.Checked)
			{
				cmdYes.Text = "Alwa&ys";
				cmdNo.Text = "&Never";
				cmdYes.DialogResult = DialogResult.OK;
				cmdNo.DialogResult = DialogResult.Ignore;
			}
			else
			{
				cmdYes.Text = "&Yes";
				cmdNo.Text = "&No";
				cmdYes.DialogResult = DialogResult.Yes;
				cmdNo.DialogResult = DialogResult.No;
			}
		}
	}
}
