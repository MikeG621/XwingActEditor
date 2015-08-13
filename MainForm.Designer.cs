/*
 * X-wing series ACT Editor, Creates and edits LucasArts *.ACT image files.
 * Copyright (C) 2009 Michael Gaisser (jaggedfel621@gmail.com)
 * 
 * Full notice in MainForm.cs
 */

namespace Idmr.XwingSeriesActEditor
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.cmdOpen = new System.Windows.Forms.Button();
			this.txtFile = new System.Windows.Forms.TextBox();
			this.pctAct = new System.Windows.Forms.PictureBox();
			this.opnAct = new System.Windows.Forms.OpenFileDialog();
			this.cmdPrev = new System.Windows.Forms.Button();
			this.cmdNext = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.grpImage = new System.Windows.Forms.GroupBox();
			this.chkCenter = new System.Windows.Forms.CheckBox();
			this.numCenterY = new System.Windows.Forms.NumericUpDown();
			this.numCenterX = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblHeight = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblWidth = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pnlNavigation = new System.Windows.Forms.Panel();
			this.lblFrame = new System.Windows.Forms.Label();
			this.grpFrame = new System.Windows.Forms.GroupBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.numFrameLeft = new System.Windows.Forms.NumericUpDown();
			this.lblFrameHeight = new System.Windows.Forms.Label();
			this.numFrameTop = new System.Windows.Forms.NumericUpDown();
			this.lblFrameWidth = new System.Windows.Forms.Label();
			this.cmdColors = new System.Windows.Forms.Button();
			this.pnlColors = new System.Windows.Forms.Panel();
			this.lblColorCount = new System.Windows.Forms.Label();
			this.savAct = new System.Windows.Forms.SaveFileDialog();
			this.cmdSave = new System.Windows.Forms.Button();
			this.cmdSaveAs = new System.Windows.Forms.Button();
			this.savBitmap = new System.Windows.Forms.SaveFileDialog();
			this.cmdExport = new System.Windows.Forms.Button();
			this.pctImport = new System.Windows.Forms.PictureBox();
			this.grpImport = new System.Windows.Forms.GroupBox();
			this.label10 = new System.Windows.Forms.Label();
			this.lblImportWidth = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.lblImportHeight = new System.Windows.Forms.Label();
			this.chkAutoCenter = new System.Windows.Forms.CheckBox();
			this.cmdCopy = new System.Windows.Forms.Button();
			this.cmdExit = new System.Windows.Forms.Button();
			this.opnBitmap = new System.Windows.Forms.OpenFileDialog();
			this.cmdImport = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pctAct)).BeginInit();
			this.grpImage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numCenterY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numCenterX)).BeginInit();
			this.pnlNavigation.SuspendLayout();
			this.grpFrame.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numFrameLeft)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numFrameTop)).BeginInit();
			this.pnlColors.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctImport)).BeginInit();
			this.grpImport.SuspendLayout();
			this.SuspendLayout();
			// 
			// cmdOpen
			// 
			this.cmdOpen.Image = ((System.Drawing.Image)(resources.GetObject("cmdOpen.Image")));
			this.cmdOpen.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
			this.cmdOpen.Location = new System.Drawing.Point(14, 10);
			this.cmdOpen.Name = "cmdOpen";
			this.cmdOpen.Size = new System.Drawing.Size(23, 23);
			this.cmdOpen.TabIndex = 0;
			this.cmdOpen.UseVisualStyleBackColor = true;
			this.cmdOpen.Click += new System.EventHandler(this.cmdOpen_Click);
			// 
			// txtFile
			// 
			this.txtFile.Location = new System.Drawing.Point(43, 12);
			this.txtFile.Name = "txtFile";
			this.txtFile.Size = new System.Drawing.Size(345, 20);
			this.txtFile.TabIndex = 1;
			this.txtFile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFile_KeyPress);
			// 
			// pctAct
			// 
			this.pctAct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pctAct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pctAct.Location = new System.Drawing.Point(12, 56);
			this.pctAct.Name = "pctAct";
			this.pctAct.Size = new System.Drawing.Size(256, 256);
			this.pctAct.TabIndex = 2;
			this.pctAct.TabStop = false;
			// 
			// opnAct
			// 
			this.opnAct.DefaultExt = "act";
			this.opnAct.Filter = "ACT files|*.act";
			this.opnAct.FileOk += new System.ComponentModel.CancelEventHandler(this.opnAct_FileOk);
			// 
			// cmdPrev
			// 
			this.cmdPrev.Location = new System.Drawing.Point(3, 3);
			this.cmdPrev.Name = "cmdPrev";
			this.cmdPrev.Size = new System.Drawing.Size(75, 23);
			this.cmdPrev.TabIndex = 3;
			this.cmdPrev.Text = "Prev";
			this.cmdPrev.UseVisualStyleBackColor = true;
			this.cmdPrev.Click += new System.EventHandler(this.cmdPrev_Click);
			// 
			// cmdNext
			// 
			this.cmdNext.Location = new System.Drawing.Point(84, 3);
			this.cmdNext.Name = "cmdNext";
			this.cmdNext.Size = new System.Drawing.Size(75, 23);
			this.cmdNext.TabIndex = 3;
			this.cmdNext.Text = "Next";
			this.cmdNext.UseVisualStyleBackColor = true;
			this.cmdNext.Click += new System.EventHandler(this.cmdNext_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(3, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(65, 13);
			this.label9.TabIndex = 4;
			this.label9.Text = "Color Count:";
			// 
			// grpImage
			// 
			this.grpImage.Controls.Add(this.chkCenter);
			this.grpImage.Controls.Add(this.numCenterY);
			this.grpImage.Controls.Add(this.numCenterX);
			this.grpImage.Controls.Add(this.label4);
			this.grpImage.Controls.Add(this.label3);
			this.grpImage.Controls.Add(this.lblHeight);
			this.grpImage.Controls.Add(this.label2);
			this.grpImage.Controls.Add(this.lblWidth);
			this.grpImage.Controls.Add(this.label1);
			this.grpImage.Enabled = false;
			this.grpImage.Location = new System.Drawing.Point(274, 51);
			this.grpImage.Name = "grpImage";
			this.grpImage.Size = new System.Drawing.Size(114, 139);
			this.grpImage.TabIndex = 5;
			this.grpImage.TabStop = false;
			this.grpImage.Text = "Image";
			// 
			// chkCenter
			// 
			this.chkCenter.AutoSize = true;
			this.chkCenter.Location = new System.Drawing.Point(6, 66);
			this.chkCenter.Name = "chkCenter";
			this.chkCenter.Size = new System.Drawing.Size(87, 17);
			this.chkCenter.TabIndex = 2;
			this.chkCenter.Text = "Show Center";
			this.chkCenter.UseVisualStyleBackColor = true;
			this.chkCenter.CheckedChanged += new System.EventHandler(this.chkCenter_CheckedChanged);
			// 
			// numCenterY
			// 
			this.numCenterY.Location = new System.Drawing.Point(57, 110);
			this.numCenterY.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.numCenterY.Name = "numCenterY";
			this.numCenterY.Size = new System.Drawing.Size(47, 20);
			this.numCenterY.TabIndex = 1;
			this.numCenterY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numCenterY.Value = new decimal(new int[] {
            127,
            0,
            0,
            0});
			this.numCenterY.ValueChanged += new System.EventHandler(this.numCenterY_ValueChanged);
			// 
			// numCenterX
			// 
			this.numCenterX.Location = new System.Drawing.Point(57, 84);
			this.numCenterX.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.numCenterX.Name = "numCenterX";
			this.numCenterX.Size = new System.Drawing.Size(47, 20);
			this.numCenterX.TabIndex = 1;
			this.numCenterX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numCenterX.Value = new decimal(new int[] {
            127,
            0,
            0,
            0});
			this.numCenterX.ValueChanged += new System.EventHandler(this.numCenterX_ValueChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 112);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "CenterY";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 86);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "CenterX";
			// 
			// lblHeight
			// 
			this.lblHeight.Location = new System.Drawing.Point(78, 42);
			this.lblHeight.Name = "lblHeight";
			this.lblHeight.Size = new System.Drawing.Size(25, 13);
			this.lblHeight.TabIndex = 0;
			this.lblHeight.Text = "256";
			this.lblHeight.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Height:";
			// 
			// lblWidth
			// 
			this.lblWidth.Location = new System.Drawing.Point(78, 16);
			this.lblWidth.Name = "lblWidth";
			this.lblWidth.Size = new System.Drawing.Size(25, 13);
			this.lblWidth.TabIndex = 0;
			this.lblWidth.Text = "256";
			this.lblWidth.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Width:";
			// 
			// pnlNavigation
			// 
			this.pnlNavigation.Controls.Add(this.lblFrame);
			this.pnlNavigation.Controls.Add(this.cmdPrev);
			this.pnlNavigation.Controls.Add(this.cmdNext);
			this.pnlNavigation.Enabled = false;
			this.pnlNavigation.Location = new System.Drawing.Point(12, 315);
			this.pnlNavigation.Name = "pnlNavigation";
			this.pnlNavigation.Size = new System.Drawing.Size(162, 46);
			this.pnlNavigation.TabIndex = 6;
			// 
			// lblFrame
			// 
			this.lblFrame.Location = new System.Drawing.Point(30, 29);
			this.lblFrame.Name = "lblFrame";
			this.lblFrame.Size = new System.Drawing.Size(100, 13);
			this.lblFrame.TabIndex = 4;
			this.lblFrame.Text = "Frame 0 of 0";
			this.lblFrame.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// grpFrame
			// 
			this.grpFrame.Controls.Add(this.label8);
			this.grpFrame.Controls.Add(this.label5);
			this.grpFrame.Controls.Add(this.label7);
			this.grpFrame.Controls.Add(this.label6);
			this.grpFrame.Controls.Add(this.numFrameLeft);
			this.grpFrame.Controls.Add(this.lblFrameHeight);
			this.grpFrame.Controls.Add(this.numFrameTop);
			this.grpFrame.Controls.Add(this.lblFrameWidth);
			this.grpFrame.Enabled = false;
			this.grpFrame.Location = new System.Drawing.Point(273, 194);
			this.grpFrame.Name = "grpFrame";
			this.grpFrame.Size = new System.Drawing.Size(115, 118);
			this.grpFrame.TabIndex = 7;
			this.grpFrame.TabStop = false;
			this.grpFrame.Text = "Frame";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 68);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(28, 13);
			this.label8.TabIndex = 0;
			this.label8.Text = "Left:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(38, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "Width:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 94);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(29, 13);
			this.label7.TabIndex = 0;
			this.label7.Text = "Top:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 42);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(41, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "Height:";
			// 
			// numFrameLeft
			// 
			this.numFrameLeft.Location = new System.Drawing.Point(57, 66);
			this.numFrameLeft.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
			this.numFrameLeft.Minimum = new decimal(new int[] {
            127,
            0,
            0,
            -2147483648});
			this.numFrameLeft.Name = "numFrameLeft";
			this.numFrameLeft.Size = new System.Drawing.Size(47, 20);
			this.numFrameLeft.TabIndex = 1;
			this.numFrameLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numFrameLeft.Value = new decimal(new int[] {
            127,
            0,
            0,
            -2147483648});
			this.numFrameLeft.ValueChanged += new System.EventHandler(this.numFrameLeft_ValueChanged);
			// 
			// lblFrameHeight
			// 
			this.lblFrameHeight.Location = new System.Drawing.Point(79, 42);
			this.lblFrameHeight.Name = "lblFrameHeight";
			this.lblFrameHeight.Size = new System.Drawing.Size(25, 13);
			this.lblFrameHeight.TabIndex = 0;
			this.lblFrameHeight.Text = "256";
			this.lblFrameHeight.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// numFrameTop
			// 
			this.numFrameTop.Location = new System.Drawing.Point(57, 92);
			this.numFrameTop.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
			this.numFrameTop.Minimum = new decimal(new int[] {
            127,
            0,
            0,
            -2147483648});
			this.numFrameTop.Name = "numFrameTop";
			this.numFrameTop.Size = new System.Drawing.Size(47, 20);
			this.numFrameTop.TabIndex = 1;
			this.numFrameTop.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numFrameTop.Value = new decimal(new int[] {
            127,
            0,
            0,
            -2147483648});
			this.numFrameTop.ValueChanged += new System.EventHandler(this.numFrameTop_ValueChanged);
			// 
			// lblFrameWidth
			// 
			this.lblFrameWidth.Location = new System.Drawing.Point(79, 16);
			this.lblFrameWidth.Name = "lblFrameWidth";
			this.lblFrameWidth.Size = new System.Drawing.Size(25, 13);
			this.lblFrameWidth.TabIndex = 0;
			this.lblFrameWidth.Text = "256";
			this.lblFrameWidth.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// cmdColors
			// 
			this.cmdColors.Location = new System.Drawing.Point(6, 16);
			this.cmdColors.Name = "cmdColors";
			this.cmdColors.Size = new System.Drawing.Size(54, 23);
			this.cmdColors.TabIndex = 8;
			this.cmdColors.Text = "Colors...";
			this.cmdColors.UseVisualStyleBackColor = true;
			this.cmdColors.Click += new System.EventHandler(this.cmdColors_Click);
			// 
			// pnlColors
			// 
			this.pnlColors.Controls.Add(this.lblColorCount);
			this.pnlColors.Controls.Add(this.label9);
			this.pnlColors.Controls.Add(this.cmdColors);
			this.pnlColors.Enabled = false;
			this.pnlColors.Location = new System.Drawing.Point(268, 318);
			this.pnlColors.Name = "pnlColors";
			this.pnlColors.Size = new System.Drawing.Size(120, 43);
			this.pnlColors.TabIndex = 10;
			// 
			// lblColorCount
			// 
			this.lblColorCount.Location = new System.Drawing.Point(76, 0);
			this.lblColorCount.Name = "lblColorCount";
			this.lblColorCount.Size = new System.Drawing.Size(34, 13);
			this.lblColorCount.TabIndex = 10;
			this.lblColorCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// savAct
			// 
			this.savAct.DefaultExt = "act";
			this.savAct.Filter = "ACT Files|*.act";
			this.savAct.FileOk += new System.ComponentModel.CancelEventHandler(this.savAct_FileOk);
			// 
			// cmdSave
			// 
			this.cmdSave.Image = ((System.Drawing.Image)(resources.GetObject("cmdSave.Image")));
			this.cmdSave.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
			this.cmdSave.Location = new System.Drawing.Point(394, 10);
			this.cmdSave.Name = "cmdSave";
			this.cmdSave.Size = new System.Drawing.Size(23, 23);
			this.cmdSave.TabIndex = 11;
			this.cmdSave.UseVisualStyleBackColor = true;
			this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
			// 
			// cmdSaveAs
			// 
			this.cmdSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("cmdSaveAs.Image")));
			this.cmdSaveAs.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
			this.cmdSaveAs.Location = new System.Drawing.Point(417, 10);
			this.cmdSaveAs.Name = "cmdSaveAs";
			this.cmdSaveAs.Size = new System.Drawing.Size(23, 23);
			this.cmdSaveAs.TabIndex = 11;
			this.cmdSaveAs.UseVisualStyleBackColor = true;
			this.cmdSaveAs.Click += new System.EventHandler(this.cmdSaveAs_Click);
			// 
			// savBitmap
			// 
			this.savBitmap.DefaultExt = "bmp";
			this.savBitmap.Filter = "Bitmaps|*.bmp";
			this.savBitmap.FileOk += new System.ComponentModel.CancelEventHandler(this.savBitmap_FileOk);
			// 
			// cmdExport
			// 
			this.cmdExport.Enabled = false;
			this.cmdExport.Location = new System.Drawing.Point(187, 318);
			this.cmdExport.Name = "cmdExport";
			this.cmdExport.Size = new System.Drawing.Size(75, 23);
			this.cmdExport.TabIndex = 12;
			this.cmdExport.Text = "&Export...";
			this.cmdExport.UseVisualStyleBackColor = true;
			this.cmdExport.Click += new System.EventHandler(this.cmdExport_Click);
			// 
			// pctImport
			// 
			this.pctImport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pctImport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pctImport.Location = new System.Drawing.Point(494, 56);
			this.pctImport.Name = "pctImport";
			this.pctImport.Size = new System.Drawing.Size(256, 256);
			this.pctImport.TabIndex = 13;
			this.pctImport.TabStop = false;
			// 
			// grpImport
			// 
			this.grpImport.Controls.Add(this.cmdCopy);
			this.grpImport.Controls.Add(this.chkAutoCenter);
			this.grpImport.Controls.Add(this.label10);
			this.grpImport.Controls.Add(this.lblImportWidth);
			this.grpImport.Controls.Add(this.label12);
			this.grpImport.Controls.Add(this.lblImportHeight);
			this.grpImport.Enabled = false;
			this.grpImport.Location = new System.Drawing.Point(394, 51);
			this.grpImport.Name = "grpImport";
			this.grpImport.Size = new System.Drawing.Size(94, 125);
			this.grpImport.TabIndex = 14;
			this.grpImport.TabStop = false;
			this.grpImport.Text = "Import";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(6, 16);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(38, 13);
			this.label10.TabIndex = 0;
			this.label10.Text = "Width:";
			// 
			// lblImportWidth
			// 
			this.lblImportWidth.Location = new System.Drawing.Point(63, 16);
			this.lblImportWidth.Name = "lblImportWidth";
			this.lblImportWidth.Size = new System.Drawing.Size(25, 13);
			this.lblImportWidth.TabIndex = 0;
			this.lblImportWidth.Text = "256";
			this.lblImportWidth.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(6, 42);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(41, 13);
			this.label12.TabIndex = 0;
			this.label12.Text = "Height:";
			// 
			// lblImportHeight
			// 
			this.lblImportHeight.Location = new System.Drawing.Point(63, 42);
			this.lblImportHeight.Name = "lblImportHeight";
			this.lblImportHeight.Size = new System.Drawing.Size(25, 13);
			this.lblImportHeight.TabIndex = 0;
			this.lblImportHeight.Text = "256";
			this.lblImportHeight.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// chkAutoCenter
			// 
			this.chkAutoCenter.AutoSize = true;
			this.chkAutoCenter.Location = new System.Drawing.Point(9, 66);
			this.chkAutoCenter.Name = "chkAutoCenter";
			this.chkAutoCenter.Size = new System.Drawing.Size(82, 17);
			this.chkAutoCenter.TabIndex = 1;
			this.chkAutoCenter.Text = "Auto Center";
			this.chkAutoCenter.UseVisualStyleBackColor = true;
			this.chkAutoCenter.CheckedChanged += new System.EventHandler(this.chkAutoCenter_CheckedChanged);
			// 
			// cmdCopy
			// 
			this.cmdCopy.Location = new System.Drawing.Point(6, 89);
			this.cmdCopy.Name = "cmdCopy";
			this.cmdCopy.Size = new System.Drawing.Size(82, 25);
			this.cmdCopy.TabIndex = 2;
			this.cmdCopy.Text = "<- Copy";
			this.cmdCopy.UseVisualStyleBackColor = true;
			this.cmdCopy.Click += new System.EventHandler(this.cmdCopy_Click);
			// 
			// cmdExit
			// 
			this.cmdExit.Location = new System.Drawing.Point(675, 318);
			this.cmdExit.Name = "cmdExit";
			this.cmdExit.Size = new System.Drawing.Size(75, 23);
			this.cmdExit.TabIndex = 15;
			this.cmdExit.Text = "E&xit";
			this.cmdExit.UseVisualStyleBackColor = true;
			this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
			// 
			// opnBitmap
			// 
			this.opnBitmap.DefaultExt = "bmp";
			this.opnBitmap.Filter = "Bitmaps|*.bmp";
			this.opnBitmap.FileOk += new System.ComponentModel.CancelEventHandler(this.opnBitmap_FileOk);
			// 
			// cmdImport
			// 
			this.cmdImport.Location = new System.Drawing.Point(394, 182);
			this.cmdImport.Name = "cmdImport";
			this.cmdImport.Size = new System.Drawing.Size(94, 23);
			this.cmdImport.TabIndex = 16;
			this.cmdImport.Text = "Import...";
			this.cmdImport.UseVisualStyleBackColor = true;
			this.cmdImport.Click += new System.EventHandler(this.cmdImport_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(762, 369);
			this.Controls.Add(this.cmdImport);
			this.Controls.Add(this.cmdExit);
			this.Controls.Add(this.grpImport);
			this.Controls.Add(this.pctImport);
			this.Controls.Add(this.cmdExport);
			this.Controls.Add(this.cmdSaveAs);
			this.Controls.Add(this.cmdSave);
			this.Controls.Add(this.pnlColors);
			this.Controls.Add(this.grpFrame);
			this.Controls.Add(this.pnlNavigation);
			this.Controls.Add(this.grpImage);
			this.Controls.Add(this.pctAct);
			this.Controls.Add(this.txtFile);
			this.Controls.Add(this.cmdOpen);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "X-wing series ACT Editor";
			this.Activated += new System.EventHandler(this.MainForm_Activated);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.pctAct)).EndInit();
			this.grpImage.ResumeLayout(false);
			this.grpImage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numCenterY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numCenterX)).EndInit();
			this.pnlNavigation.ResumeLayout(false);
			this.grpFrame.ResumeLayout(false);
			this.grpFrame.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numFrameLeft)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numFrameTop)).EndInit();
			this.pnlColors.ResumeLayout(false);
			this.pnlColors.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctImport)).EndInit();
			this.grpImport.ResumeLayout(false);
			this.grpImport.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button cmdOpen;
		private System.Windows.Forms.TextBox txtFile;
		private System.Windows.Forms.PictureBox pctAct;
		private System.Windows.Forms.OpenFileDialog opnAct;
		private System.Windows.Forms.Button cmdPrev;
		private System.Windows.Forms.Button cmdNext;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.GroupBox grpImage;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel pnlNavigation;
		private System.Windows.Forms.Label lblFrame;
		private System.Windows.Forms.CheckBox chkCenter;
		private System.Windows.Forms.NumericUpDown numCenterY;
		private System.Windows.Forms.NumericUpDown numCenterX;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox grpFrame;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.NumericUpDown numFrameLeft;
		private System.Windows.Forms.NumericUpDown numFrameTop;
		private System.Windows.Forms.Button cmdColors;
		private System.Windows.Forms.Panel pnlColors;
		private System.Windows.Forms.Label lblColorCount;
		private System.Windows.Forms.SaveFileDialog savAct;
		private System.Windows.Forms.Button cmdSave;
		private System.Windows.Forms.Button cmdSaveAs;
		private System.Windows.Forms.Label lblHeight;
		private System.Windows.Forms.Label lblWidth;
		private System.Windows.Forms.Label lblFrameHeight;
		private System.Windows.Forms.Label lblFrameWidth;
		private System.Windows.Forms.SaveFileDialog savBitmap;
		private System.Windows.Forms.Button cmdExport;
		private System.Windows.Forms.PictureBox pctImport;
		private System.Windows.Forms.GroupBox grpImport;
		private System.Windows.Forms.Button cmdCopy;
		private System.Windows.Forms.CheckBox chkAutoCenter;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label lblImportWidth;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label lblImportHeight;
		private System.Windows.Forms.Button cmdExit;
		private System.Windows.Forms.OpenFileDialog opnBitmap;
		private System.Windows.Forms.Button cmdImport;
	}
}

