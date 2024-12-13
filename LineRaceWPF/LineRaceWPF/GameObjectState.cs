﻿using SharpDX;
using System.Numerics;

namespace LineRace
{
	public class GameObjectState
	{
		public Vector2 Position { get; set; }
		public float Scale { get; set; }
		public string AnimationTitle { get; set; }
		public int CurrentSprite { get; set; }
	}
}
