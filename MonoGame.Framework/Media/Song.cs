﻿using System;
using UnityEngine;

namespace Microsoft.Xna.Framework.Media
{
	public class Song
	{
		internal readonly AudioClip AudioClip;

		public Song(AudioClip audioClip)
		{
			AudioClip = audioClip;
		}

		public TimeSpan Duration
		{
			get { return TimeSpan.FromSeconds(AudioClip.length); }
		}
	}
}
