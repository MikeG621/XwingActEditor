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
using System.Drawing.Imaging;
using System.Windows.Forms;
using Idmr.ImageFormat.Act;

namespace Idmr.XwingSeriesActEditor
{
	public partial class MainForm : Form
	{
		ActImage _image;
		int _frame;
		ColorsForm frmColors;
		ColorPalette _pal;
		Settings _settings = new Settings();
		bool _loading = false;

		public MainForm()
		{
			InitializeComponent();
			chkCenter.Checked = _settings.ShowCenter;
			chkAutoCenter.Checked = _settings.AutoCenter;
		}

		void ChangeCenter()
		{
			if (_loading) return;
			_image.Center = new Point((int)numCenterX.Value, (int)numCenterY.Value);
			DrawFrame();
		}
		void CheckSave()
		{
			if (_settings.AutoSave == 0) return;
			if (Text.Contains("*"))
			{
				DialogResult dr;
				if (_settings.AutoSave == Settings.SaveSetting.AutoSave) dr = DialogResult.Yes;
				else
				{
					ConfirmSaveDialog save = new ConfirmSaveDialog();
					dr = save.ShowDialog();
				}
				if (dr == DialogResult.Yes) Save();
				else if (dr == DialogResult.OK)
				{
					Save();
					_settings.AutoSave = Settings.SaveSetting.AutoSave;
				}
				else if (dr == DialogResult.Ignore) _settings.AutoSave = Settings.SaveSetting.NoSave;
			}
		}
		void DrawFrame()
		{
			try
			{
				pctAct.BackgroundImage.Palette = _pal;
				_settings.TransparentColor = _pal.Entries[0];
			}
			catch { /* do nothing */ }
			pctAct.Refresh();
			Graphics g = pctAct.CreateGraphics();
			Pen p = new Pen(Color.Red);
			try
			{
				int x = (252 - _image.Frames[_frame].Width)/2 - _image.Frames[_frame].X - _image.Center.X;
				int y = (252 - _image.Frames[_frame].Height) / 2 - _image.Frames[_frame].Y - _image.Center.Y;
				if (_image.NumberOfFrames != 1) g.DrawRectangle(p, x, y, _image.Width+1, _image.Height+1);
				if (chkCenter.Checked) g.DrawEllipse(p, x + _image.Center.X, y + _image.Center.Y, 2, 2);
			}
			catch { /* do nothing */ }
			g.Dispose();
		}
		void LoadFile()
		{
			_loading = true;
			Text = "X-wing series ACT Editor - " + _image.FileName;
			cmdExport.Enabled = true;
			pnlColors.Enabled = true;
			grpImage.Enabled = true;
			grpFrame.Enabled = true;
			bool state = (_image.NumberOfFrames > 1 ? true : false);
			pnlNavigation.Enabled = state;
			grpFrame.Enabled = state;
			_frame = 0;
			UpdateView();
			lblHeight.Text = _image.Height.ToString(); ;
			lblWidth.Text = _image.Width.ToString(); ;
			numCenterX.Maximum = _image.Width-1;
			numCenterY.Maximum = _image.Height-1;
			numCenterX.Value = _image.Center.X;
			numCenterY.Value = _image.Center.Y;
			_loading = false;
		}
		void Save()
		{
			if (_image.FilePath == "NewImage.act") cmdSaveAs_Click("Save", new EventArgs());
			else
			{
				Text.Replace("*", "");
				for (int c=0;c<_image.Frames[_frame].NumberOfColors;c++) _image.Frames[_frame].SetColor(c, _pal.Entries[c]);
				_image.Save();
			}
		}
		void UpdateView()
		{
			bool loading = _loading;
			_loading = true;
			pctAct.BackgroundImage = _image.Frames[_frame].Image;
			_pal = pctAct.BackgroundImage.Palette;
			_pal.Entries[0] = _settings.TransparentColor;
			lblFrameHeight.Text = _image.Frames[_frame].Height.ToString();
			lblFrameWidth.Text = _image.Frames[_frame].Width.ToString();
			numFrameLeft.Maximum = _image.Width - _image.Frames[_frame].Width - _image.Center.X;
			numFrameLeft.Minimum = -_image.Center.X;
			// compensate for messing with Center
			if (_image.Frames[_frame].X > numFrameLeft.Maximum) _image.Frames[_frame].X = (int)numFrameLeft.Maximum;
			if (_image.Frames[_frame].X < numFrameLeft.Minimum) _image.Frames[_frame].X = (int)numFrameLeft.Minimum;
			numFrameLeft.Value = _image.Frames[_frame].X;
			numFrameTop.Maximum = _image.Height - _image.Frames[_frame].Height - _image.Center.Y;
			numFrameTop.Minimum = -_image.Center.Y;
			if (_image.Frames[_frame].Y > numFrameTop.Maximum) _image.Frames[_frame].Y = (int)numFrameTop.Maximum;
			if (_image.Frames[_frame].Y < numFrameTop.Minimum) _image.Frames[_frame].Y = (int)numFrameTop.Minimum;
			numFrameTop.Value = _image.Frames[_frame].Y;
			_loading = loading;
			lblColorCount.Text = _image.Frames[_frame].NumberOfColors.ToString();
			DrawFrame();
			lblFrame.Text = "Frame " + (_frame+1) + " of " + _image.NumberOfFrames;
		}

		private void chkAutoCenter_CheckedChanged(object sender, EventArgs e)
		{
			_settings.AutoCenter = chkAutoCenter.Checked;
		}
		private void chkCenter_CheckedChanged(object sender, EventArgs e)
		{
			DrawFrame();
			_settings.ShowCenter = chkCenter.Checked;
		}

		private void cmdColors_Click(object sender, EventArgs e)
		{
			try { frmColors.Close(); }
			catch { /* do nothing */ }
			frmColors = new ColorsForm(ref _pal, _image.Frames[_frame].NumberOfColors);
			frmColors.Show();
			if (!Text.Contains("*")) Text += "*";
		}
		private void cmdCopy_Click(object sender, EventArgs e)
		{
			if (_image == null)
			{
				try { _image = new ActImage((Bitmap)pctImport.BackgroundImage); }
				catch (Exception x)
				{
					_image = null;
					Text = "X-wing series ACT Editor";
					pnlNavigation.Enabled = false;
					pnlColors.Enabled = false;
					lblFrame.Text = "Frame 0 of 0";
					grpImage.Enabled = false;
					grpFrame.Enabled = false;
					pctAct.BackgroundImage = null;
					cmdExport.Enabled = false;
					MessageBox.Show(x.Message);
					return;
				}
				LoadFile();
				txtFile.Text = _image.FilePath;
			}
			else
			{
				_image.Frames[_frame].Image = (Bitmap)pctImport.BackgroundImage;
				lblHeight.Text = _image.Height.ToString();
				lblWidth.Text = _image.Width.ToString();
				if (chkAutoCenter.Checked)
				{
					if (_image.NumberOfFrames == 1)
					{
						_loading = true;
						numCenterX.Maximum = _image.Width - 1;
						numCenterY.Maximum = _image.Height - 1;
						numCenterX.Value = _image.Width / 2;
						numCenterY.Value = _image.Height / 2;
						_loading = false;
						ChangeCenter();
					}
					_image.Frames[0].X = -_image.Frames[0].Width / 2;
					_image.Frames[0].Y = -_image.Frames[0].Height / 2;
				}
				UpdateView();
			}
			if (!Text.Contains("*")) Text += "*";
		}
		private void cmdExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		private void cmdExport_Click(object sender, EventArgs e)
		{
			savBitmap.FileName = _image.FileName.Remove(_image.FileName.LastIndexOf("."));
			if (_image.NumberOfFrames > 1) savBitmap.FileName += "_" + (_frame+1);
			savBitmap.ShowDialog();
		}
		private void cmdImport_Click(object sender, EventArgs e)
		{
			opnBitmap.ShowDialog();
		}
		private void cmdNext_Click(object sender, EventArgs e)
		{
			if ((_frame+1) == _image.NumberOfFrames) return;
			_frame++;
			UpdateView();
		}
		private void cmdOpen_Click(object sender, EventArgs e)
		{
			try { frmColors.Close(); }
			catch { /* do nothing */ }
			CheckSave();
			opnAct.ShowDialog();
		}
		private void cmdPrev_Click(object sender, EventArgs e)
		{
			if (_frame == 0) return;
			_frame--;
			UpdateView();
		}
		private void cmdSave_Click(object sender, EventArgs e)
		{
			Save();
		}
		private void cmdSaveAs_Click(object sender, EventArgs e)
		{
			savAct.FileName = _image.FilePath;
			savAct.ShowDialog();
		}

		private void MainForm_Activated(object sender, EventArgs e)
		{
			DrawFrame();
		}
		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			CheckSave();
			_settings.SaveSettings();
		}

		private void numCenterX_ValueChanged(object sender, EventArgs e)
		{
			ChangeCenter();
			numFrameLeft.Maximum = _image.Width - _image.Frames[_frame].Width - _image.Center.X;
			numFrameLeft.Minimum = -_image.Center.X;
		}
		private void numCenterY_ValueChanged(object sender, EventArgs e)
		{
			ChangeCenter();
			numFrameTop.Maximum = _image.Height - _image.Frames[_frame].Height - _image.Center.Y;
			numFrameTop.Minimum = -_image.Center.Y;
		}
		private void numFrameLeft_ValueChanged(object sender, EventArgs e)
		{
			if (_loading) return;
			_image.Frames[_frame].X = (int)numFrameLeft.Value;
			DrawFrame();
		}
		private void numFrameTop_ValueChanged(object sender, EventArgs e)
		{
			if (_loading) return;
			_image.Frames[_frame].Y = (int)numFrameTop.Value;
			DrawFrame();
		}

		private void opnAct_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			txtFile.Text = opnAct.FileName;
			try { _image = new ActImage(txtFile.Text); }
			catch (Exception x)
			{
				_image = null;
				Text = "X-wing series ACT Editor";
				pnlNavigation.Enabled = false;
				pnlColors.Enabled = false;
				lblFrame.Text = "Frame 0 of 0";
				grpImage.Enabled = false;
				grpFrame.Enabled = false;
				pctAct.BackgroundImage = null;
				cmdExport.Enabled = false;
				System.Diagnostics.Debug.WriteLine(x.StackTrace);
				MessageBox.Show(x.Message);
				return;
			}
			LoadFile();
		}
		private void opnBitmap_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			grpImport.Enabled = true;
			Bitmap image = new Bitmap(opnBitmap.FileName);
			lblImportHeight.Text = image.Height.ToString();
			lblImportWidth.Text = image.Width.ToString();
			pctImport.BackgroundImage = image;
		}

		private void savAct_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			for (int c=0;c<_image.Frames[_frame].NumberOfColors;c++) _image.Frames[_frame].SetColor(c, _pal.Entries[c]);
			_image.Save(savAct.FileName);
			Text = "X-wing series ACT Editor - " + _image.FileName;
			txtFile.Text = _image.FilePath;
		}
		private void savBitmap_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			pctAct.BackgroundImage.Save(savBitmap.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
		}

		private void txtFile_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 0xD) LoadFile();
		}
	}
}