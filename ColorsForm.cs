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

namespace Idmr.XwingSeriesActEditor
{
	public partial class ColorsForm : Form
	{
		Panel[] pnlColors = new Panel[256];
		ColorPalette _palette;
		int _numberOfColors = 0;

		public ColorsForm(ref ColorPalette palette, int numberOfColors)
		{
			InitializeComponent();
			Height = 316;
			_palette = palette;
			_numberOfColors = numberOfColors;
			for (int y=0, i=0;y<16;y++)
				for (int x=0;(x<16 && i<_numberOfColors);x++, i++)
				{
					pnlColors[i] = new Panel();
					pnlColors[i].Tag = i;
					pnlColors[i].Click += new EventHandler(pnlColors_Click);
					pnlColors[i].MouseEnter += new EventHandler(pnlColors_MouseEnter);
					pnlColors[i].Size = new Size(16, 16);
					pnlColors[i].Left = x*16 + 20;
					pnlColors[i].Top = y*16 + 20;
					pnlColors[i].BackColor = _palette.Entries[i];
					pnlColors[i].BorderStyle = BorderStyle.FixedSingle;
					this.Controls.Add(pnlColors[i]);
				}
			lblCount.Text = "Color Count: " + _numberOfColors;
		}

		void pnlColors_Click(object sender, EventArgs e)
		{
			colorDialog.Color = _palette.Entries[(int)((Panel)sender).Tag];
			if (colorDialog.ShowDialog() != DialogResult.Cancel)
			{
				int index = (int)((Panel)sender).Tag;
				Color c = colorDialog.Color;
				for (int i=0;i<_numberOfColors;i++)
					if (_palette.Entries[i] == c && i != index)
						MessageBox.Show("Duplicate entry for (" + c.R + "," + c.G + "," + c.B + ") found at index " + i);
				pnlColors[index].BackColor = c;
				_palette.Entries[index] = c;
			}
		}
		void pnlColors_MouseEnter(object sender, EventArgs e)
		{
			int i = (int)((Panel)sender).Tag;
			lblIndex.Text = "Index: " + i.ToString();
			lblRed.Text = "Red: " + pnlColors[i].BackColor.R;
			lblGreen.Text = "Green: " + pnlColors[i].BackColor.G;
			lblBlue.Text = "Blue: " + pnlColors[i].BackColor.B;
		}
	}
}
