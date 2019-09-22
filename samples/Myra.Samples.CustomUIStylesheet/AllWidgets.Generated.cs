/* Generated by MyraPad at 22.09.2019 17:02:14 */
using Myra.Graphics2D.UI;

#if !XENKO
using Microsoft.Xna.Framework;
#else
using Xenko.Core.Mathematics;
#endif

namespace Myra.Samples.CustomUIStylesheet
{
	partial class AllWidgets: HorizontalSplitPane
	{
		private void BuildUI()
		{
			var textBlock1 = new TextBlock();
			textBlock1.Text = "Button:";
			textBlock1.Id = "";

			_button = new ImageTextButton();
			_button.Text = "Button";
			_button.Id = "_button";
			_button.PaddingLeft = 8;
			_button.PaddingRight = 8;
			_button.GridColumn = 1;

			_textButtonLabel = new TextBlock();
			_textButtonLabel.Text = "Text Button:";
			_textButtonLabel.Id = "_textButtonLabel";
			_textButtonLabel.GridRow = 1;

			_textButton = new TextButton();
			_textButton.Text = "Choose Color";
			_textButton.Id = "_textButton";
			_textButton.PaddingLeft = 8;
			_textButton.PaddingRight = 8;
			_textButton.GridColumn = 1;
			_textButton.GridRow = 1;

			var textBlock2 = new TextBlock();
			textBlock2.Text = "Image Button:";
			textBlock2.Id = "";
			textBlock2.GridRow = 2;

			_imageButton = new ImageButton();
			_imageButton.Id = "_imageButton";
			_imageButton.PaddingLeft = 8;
			_imageButton.PaddingRight = 8;
			_imageButton.GridColumn = 1;
			_imageButton.GridRow = 2;

			var checkBox1 = new CheckBox();
			checkBox1.Text = "This is checkbox";
			checkBox1.ImageWidth = 10;
			checkBox1.ImageHeight = 10;
			checkBox1.GridRow = 3;
			checkBox1.GridColumnSpan = 2;

			var textBlock3 = new TextBlock();
			textBlock3.Text = "Horizontal Slider:";
			textBlock3.Id = "";
			textBlock3.GridRow = 4;

			var horizontalSlider1 = new HorizontalSlider();
			horizontalSlider1.GridColumn = 1;
			horizontalSlider1.GridRow = 4;

			var textBlock4 = new TextBlock();
			textBlock4.Text = "Combo Box:";
			textBlock4.GridRow = 5;

			var listItem1 = new ListItem();
			listItem1.Id = "";
			listItem1.Text = "Red";
			listItem1.Color = Color.Red;

			var listItem2 = new ListItem();
			listItem2.Id = null;
			listItem2.Text = "Green";
			listItem2.Color = Color.Lime;

			var listItem3 = new ListItem();
			listItem3.Id = null;
			listItem3.Text = "Blue";
			listItem3.Color = new Color
			{
				B = 255,
				G = 128,
				R = 0,
				A = 255,
			};

			var comboBox1 = new ComboBox();
			comboBox1.Width = 200;
			comboBox1.GridColumn = 1;
			comboBox1.GridRow = 5;
			comboBox1.Items.Add(listItem1);
			comboBox1.Items.Add(listItem2);
			comboBox1.Items.Add(listItem3);

			var textBlock5 = new TextBlock();
			textBlock5.Text = "Text Field:";
			textBlock5.GridRow = 6;

			var textField1 = new TextField();
			textField1.Text = "";
			textField1.GridColumn = 1;
			textField1.GridRow = 6;

			var textBlock6 = new TextBlock();
			textBlock6.Text = "List Box:";
			textBlock6.GridRow = 7;

			var listItem4 = new ListItem();
			listItem4.Id = null;
			listItem4.Text = "Red";
			listItem4.Color = Color.Red;

			var listItem5 = new ListItem();
			listItem5.Id = null;
			listItem5.Text = "Green";
			listItem5.Color = Color.Lime;

			var listItem6 = new ListItem();
			listItem6.Id = null;
			listItem6.Text = "Blue";
			listItem6.Color = Color.Blue;

			var listBox1 = new ListBox();
			listBox1.Width = 200;
			listBox1.GridColumn = 1;
			listBox1.GridRow = 7;
			listBox1.Items.Add(listItem4);
			listBox1.Items.Add(listItem5);
			listBox1.Items.Add(listItem6);

			var textBlock7 = new TextBlock();
			textBlock7.Text = "Tree";
			textBlock7.GridRow = 8;

			_gridRight = new Grid();
			_gridRight.ColumnSpacing = 8;
			_gridRight.RowSpacing = 8;
			_gridRight.ColumnsProportions.Add(new Proportion());
			_gridRight.ColumnsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Fill,
			});
			_gridRight.RowsProportions.Add(new Proportion());
			_gridRight.RowsProportions.Add(new Proportion());
			_gridRight.RowsProportions.Add(new Proportion());
			_gridRight.RowsProportions.Add(new Proportion());
			_gridRight.RowsProportions.Add(new Proportion());
			_gridRight.RowsProportions.Add(new Proportion());
			_gridRight.RowsProportions.Add(new Proportion());
			_gridRight.RowsProportions.Add(new Proportion());
			_gridRight.RowsProportions.Add(new Proportion());
			_gridRight.Id = "_gridRight";
			_gridRight.Widgets.Add(textBlock1);
			_gridRight.Widgets.Add(_button);
			_gridRight.Widgets.Add(_textButtonLabel);
			_gridRight.Widgets.Add(_textButton);
			_gridRight.Widgets.Add(textBlock2);
			_gridRight.Widgets.Add(_imageButton);
			_gridRight.Widgets.Add(checkBox1);
			_gridRight.Widgets.Add(textBlock3);
			_gridRight.Widgets.Add(horizontalSlider1);
			_gridRight.Widgets.Add(textBlock4);
			_gridRight.Widgets.Add(comboBox1);
			_gridRight.Widgets.Add(textBlock5);
			_gridRight.Widgets.Add(textField1);
			_gridRight.Widgets.Add(textBlock6);
			_gridRight.Widgets.Add(listBox1);
			_gridRight.Widgets.Add(textBlock7);

			var scrollPane1 = new ScrollPane();
			scrollPane1.Content = _gridRight;

			var textBlock8 = new TextBlock();
			textBlock8.Text = "Vertical Slider:";

			var verticalSlider1 = new VerticalSlider();
			verticalSlider1.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Center;
			verticalSlider1.GridRow = 1;

			var grid1 = new Grid();
			grid1.RowSpacing = 8;
			grid1.ColumnsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Fill,
			});
			grid1.RowsProportions.Add(new Proportion());
			grid1.RowsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Fill,
			});
			grid1.Widgets.Add(textBlock8);
			grid1.Widgets.Add(verticalSlider1);

			var textBlock9 = new TextBlock();
			textBlock9.Text = "Progress Bars:";

			_horizontalProgressBar = new HorizontalProgressBar();
			_horizontalProgressBar.Id = "_horizontalProgressBar";
			_horizontalProgressBar.GridRow = 1;

			_verticalProgressBar = new VerticalProgressBar();
			_verticalProgressBar.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Center;
			_verticalProgressBar.Id = "_verticalProgressBar";
			_verticalProgressBar.GridRow = 2;

			var grid2 = new Grid();
			grid2.RowSpacing = 8;
			grid2.ColumnsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Fill,
			});
			grid2.RowsProportions.Add(new Proportion());
			grid2.RowsProportions.Add(new Proportion());
			grid2.RowsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Fill,
			});
			grid2.GridRow = 2;
			grid2.Widgets.Add(textBlock9);
			grid2.Widgets.Add(_horizontalProgressBar);
			grid2.Widgets.Add(_verticalProgressBar);

			var verticalSplitPane1 = new VerticalSplitPane();
			verticalSplitPane1.GridColumn = 2;
			verticalSplitPane1.Widgets.Add(grid1);
			verticalSplitPane1.Widgets.Add(grid2);

			
			GridRow = 1;
			Widgets.Add(scrollPane1);
			Widgets.Add(verticalSplitPane1);
		}

		
		public ImageTextButton _button;
		public TextBlock _textButtonLabel;
		public TextButton _textButton;
		public ImageButton _imageButton;
		public Grid _gridRight;
		public HorizontalProgressBar _horizontalProgressBar;
		public VerticalProgressBar _verticalProgressBar;
	}
}