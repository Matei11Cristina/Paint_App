/*
 * Created for OS project.
 * Author: Matei Cristina & Bratucu Ana Maria
 * Date: 21.05.2018
 *
 * 
 * 
 */
namespace Paint
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox Colors;
		private System.Windows.Forms.Button Bisque;
		private System.Windows.Forms.Button RoyalBlue;
		private System.Windows.Forms.Button Aqua;
		private System.Windows.Forms.Button OrangeRed;
		private System.Windows.Forms.Button YellowGreen;
		private System.Windows.Forms.Button white;
		private System.Windows.Forms.Button LightSalmon;
		private System.Windows.Forms.Button Gray;
		private System.Windows.Forms.Button Maroon;
		private System.Windows.Forms.Button Pink;
		private System.Windows.Forms.Button Purple;
		private System.Windows.Forms.Button MediumSlateBlue;
		private System.Windows.Forms.Button Default1;
		private System.Windows.Forms.Button SteelBlue;
		private System.Windows.Forms.Button Yellow;
		private System.Windows.Forms.Button Green;
		private System.Windows.Forms.Button black;
		private System.Windows.Forms.Button Gold;
		private System.Windows.Forms.Button DarkGray;
		private System.Windows.Forms.Button Brown;
		private System.Windows.Forms.Button Red;
		private System.Windows.Forms.PictureBox Canvas;
		private System.Windows.Forms.GroupBox Figures;
		private System.Windows.Forms.Button line;
		private System.Windows.Forms.Button ellipse;
		private System.Windows.Forms.Button rectangle;
		private System.Windows.Forms.GroupBox groupTools;
		private System.Windows.Forms.Button eraser;
		private System.Windows.Forms.Button pen;
		private System.Windows.Forms.Button brush;
		private System.Windows.Forms.GroupBox groupCoordinates;
		private System.Windows.Forms.Label labelY;
		private System.Windows.Forms.Label labelX;
		private System.Windows.Forms.Button eraseAllScreen;
		private System.Windows.Forms.Button Open;
		private System.Windows.Forms.Button Save;
		private System.Windows.Forms.GroupBox groupSize;
		private System.Windows.Forms.Button size3;
		private System.Windows.Forms.Button size2;
		private System.Windows.Forms.Button size1;
		private System.Windows.Forms.Button size4;
		private System.Windows.Forms.Label labelOpen;
		private System.Windows.Forms.Label labelSave;
		private System.Windows.Forms.Label labelEditColors;
		private System.Windows.Forms.Button editColors;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Colors = new System.Windows.Forms.GroupBox();
            this.labelEditColors = new System.Windows.Forms.Label();
            this.editColors = new System.Windows.Forms.Button();
            this.Bisque = new System.Windows.Forms.Button();
            this.RoyalBlue = new System.Windows.Forms.Button();
            this.Aqua = new System.Windows.Forms.Button();
            this.OrangeRed = new System.Windows.Forms.Button();
            this.YellowGreen = new System.Windows.Forms.Button();
            this.white = new System.Windows.Forms.Button();
            this.LightSalmon = new System.Windows.Forms.Button();
            this.Gray = new System.Windows.Forms.Button();
            this.Maroon = new System.Windows.Forms.Button();
            this.Pink = new System.Windows.Forms.Button();
            this.Purple = new System.Windows.Forms.Button();
            this.MediumSlateBlue = new System.Windows.Forms.Button();
            this.Default1 = new System.Windows.Forms.Button();
            this.SteelBlue = new System.Windows.Forms.Button();
            this.Yellow = new System.Windows.Forms.Button();
            this.Green = new System.Windows.Forms.Button();
            this.black = new System.Windows.Forms.Button();
            this.Gold = new System.Windows.Forms.Button();
            this.DarkGray = new System.Windows.Forms.Button();
            this.Brown = new System.Windows.Forms.Button();
            this.Red = new System.Windows.Forms.Button();
            this.Figures = new System.Windows.Forms.GroupBox();
            this.fillEllipse = new System.Windows.Forms.Button();
            this.fillRectangle = new System.Windows.Forms.Button();
            this.ellipse = new System.Windows.Forms.Button();
            this.rectangle = new System.Windows.Forms.Button();
            this.line = new System.Windows.Forms.Button();
            this.groupTools = new System.Windows.Forms.GroupBox();
            this.eraser = new System.Windows.Forms.Button();
            this.pen = new System.Windows.Forms.Button();
            this.brush = new System.Windows.Forms.Button();
            this.groupCoordinates = new System.Windows.Forms.GroupBox();
            this.labelY = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.eraseAllScreen = new System.Windows.Forms.Button();
            this.groupSize = new System.Windows.Forms.GroupBox();
            this.size4 = new System.Windows.Forms.Button();
            this.size3 = new System.Windows.Forms.Button();
            this.size2 = new System.Windows.Forms.Button();
            this.size1 = new System.Windows.Forms.Button();
            this.labelOpen = new System.Windows.Forms.Label();
            this.labelSave = new System.Windows.Forms.Label();
            this.toolTipOpen = new System.Windows.Forms.ToolTip(this.components);
            this.Open = new System.Windows.Forms.Button();
            this.toolTipSave = new System.Windows.Forms.ToolTip(this.components);
            this.Save = new System.Windows.Forms.Button();
            this.toolTipPen = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipEraser = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipBrush = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipSizes = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipLine = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipRectangle = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipEllipse = new System.Windows.Forms.ToolTip(this.components);
            this.exit = new System.Windows.Forms.Button();
            this.toolTipFillRectangle = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipFillEllipse = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipColors = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipEditColors = new System.Windows.Forms.ToolTip(this.components);
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.toolTipExit = new System.Windows.Forms.ToolTip(this.components);
            this.Colors.SuspendLayout();
            this.Figures.SuspendLayout();
            this.groupTools.SuspendLayout();
            this.groupCoordinates.SuspendLayout();
            this.groupSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // Colors
            // 
            this.Colors.BackColor = System.Drawing.Color.Transparent;
            this.Colors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Colors.Controls.Add(this.labelEditColors);
            this.Colors.Controls.Add(this.editColors);
            this.Colors.Controls.Add(this.Bisque);
            this.Colors.Controls.Add(this.RoyalBlue);
            this.Colors.Controls.Add(this.Aqua);
            this.Colors.Controls.Add(this.OrangeRed);
            this.Colors.Controls.Add(this.YellowGreen);
            this.Colors.Controls.Add(this.white);
            this.Colors.Controls.Add(this.LightSalmon);
            this.Colors.Controls.Add(this.Gray);
            this.Colors.Controls.Add(this.Maroon);
            this.Colors.Controls.Add(this.Pink);
            this.Colors.Controls.Add(this.Purple);
            this.Colors.Controls.Add(this.MediumSlateBlue);
            this.Colors.Controls.Add(this.Default1);
            this.Colors.Controls.Add(this.SteelBlue);
            this.Colors.Controls.Add(this.Yellow);
            this.Colors.Controls.Add(this.Green);
            this.Colors.Controls.Add(this.black);
            this.Colors.Controls.Add(this.Gold);
            this.Colors.Controls.Add(this.DarkGray);
            this.Colors.Controls.Add(this.Brown);
            this.Colors.Controls.Add(this.Red);
            this.Colors.Location = new System.Drawing.Point(643, 25);
            this.Colors.Margin = new System.Windows.Forms.Padding(4);
            this.Colors.Name = "Colors";
            this.Colors.Padding = new System.Windows.Forms.Padding(4);
            this.Colors.Size = new System.Drawing.Size(524, 114);
            this.Colors.TabIndex = 0;
            this.Colors.TabStop = false;
            this.Colors.Text = "Colors";
            this.toolTipEllipse.SetToolTip(this.Colors, "Choose color");
            // 
            // labelEditColors
            // 
            this.labelEditColors.Location = new System.Drawing.Point(455, 64);
            this.labelEditColors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEditColors.Name = "labelEditColors";
            this.labelEditColors.Size = new System.Drawing.Size(56, 38);
            this.labelEditColors.TabIndex = 29;
            this.labelEditColors.Text = "Edit colors";
            // 
            // editColors
            // 
            this.editColors.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editColors.BackgroundImage")));
            this.editColors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editColors.Location = new System.Drawing.Point(455, 23);
            this.editColors.Margin = new System.Windows.Forms.Padding(4);
            this.editColors.Name = "editColors";
            this.editColors.Size = new System.Drawing.Size(43, 37);
            this.editColors.TabIndex = 28;
            this.toolTipEllipse.SetToolTip(this.editColors, "Create a different color");
            this.editColors.UseVisualStyleBackColor = true;
            this.editColors.Click += new System.EventHandler(this.EditColorsClick);
            // 
            // Bisque
            // 
            this.Bisque.BackColor = System.Drawing.Color.Bisque;
            this.Bisque.Location = new System.Drawing.Point(403, 59);
            this.Bisque.Margin = new System.Windows.Forms.Padding(1);
            this.Bisque.Name = "Bisque";
            this.Bisque.Size = new System.Drawing.Size(33, 31);
            this.Bisque.TabIndex = 20;
            this.Bisque.UseVisualStyleBackColor = false;
            this.Bisque.Click += new System.EventHandler(this.BisqueClick);
            // 
            // RoyalBlue
            // 
            this.RoyalBlue.BackColor = System.Drawing.Color.RoyalBlue;
            this.RoyalBlue.Location = new System.Drawing.Point(367, 59);
            this.RoyalBlue.Margin = new System.Windows.Forms.Padding(1);
            this.RoyalBlue.Name = "RoyalBlue";
            this.RoyalBlue.Size = new System.Drawing.Size(33, 31);
            this.RoyalBlue.TabIndex = 19;
            this.RoyalBlue.UseVisualStyleBackColor = false;
            this.RoyalBlue.Click += new System.EventHandler(this.RoyalBlueClick);
            // 
            // Aqua
            // 
            this.Aqua.BackColor = System.Drawing.Color.Cyan;
            this.Aqua.Location = new System.Drawing.Point(331, 59);
            this.Aqua.Margin = new System.Windows.Forms.Padding(1);
            this.Aqua.Name = "Aqua";
            this.Aqua.Size = new System.Drawing.Size(33, 31);
            this.Aqua.TabIndex = 18;
            this.Aqua.UseVisualStyleBackColor = false;
            this.Aqua.Click += new System.EventHandler(this.AquaClick);
            // 
            // OrangeRed
            // 
            this.OrangeRed.BackColor = System.Drawing.Color.Yellow;
            this.OrangeRed.Location = new System.Drawing.Point(223, 59);
            this.OrangeRed.Margin = new System.Windows.Forms.Padding(1);
            this.OrangeRed.Name = "OrangeRed";
            this.OrangeRed.Size = new System.Drawing.Size(33, 31);
            this.OrangeRed.TabIndex = 15;
            this.OrangeRed.UseVisualStyleBackColor = false;
            this.OrangeRed.Click += new System.EventHandler(this.OrangeRedClick);
            // 
            // YellowGreen
            // 
            this.YellowGreen.BackColor = System.Drawing.Color.YellowGreen;
            this.YellowGreen.Location = new System.Drawing.Point(295, 59);
            this.YellowGreen.Margin = new System.Windows.Forms.Padding(1);
            this.YellowGreen.Name = "YellowGreen";
            this.YellowGreen.Size = new System.Drawing.Size(33, 31);
            this.YellowGreen.TabIndex = 17;
            this.YellowGreen.UseVisualStyleBackColor = false;
            this.YellowGreen.Click += new System.EventHandler(this.YellowGreenClick);
            // 
            // white
            // 
            this.white.BackColor = System.Drawing.Color.White;
            this.white.Location = new System.Drawing.Point(79, 59);
            this.white.Margin = new System.Windows.Forms.Padding(1);
            this.white.Name = "white";
            this.white.Size = new System.Drawing.Size(33, 31);
            this.white.TabIndex = 11;
            this.white.UseVisualStyleBackColor = false;
            this.white.Click += new System.EventHandler(this.WhiteClick);
            // 
            // LightSalmon
            // 
            this.LightSalmon.BackColor = System.Drawing.Color.LightSalmon;
            this.LightSalmon.Location = new System.Drawing.Point(259, 59);
            this.LightSalmon.Margin = new System.Windows.Forms.Padding(1);
            this.LightSalmon.Name = "LightSalmon";
            this.LightSalmon.Size = new System.Drawing.Size(33, 31);
            this.LightSalmon.TabIndex = 16;
            this.LightSalmon.UseVisualStyleBackColor = false;
            this.LightSalmon.Click += new System.EventHandler(this.LightSalmonClick);
            // 
            // Gray
            // 
            this.Gray.BackColor = System.Drawing.Color.Gray;
            this.Gray.Location = new System.Drawing.Point(115, 59);
            this.Gray.Margin = new System.Windows.Forms.Padding(1);
            this.Gray.Name = "Gray";
            this.Gray.Size = new System.Drawing.Size(33, 31);
            this.Gray.TabIndex = 12;
            this.Gray.UseVisualStyleBackColor = false;
            this.Gray.Click += new System.EventHandler(this.GrayClick);
            // 
            // Maroon
            // 
            this.Maroon.BackColor = System.Drawing.Color.Maroon;
            this.Maroon.Location = new System.Drawing.Point(151, 59);
            this.Maroon.Margin = new System.Windows.Forms.Padding(1);
            this.Maroon.Name = "Maroon";
            this.Maroon.Size = new System.Drawing.Size(33, 31);
            this.Maroon.TabIndex = 13;
            this.Maroon.UseVisualStyleBackColor = false;
            this.Maroon.Click += new System.EventHandler(this.MaroonClick);
            // 
            // Pink
            // 
            this.Pink.BackColor = System.Drawing.Color.Pink;
            this.Pink.Location = new System.Drawing.Point(187, 59);
            this.Pink.Margin = new System.Windows.Forms.Padding(1);
            this.Pink.Name = "Pink";
            this.Pink.Size = new System.Drawing.Size(33, 31);
            this.Pink.TabIndex = 14;
            this.Pink.UseVisualStyleBackColor = false;
            this.Pink.Click += new System.EventHandler(this.PinkClick);
            // 
            // Purple
            // 
            this.Purple.BackColor = System.Drawing.Color.Purple;
            this.Purple.Location = new System.Drawing.Point(403, 25);
            this.Purple.Margin = new System.Windows.Forms.Padding(1);
            this.Purple.Name = "Purple";
            this.Purple.Size = new System.Drawing.Size(33, 31);
            this.Purple.TabIndex = 10;
            this.Purple.UseVisualStyleBackColor = false;
            this.Purple.Click += new System.EventHandler(this.PurpleClick);
            // 
            // MediumSlateBlue
            // 
            this.MediumSlateBlue.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.MediumSlateBlue.Location = new System.Drawing.Point(367, 25);
            this.MediumSlateBlue.Margin = new System.Windows.Forms.Padding(1);
            this.MediumSlateBlue.Name = "MediumSlateBlue";
            this.MediumSlateBlue.Size = new System.Drawing.Size(33, 31);
            this.MediumSlateBlue.TabIndex = 9;
            this.MediumSlateBlue.UseVisualStyleBackColor = false;
            this.MediumSlateBlue.Click += new System.EventHandler(this.MediumSlateBlueClick);
            // 
            // Default1
            // 
            this.Default1.BackColor = System.Drawing.Color.Black;
            this.Default1.Location = new System.Drawing.Point(8, 25);
            this.Default1.Margin = new System.Windows.Forms.Padding(4);
            this.Default1.Name = "Default1";
            this.Default1.Size = new System.Drawing.Size(65, 65);
            this.Default1.TabIndex = 0;
            this.Default1.UseVisualStyleBackColor = false;
            this.Default1.Click += new System.EventHandler(this.Default1_Click);
            // 
            // SteelBlue
            // 
            this.SteelBlue.BackColor = System.Drawing.Color.SteelBlue;
            this.SteelBlue.Location = new System.Drawing.Point(331, 25);
            this.SteelBlue.Margin = new System.Windows.Forms.Padding(1);
            this.SteelBlue.Name = "SteelBlue";
            this.SteelBlue.Size = new System.Drawing.Size(33, 31);
            this.SteelBlue.TabIndex = 8;
            this.SteelBlue.UseVisualStyleBackColor = false;
            this.SteelBlue.Click += new System.EventHandler(this.SteelBlueClick);
            // 
            // Yellow
            // 
            this.Yellow.BackColor = System.Drawing.Color.OrangeRed;
            this.Yellow.Location = new System.Drawing.Point(223, 25);
            this.Yellow.Margin = new System.Windows.Forms.Padding(1);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(33, 31);
            this.Yellow.TabIndex = 5;
            this.Yellow.UseVisualStyleBackColor = false;
            this.Yellow.Click += new System.EventHandler(this.YellowClick);
            // 
            // Green
            // 
            this.Green.BackColor = System.Drawing.Color.Green;
            this.Green.Location = new System.Drawing.Point(295, 25);
            this.Green.Margin = new System.Windows.Forms.Padding(1);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(33, 31);
            this.Green.TabIndex = 7;
            this.Green.UseVisualStyleBackColor = false;
            this.Green.Click += new System.EventHandler(this.GreenClick);
            // 
            // black
            // 
            this.black.BackColor = System.Drawing.Color.Black;
            this.black.Location = new System.Drawing.Point(79, 25);
            this.black.Margin = new System.Windows.Forms.Padding(1);
            this.black.Name = "black";
            this.black.Size = new System.Drawing.Size(33, 31);
            this.black.TabIndex = 1;
            this.black.UseVisualStyleBackColor = false;
            this.black.Click += new System.EventHandler(this.BlackClick);
            // 
            // Gold
            // 
            this.Gold.BackColor = System.Drawing.Color.Gold;
            this.Gold.Location = new System.Drawing.Point(259, 25);
            this.Gold.Margin = new System.Windows.Forms.Padding(1);
            this.Gold.Name = "Gold";
            this.Gold.Size = new System.Drawing.Size(33, 31);
            this.Gold.TabIndex = 6;
            this.Gold.UseVisualStyleBackColor = false;
            this.Gold.Click += new System.EventHandler(this.GoldClick);
            // 
            // DarkGray
            // 
            this.DarkGray.BackColor = System.Drawing.Color.DarkGray;
            this.DarkGray.Location = new System.Drawing.Point(115, 25);
            this.DarkGray.Margin = new System.Windows.Forms.Padding(1);
            this.DarkGray.Name = "DarkGray";
            this.DarkGray.Size = new System.Drawing.Size(33, 31);
            this.DarkGray.TabIndex = 2;
            this.DarkGray.UseVisualStyleBackColor = false;
            this.DarkGray.Click += new System.EventHandler(this.DarkGrayClick);
            // 
            // Brown
            // 
            this.Brown.BackColor = System.Drawing.Color.Brown;
            this.Brown.Location = new System.Drawing.Point(151, 25);
            this.Brown.Margin = new System.Windows.Forms.Padding(1);
            this.Brown.Name = "Brown";
            this.Brown.Size = new System.Drawing.Size(33, 31);
            this.Brown.TabIndex = 3;
            this.Brown.UseVisualStyleBackColor = false;
            this.Brown.Click += new System.EventHandler(this.BrownClick);
            // 
            // Red
            // 
            this.Red.BackColor = System.Drawing.Color.Red;
            this.Red.Location = new System.Drawing.Point(187, 25);
            this.Red.Margin = new System.Windows.Forms.Padding(1);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(33, 31);
            this.Red.TabIndex = 4;
            this.Red.UseVisualStyleBackColor = false;
            this.Red.Click += new System.EventHandler(this.RedClick);
            // 
            // Figures
            // 
            this.Figures.Controls.Add(this.fillEllipse);
            this.Figures.Controls.Add(this.fillRectangle);
            this.Figures.Controls.Add(this.ellipse);
            this.Figures.Controls.Add(this.rectangle);
            this.Figures.Controls.Add(this.line);
            this.Figures.Location = new System.Drawing.Point(503, 22);
            this.Figures.Margin = new System.Windows.Forms.Padding(4);
            this.Figures.Name = "Figures";
            this.Figures.Padding = new System.Windows.Forms.Padding(4);
            this.Figures.Size = new System.Drawing.Size(140, 134);
            this.Figures.TabIndex = 2;
            this.Figures.TabStop = false;
            this.Figures.Text = "Figures";
            // 
            // fillEllipse
            // 
            this.fillEllipse.BackgroundImage = global::Paint.Properties.Resources.sig;
            this.fillEllipse.Location = new System.Drawing.Point(77, 76);
            this.fillEllipse.Name = "fillEllipse";
            this.fillEllipse.Size = new System.Drawing.Size(56, 51);
            this.fillEllipse.TabIndex = 15;
            this.toolTipEllipse.SetToolTip(this.fillEllipse, "Draw filled ellipse");
            this.fillEllipse.UseVisualStyleBackColor = true;
            this.fillEllipse.Click += new System.EventHandler(this.FillEllipse_Click);
            // 
            // fillRectangle
            // 
            this.fillRectangle.BackColor = System.Drawing.Color.White;
            this.fillRectangle.BackgroundImage = global::Paint.Properties.Resources.uf;
            this.fillRectangle.Location = new System.Drawing.Point(-1, 76);
            this.fillRectangle.Name = "fillRectangle";
            this.fillRectangle.Size = new System.Drawing.Size(56, 51);
            this.fillRectangle.TabIndex = 14;
            this.toolTipEllipse.SetToolTip(this.fillRectangle, "Draw filled rectangle");
            this.fillRectangle.UseVisualStyleBackColor = false;
            this.fillRectangle.Click += new System.EventHandler(this.FillRectangle_Click);
            // 
            // ellipse
            // 
            this.ellipse.BackColor = System.Drawing.Color.Transparent;
            this.ellipse.BackgroundImage = global::Paint.Properties.Resources.da_;
            this.ellipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ellipse.Location = new System.Drawing.Point(101, 27);
            this.ellipse.Margin = new System.Windows.Forms.Padding(1);
            this.ellipse.Name = "ellipse";
            this.ellipse.Size = new System.Drawing.Size(34, 35);
            this.ellipse.TabIndex = 9;
            this.toolTipEllipse.SetToolTip(this.ellipse, "Draw border of an ellipse");
            this.ellipse.UseVisualStyleBackColor = false;
            this.ellipse.Click += new System.EventHandler(this.EllipseClick);
            // 
            // rectangle
            // 
            this.rectangle.BackColor = System.Drawing.Color.White;
            this.rectangle.BackgroundImage = global::Paint.Properties.Resources._217340_200;
            this.rectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rectangle.Location = new System.Drawing.Point(54, 27);
            this.rectangle.Margin = new System.Windows.Forms.Padding(1);
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(32, 35);
            this.rectangle.TabIndex = 8;
            this.toolTipRectangle.SetToolTip(this.rectangle, "Draw border of a rectangle");
            this.rectangle.UseVisualStyleBackColor = false;
            this.rectangle.Click += new System.EventHandler(this.RectangleClick);
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.Transparent;
            this.line.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("line.BackgroundImage")));
            this.line.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.line.Location = new System.Drawing.Point(5, 27);
            this.line.Margin = new System.Windows.Forms.Padding(1);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(37, 35);
            this.line.TabIndex = 7;
            this.toolTipLine.SetToolTip(this.line, "Draw a straight line");
            this.line.UseVisualStyleBackColor = false;
            this.line.Click += new System.EventHandler(this.LineClick);
            // 
            // groupTools
            // 
            this.groupTools.Controls.Add(this.eraser);
            this.groupTools.Controls.Add(this.pen);
            this.groupTools.Controls.Add(this.brush);
            this.groupTools.Location = new System.Drawing.Point(164, 22);
            this.groupTools.Margin = new System.Windows.Forms.Padding(4);
            this.groupTools.Name = "groupTools";
            this.groupTools.Padding = new System.Windows.Forms.Padding(4);
            this.groupTools.Size = new System.Drawing.Size(232, 134);
            this.groupTools.TabIndex = 3;
            this.groupTools.TabStop = false;
            this.groupTools.Text = "Tools";
            // 
            // eraser
            // 
            this.eraser.BackColor = System.Drawing.Color.Transparent;
            this.eraser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eraser.BackgroundImage")));
            this.eraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eraser.Location = new System.Drawing.Point(82, 25);
            this.eraser.Margin = new System.Windows.Forms.Padding(1);
            this.eraser.Name = "eraser";
            this.eraser.Size = new System.Drawing.Size(59, 56);
            this.eraser.TabIndex = 12;
            this.toolTipEraser.SetToolTip(this.eraser, "Eraser");
            this.eraser.UseVisualStyleBackColor = false;
            this.eraser.Click += new System.EventHandler(this.EraserClick);
            // 
            // pen
            // 
            this.pen.BackColor = System.Drawing.Color.Transparent;
            this.pen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pen.BackgroundImage")));
            this.pen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pen.Location = new System.Drawing.Point(5, 25);
            this.pen.Margin = new System.Windows.Forms.Padding(1);
            this.pen.Name = "pen";
            this.pen.Size = new System.Drawing.Size(60, 56);
            this.pen.TabIndex = 10;
            this.toolTipPen.SetToolTip(this.pen, "Draw with pen");
            this.pen.UseVisualStyleBackColor = true;
            this.pen.Click += new System.EventHandler(this.PenClick);
            // 
            // brush
            // 
            this.brush.BackColor = System.Drawing.Color.Transparent;
            this.brush.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("brush.BackgroundImage")));
            this.brush.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.brush.Location = new System.Drawing.Point(158, 25);
            this.brush.Margin = new System.Windows.Forms.Padding(1);
            this.brush.Name = "brush";
            this.brush.Size = new System.Drawing.Size(57, 56);
            this.brush.TabIndex = 13;
            this.toolTipBrush.SetToolTip(this.brush, "Draw with a brush");
            this.brush.UseVisualStyleBackColor = false;
            this.brush.Click += new System.EventHandler(this.BrushClick);
            // 
            // groupCoordinates
            // 
            this.groupCoordinates.Controls.Add(this.labelY);
            this.groupCoordinates.Controls.Add(this.labelX);
            this.groupCoordinates.Location = new System.Drawing.Point(16, 698);
            this.groupCoordinates.Margin = new System.Windows.Forms.Padding(4);
            this.groupCoordinates.Name = "groupCoordinates";
            this.groupCoordinates.Padding = new System.Windows.Forms.Padding(4);
            this.groupCoordinates.Size = new System.Drawing.Size(279, 62);
            this.groupCoordinates.TabIndex = 4;
            this.groupCoordinates.TabStop = false;
            this.groupCoordinates.Text = "Coordinates";
            // 
            // labelY
            // 
            this.labelY.Location = new System.Drawing.Point(116, 23);
            this.labelY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(133, 28);
            this.labelY.TabIndex = 1;
            this.labelY.Text = "Y:";
            // 
            // labelX
            // 
            this.labelX.Location = new System.Drawing.Point(8, 23);
            this.labelX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(80, 28);
            this.labelX.TabIndex = 0;
            this.labelX.Text = "X:";
            // 
            // eraseAllScreen
            // 
            this.eraseAllScreen.BackColor = System.Drawing.Color.Black;
            this.eraseAllScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eraseAllScreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eraseAllScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eraseAllScreen.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.eraseAllScreen.Location = new System.Drawing.Point(557, 698);
            this.eraseAllScreen.Margin = new System.Windows.Forms.Padding(1);
            this.eraseAllScreen.Name = "eraseAllScreen";
            this.eraseAllScreen.Size = new System.Drawing.Size(181, 48);
            this.eraseAllScreen.TabIndex = 13;
            this.eraseAllScreen.Text = "Erase all screen";
            this.eraseAllScreen.UseVisualStyleBackColor = false;
            this.eraseAllScreen.Click += new System.EventHandler(this.EraseAllScreenClick);
            // 
            // groupSize
            // 
            this.groupSize.Controls.Add(this.size4);
            this.groupSize.Controls.Add(this.size3);
            this.groupSize.Controls.Add(this.size2);
            this.groupSize.Controls.Add(this.size1);
            this.groupSize.Location = new System.Drawing.Point(404, 22);
            this.groupSize.Margin = new System.Windows.Forms.Padding(4);
            this.groupSize.Name = "groupSize";
            this.groupSize.Padding = new System.Windows.Forms.Padding(4);
            this.groupSize.Size = new System.Drawing.Size(91, 134);
            this.groupSize.TabIndex = 25;
            this.groupSize.TabStop = false;
            this.groupSize.Text = "Size";
            this.toolTipSizes.SetToolTip(this.groupSize, "Choose thickness of tool");
            // 
            // size4
            // 
            this.size4.Image = ((System.Drawing.Image)(resources.GetObject("size4.Image")));
            this.size4.Location = new System.Drawing.Point(19, 82);
            this.size4.Margin = new System.Windows.Forms.Padding(1);
            this.size4.Name = "size4";
            this.size4.Size = new System.Drawing.Size(63, 22);
            this.size4.TabIndex = 29;
            this.size4.UseVisualStyleBackColor = true;
            this.size4.Click += new System.EventHandler(this.Size4Click);
            // 
            // size3
            // 
            this.size3.Image = ((System.Drawing.Image)(resources.GetObject("size3.Image")));
            this.size3.Location = new System.Drawing.Point(19, 62);
            this.size3.Margin = new System.Windows.Forms.Padding(1);
            this.size3.Name = "size3";
            this.size3.Size = new System.Drawing.Size(63, 18);
            this.size3.TabIndex = 28;
            this.size3.UseVisualStyleBackColor = true;
            this.size3.Click += new System.EventHandler(this.Size3Click);
            // 
            // size2
            // 
            this.size2.Image = ((System.Drawing.Image)(resources.GetObject("size2.Image")));
            this.size2.Location = new System.Drawing.Point(19, 41);
            this.size2.Margin = new System.Windows.Forms.Padding(1);
            this.size2.Name = "size2";
            this.size2.Size = new System.Drawing.Size(63, 18);
            this.size2.TabIndex = 27;
            this.size2.UseVisualStyleBackColor = true;
            this.size2.Click += new System.EventHandler(this.Size2Click);
            // 
            // size1
            // 
            this.size1.Image = ((System.Drawing.Image)(resources.GetObject("size1.Image")));
            this.size1.Location = new System.Drawing.Point(19, 22);
            this.size1.Margin = new System.Windows.Forms.Padding(1);
            this.size1.Name = "size1";
            this.size1.Size = new System.Drawing.Size(63, 18);
            this.size1.TabIndex = 26;
            this.size1.UseVisualStyleBackColor = true;
            this.size1.Click += new System.EventHandler(this.Size1Click);
            // 
            // labelOpen
            // 
            this.labelOpen.Location = new System.Drawing.Point(24, 27);
            this.labelOpen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOpen.Name = "labelOpen";
            this.labelOpen.Size = new System.Drawing.Size(63, 18);
            this.labelOpen.TabIndex = 26;
            this.labelOpen.Text = "Open";
            // 
            // labelSave
            // 
            this.labelSave.Location = new System.Drawing.Point(95, 26);
            this.labelSave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSave.Name = "labelSave";
            this.labelSave.Size = new System.Drawing.Size(61, 20);
            this.labelSave.TabIndex = 27;
            this.labelSave.Text = "Save";
            // 
            // Open
            // 
            this.Open.BackColor = System.Drawing.Color.LightCoral;
            this.Open.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Open.BackgroundImage")));
            this.Open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Open.Location = new System.Drawing.Point(24, 49);
            this.Open.Margin = new System.Windows.Forms.Padding(4);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(63, 54);
            this.Open.TabIndex = 21;
            this.toolTipOpen.SetToolTip(this.Open, "Open file");
            this.Open.UseVisualStyleBackColor = false;
            this.Open.Click += new System.EventHandler(this.OpenClick);
            // 
            // Save
            // 
            this.Save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Save.BackgroundImage")));
            this.Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Save.Location = new System.Drawing.Point(95, 50);
            this.Save.Margin = new System.Windows.Forms.Padding(4);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(61, 53);
            this.Save.TabIndex = 22;
            this.toolTipSave.SetToolTip(this.Save, "Save file");
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.SaveClick);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Black;
            this.exit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exit.Location = new System.Drawing.Point(1233, 8);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(82, 37);
            this.exit.TabIndex = 28;
            this.exit.Text = "EXIT";
            this.toolTipEllipse.SetToolTip(this.exit, "Exit the application");
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.Color.White;
            this.Canvas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Canvas.Location = new System.Drawing.Point(-10, 164);
            this.Canvas.Margin = new System.Windows.Forms.Padding(4);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(1493, 526);
            this.Canvas.TabIndex = 24;
            this.Canvas.TabStop = false;
            this.Canvas.Click += new System.EventHandler(this.Canvas_Click);
            this.Canvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CanvasMouseClick);
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CanvasMouseDown);
            this.Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CanvasMouseMove);
            this.Canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CanvasMouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1551, 763);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.labelSave);
            this.Controls.Add(this.labelOpen);
            this.Controls.Add(this.groupSize);
            this.Controls.Add(this.Canvas);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.groupTools);
            this.Controls.Add(this.eraseAllScreen);
            this.Controls.Add(this.groupCoordinates);
            this.Controls.Add(this.Figures);
            this.Controls.Add(this.Colors);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.Colors.ResumeLayout(false);
            this.Figures.ResumeLayout(false);
            this.groupTools.ResumeLayout(false);
            this.groupCoordinates.ResumeLayout(false);
            this.groupSize.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.ResumeLayout(false);

		}

        private System.Windows.Forms.Button fillRectangle;
        private System.Windows.Forms.ToolTip toolTipPen;
        private System.Windows.Forms.ToolTip toolTipOpen;
        private System.Windows.Forms.ToolTip toolTipSave;
        private System.Windows.Forms.ToolTip toolTipEllipse;
        private System.Windows.Forms.ToolTip toolTipRectangle;
        private System.Windows.Forms.ToolTip toolTipLine;
        private System.Windows.Forms.ToolTip toolTipEraser;
        private System.Windows.Forms.ToolTip toolTipBrush;
        private System.Windows.Forms.ToolTip toolTipSizes;
        private System.Windows.Forms.ToolTip toolTipFillRectangle;
        private System.Windows.Forms.ToolTip toolTipFillEllipse;
        private System.Windows.Forms.Button fillEllipse;
        private System.Windows.Forms.ToolTip toolTipColors;
        private System.Windows.Forms.ToolTip toolTipEditColors;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.ToolTip toolTipExit;
    }
}
