﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;

namespace Microsoft.Xna.Framework.Graphics
{
	public partial class RenderTarget2D
	{
		public UnityEngine.RenderTexture UnityRenderTexture
		{
			get { return (UnityEngine.RenderTexture)texture; }
			private set { texture = value; }
		}

		public RenderTarget2D(UnityEngine.RenderTexture texture) 
			: base(texture)
		{
			this.width = texture.width;
			this.height = texture.height;
			this._levelCount = 1;
		}

		private void PlatformConstruct(GraphicsDevice graphicsDevice, int width, int height, bool mipMap, SurfaceFormat preferredFormat, DepthFormat preferredDepthFormat, int preferredMultiSampleCount, RenderTargetUsage usage, bool shared)
		{
			UnityRenderTexture = new UnityEngine.RenderTexture(width, height, 1);
			UnityRenderTexture.Create();
		}

		private void PlatformGraphicsDeviceResetting()
		{
			throw new NotImplementedException();
		}
	}
}