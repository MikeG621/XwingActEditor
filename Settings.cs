/*
 * X-wing series ACT Editor, Creates and edits LucasArts *.ACT image files.
 * Copyright (C) 2009 Michael Gaisser (jaggedfel621@gmail.com)
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
using System.IO;

namespace Idmr.XwingSeriesActEditor
{
	public class Settings
	{
		public bool ShowCenter = true;
		public bool AutoCenter = true;
		private int _transparentColor = 0xFF00FF;
		public SaveSetting AutoSave = SaveSetting.Ask;
		string _settingsDir = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) 
			+ "\\Imperial Department of Military Research\\Act Editor";

		public enum SaveSetting : byte { NoSave, AutoSave, Ask }

		public Settings()
		{
			LoadSettings();
		}

		public void LoadSettings()
		{
			string settingsFile = _settingsDir + "\\Settings.dat";
			if (!File.Exists(settingsFile)) SaveSettings();
			else
			{
				FileStream fs = File.OpenRead(settingsFile);
				BinaryReader br = new BinaryReader(fs);
				ShowCenter = br.ReadBoolean();
				AutoCenter = br.ReadBoolean();
				_transparentColor = br.ReadInt32();
				AutoSave = (SaveSetting)br.ReadByte();
				fs.Close();
			}
		}

		public void SaveSettings()
		{
			if (!Directory.Exists(_settingsDir)) Directory.CreateDirectory(_settingsDir);
			FileStream fs = File.OpenWrite(_settingsDir + "\\Settings.dat");
			BinaryWriter bw = new BinaryWriter(fs);
			bw.Write(ShowCenter);
			bw.Write(AutoCenter);
			bw.Write(_transparentColor);
			bw.Write((byte)AutoSave);
			fs.Close();
		}

		public System.Drawing.Color TransparentColor
		{
			get { return System.Drawing.Color.FromArgb((_transparentColor & 0xFF0000)>>16, (_transparentColor & 0xFF00)>>8, _transparentColor & 0xFF); }
			set { _transparentColor = (value.R << 16) + (value.G << 8) + value.B; }
		}

		/*
		 * BOOL ShowCenter (true)
		 * BOOL AutoCenter (true)
		 * INT  TransparentColor (0xFF00FF)
		 * BYTE	AutoSave (2)
		 */
	}
}
