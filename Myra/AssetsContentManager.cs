﻿using System;
using System.IO;
using Microsoft.Xna.Framework.Content;

namespace Myra
{
	internal class AssetsContentManager : ContentManager
	{
		public AssetsContentManager(IServiceProvider servicesProvider)
			: base(servicesProvider)
		{
		}

		protected override Stream OpenStream(string assetName)
		{
			return Resources.Resources.GetBinaryResourceStream(assetName);
		}
	}
}
