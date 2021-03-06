﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Myra.Graphics2D.TextureAtlases;
using Myra.Graphics2D.UI;
using Myra.Graphics2D.UI.Styles;
using XNAssets;

namespace Myra.Samples.CustomUIStylesheet
{
	public class CustomUIStylesheetGame : Game
	{
		private readonly GraphicsDeviceManager _graphics;

		private AllWidgets _allWidgets;

		public CustomUIStylesheetGame()
		{
			_graphics = new GraphicsDeviceManager(this)
			{
				PreferredBackBufferWidth = 1200,
				PreferredBackBufferHeight = 800
			};

			IsMouseVisible = true;
			Window.AllowUserResizing = true;
		}

		protected override void LoadContent()
		{
			base.LoadContent();

			MyraEnvironment.Game = this;

			// Create asset manager
			var assetManager = new AssetManager(GraphicsDevice, new ResourceAssetResolver(typeof(CustomUIStylesheetGame).Assembly, "Resources"));

			// Load stylesheet
			Stylesheet.Current = assetManager.Load<Stylesheet>("ui_stylesheet.xml");

			_allWidgets = new AllWidgets();
			var textureAtlas = assetManager.Load<TextureRegionAtlas>("ui_stylesheet_atlas.xml");
			_allWidgets._button.Image = textureAtlas["music-off"];
			_allWidgets._imageButton.Image = textureAtlas["sound-off"];

			Desktop.Widgets.Add(_allWidgets);
		}

		protected override void Update(GameTime gameTime)
		{
			base.Update(gameTime);

			_allWidgets._horizontalProgressBar.Value += 0.5f;
			if (_allWidgets._horizontalProgressBar.Value > _allWidgets._horizontalProgressBar.Maximum)
			{
				_allWidgets._horizontalProgressBar.Value = _allWidgets._horizontalProgressBar.Minimum;
			}

			_allWidgets._verticalProgressBar.Value += 0.5f;
			if (_allWidgets._verticalProgressBar.Value > _allWidgets._verticalProgressBar.Maximum)
			{
				_allWidgets._verticalProgressBar.Value = _allWidgets._verticalProgressBar.Minimum;
			}
		}

		protected override void Draw(GameTime gameTime)
		{
			base.Draw(gameTime);

			GraphicsDevice.Clear(Color.Black);

			Desktop.Render();
		}
	}
}