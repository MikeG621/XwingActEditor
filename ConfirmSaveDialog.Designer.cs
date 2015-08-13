/*
 * X-wing series ACT Editor, Creates and edits LucasArts *.ACT image files.
 * Copyright (C) 2009 Michael Gaisser (jaggedfel621@gmail.com)
 * 
 * Full notice in MainForm.cs
 */

namespace Idmr.XwingSeriesActEditor
{
	partial class ConfirmSaveDialog
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmSaveDialog));
			this.label1 = new System.Windows.Forms.Label();
			this.cmdYes = new System.Windows.Forms.Button();
			this.cmdNo = new System.Windows.Forms.Button();
			this.chkHide = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(280, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Image / Palette has been changed, do you wish to Save?";
			// 
			// cmdYes
			// 
			this.cmdYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
			this.cmdYes.Location = new System.Drawing.Point(55, 39);
			this.cmdYes.Name = "cmdYes";
			this.cmdYes.Size = new System.Drawing.Size(75, 23);
			this.cmdYes.TabIndex = 1;
			this.cmdYes.Text = "&Yes";
			this.cmdYes.UseVisualStyleBackColor = true;
			// 
			// cmdNo
			// 
			this.cmdNo.DialogResult = System.Windows.Forms.DialogResult.No;
			this.cmdNo.Location = new System.Drawing.Point(159, 39);
			this.cmdNo.Name = "cmdNo";
			this.cmdNo.Size = new System.Drawing.Size(75, 23);
			this.cmdNo.TabIndex = 1;
			this.cmdNo.Text = "&No";
			this.cmdNo.UseVisualStyleBackColor = true;
			// 
			// chkHide
			// 
			this.chkHide.AutoSize = true;
			this.chkHide.Location = new System.Drawing.Point(55, 68);
			this.chkHide.Name = "chkHide";
			this.chkHide.Size = new System.Drawing.Size(179, 17);
			this.chkHide.TabIndex = 2;
			this.chkHide.Text = "&Do not show this message again";
			this.chkHide.UseVisualStyleBackColor = true;
			this.chkHide.CheckedChanged += new System.EventHandler(this.chkHide_CheckedChanged);
			// 
			// ConfirmSaveDialog
			// 
			this.AcceptButton = this.cmdYes;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cmdNo;
			this.ClientSize = new System.Drawing.Size(297, 96);
			this.Controls.Add(this.chkHide);
			this.Controls.Add(this.cmdNo);
			this.Controls.Add(this.cmdYes);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ConfirmSaveDialog";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Confirm Save";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button cmdYes;
		private System.Windows.Forms.Button cmdNo;
		private System.Windows.Forms.CheckBox chkHide;
	}
}