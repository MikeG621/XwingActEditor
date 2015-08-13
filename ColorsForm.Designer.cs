/*
 * X-wing series ACT Editor, Creates and edits LucasArts *.ACT image files.
 * Copyright (C) 2009 Michael Gaisser (jaggedfel621@gmail.com)
 * 
 * Full notice in MainForm.cs
 */

namespace Idmr.XwingSeriesActEditor
{
	partial class ColorsForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorsForm));
			this.lblIndex = new System.Windows.Forms.Label();
			this.lblRed = new System.Windows.Forms.Label();
			this.lblGreen = new System.Windows.Forms.Label();
			this.lblBlue = new System.Windows.Forms.Label();
			this.colorDialog = new System.Windows.Forms.ColorDialog();
			this.lblCount = new System.Windows.Forms.Label();
			this.lblDesc = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblIndex
			// 
			this.lblIndex.AutoSize = true;
			this.lblIndex.Location = new System.Drawing.Point(290, 29);
			this.lblIndex.Name = "lblIndex";
			this.lblIndex.Size = new System.Drawing.Size(36, 13);
			this.lblIndex.TabIndex = 0;
			this.lblIndex.Text = "Index:";
			// 
			// lblRed
			// 
			this.lblRed.AutoSize = true;
			this.lblRed.Location = new System.Drawing.Point(291, 42);
			this.lblRed.Name = "lblRed";
			this.lblRed.Size = new System.Drawing.Size(30, 13);
			this.lblRed.TabIndex = 0;
			this.lblRed.Text = "Red:";
			// 
			// lblGreen
			// 
			this.lblGreen.AutoSize = true;
			this.lblGreen.Location = new System.Drawing.Point(290, 55);
			this.lblGreen.Name = "lblGreen";
			this.lblGreen.Size = new System.Drawing.Size(36, 13);
			this.lblGreen.TabIndex = 0;
			this.lblGreen.Text = "Green";
			// 
			// lblBlue
			// 
			this.lblBlue.AutoSize = true;
			this.lblBlue.Location = new System.Drawing.Point(290, 68);
			this.lblBlue.Name = "lblBlue";
			this.lblBlue.Size = new System.Drawing.Size(31, 13);
			this.lblBlue.TabIndex = 0;
			this.lblBlue.Text = "Blue:";
			// 
			// colorDialog
			// 
			this.colorDialog.FullOpen = true;
			// 
			// lblCount
			// 
			this.lblCount.AutoSize = true;
			this.lblCount.Location = new System.Drawing.Point(290, 81);
			this.lblCount.Name = "lblCount";
			this.lblCount.Size = new System.Drawing.Size(65, 13);
			this.lblCount.TabIndex = 1;
			this.lblCount.Text = "Color Count:";
			// 
			// lblDesc
			// 
			this.lblDesc.Location = new System.Drawing.Point(293, 132);
			this.lblDesc.Name = "lblDesc";
			this.lblDesc.Size = new System.Drawing.Size(79, 97);
			this.lblDesc.TabIndex = 3;
			this.lblDesc.Text = "Click a square to change the color. The first box is treated as transparent, rega" +
				"rdless of color.";
			// 
			// ColorsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(372, 260);
			this.Controls.Add(this.lblDesc);
			this.Controls.Add(this.lblCount);
			this.Controls.Add(this.lblBlue);
			this.Controls.Add(this.lblGreen);
			this.Controls.Add(this.lblRed);
			this.Controls.Add(this.lblIndex);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "ColorsForm";
			this.Text = "XAE Palette Dialog";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblIndex;
		private System.Windows.Forms.Label lblRed;
		private System.Windows.Forms.Label lblGreen;
		private System.Windows.Forms.Label lblBlue;
		private System.Windows.Forms.ColorDialog colorDialog;
		private System.Windows.Forms.Label lblCount;
		private System.Windows.Forms.Label lblDesc;
	}
}