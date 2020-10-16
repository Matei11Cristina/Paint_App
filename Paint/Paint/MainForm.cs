/*
 * Created for OS project.
 * Author: Matei Cristina & Bratucu Ana Maria
 * Date: 21.05.2018
 *
 * 
 * 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.IO;


namespace Paint
{
    
   /*MainForm Class*/
    
    
   
    public partial class MainForm : Form
    {
        /*Variables*/
        Graphics g; /* encapsulates/ contains a drawing surface */

        private Pen p = new Pen(Color.Black, 1); //object used to draw line
        //start point of mouse on the canvas
        private Point startPoint = new Point(0, 0); //represents a point using coordinates
        //end point of mouse on the canvas
        private Point endPoint = new Point(0, 0);
        //The variable represents the mouse down and we initialize it as being false
        private int mouseDown = 0;
        private string figure; //represents every tool or shape from our app; used to keep track of all the shapes/ tools

        /* Current position(currentX,currentY) of mouse on the canvas */
        //Dimension (dimensionx,dimensiony) used to compute the size of the shapes
        private int currentX, currentY, x, y, dimensionX, dimensionY;
        private Color color; //represents the colors ARGB

        //Initialize the components for the paint application
        public MainForm()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            /* The default color can be any color of choice */
            
            color = Color.Black;
        }

        //this is the canvas paint area for the shapes (Graphics Objects are created by calling the 
        //CreateGraphics() method of the component on which the drawing is to performed.)
        private void MainFormLoad(object sender, EventArgs e)
        {
            g = Canvas.CreateGraphics();
        }

        //This button allows the user to draw with a pen.
        private void PenClick(object sender, EventArgs e)
        {
            figure = "pen";
        }

        //This button allows the user to erase.
        private void EraserClick(object sender, EventArgs e)
        {
            figure = "eraser";
            color = Color.White;
        }

        //This button allows the user to draw a line.
        private void LineClick(object sender, EventArgs e)
        {
            figure = "line";
        }

        //This button allows the user to draw an ellipse.
        private void EllipseClick(object sender, EventArgs e)
        {
            figure = "ellipse";
        }

        //This button allows tyhe user to draw a rectangle.
        private void RectangleClick(object sender, EventArgs e)
        {
            figure = "rectangle";
        }

        //This button allows the user to draw with a brush pen.
        private void BrushClick(object sender, EventArgs e)
        {
            figure = "brush";
        }

        //This button allows the user to change the size of the pen,brush and eraser.(first type)
        private void Size1Click(object sender, EventArgs e)
        {
            figure = "size1";
        }

        //This button allows the user to change the size of the pen,brush and eraser.(second type)
        private void Size2Click(object sender, EventArgs e)
        {
            figure = "size2";
        }

        //This button allows the user to change the size of the pen,brush and eraser.(third type)
        private void Size3Click(object sender, EventArgs e)
        {
            figure = "size3";
        }

        //This button allows the user to change the size of the pen,brush and eraser.(fourth type)
        private void Size4Click(object sender, EventArgs e)
        {
            figure = "size4";
        }

        //This button allows the user to fill with color the rectangle.
        private void FillRectangle_Click(object sender, EventArgs e)
        {

            figure = "fillRectangle";


        }

        //This button allows the user to fill with color the ellipse.
        private void FillEllipse_Click(object sender, EventArgs e)
        {
            figure = "fillEllipse";
        }

        //This button changes the line, border or filling color to the given syntax color.
        private void BlackClick(object sender, EventArgs e)
        {
            color = Color.Black;
            Default1.BackColor = color;
        }

        // //This button changes the line, border or filling color to the given syntax color.
        private void DarkGrayClick(object sender, EventArgs e)
        {
            color = Color.DarkGray;
            Default1.BackColor = color;
        }

        //This button changes the line, border or filling color to the given syntax color.
        private void BrownClick(object sender, EventArgs e)
        {
            color = Color.Brown;
            Default1.BackColor = color;

        }

        //This button changes the line, border or filling color to the given syntax color.
        private void GrayClick(object sender, EventArgs e)
        {
            color = Color.Gray;
            Default1.BackColor = color;
        }

        //This button changes the line, border or filling color to the given syntax color.
        private void MaroonClick(object sender, EventArgs e)
        {
            color = Color.Maroon;
            Default1.BackColor = color;
        }

        //This button changes the line, border or filling color to the given syntax color.
        private void RedClick(object sender, EventArgs e)
        {
            color = Color.Red;
            Default1.BackColor = color;
        }

        //This button changes the line, border or filling color to the given syntax color.
        private void WhiteClick(object sender, EventArgs e)
        {
            color = Color.White;
            Default1.BackColor = color;
        }

        //This button changes the line, border or filling color to the given syntax color.
        private void PinkClick(object sender, EventArgs e)
        {
            color = Color.Pink;
            Default1.BackColor = color;
        }

        //This button changes the line, border or filling color to the given syntax color.
        private void YellowClick(object sender, EventArgs e)
        {
            color = Color.OrangeRed;
            Default1.BackColor = color;
        }

        //This button changes the line, border or filling color to the given syntax color.
        private void OrangeRedClick(object sender, EventArgs e)
        {
            color = Color.Yellow;
            Default1.BackColor = color;
        }

        //This button changes the line, border or filling color to the given syntax color.
        private void GoldClick(object sender, EventArgs e)
        {
            color = Color.Gold;
            Default1.BackColor = color;
        }

        //This button changes the line, border or filling color to the given syntax color.
        private void LightSalmonClick(object sender, EventArgs e)
        {
            color = Color.LightSalmon;
            Default1.BackColor = color;
        }

        //This button changes the line, border or filling color to the given syntax color.
        private void GreenClick(object sender, EventArgs e)
        {
            color = Color.Green;
            Default1.BackColor = color;
        }

        //This button changes the line, border or filling color to the given syntax color.
        private void YellowGreenClick(object sender, EventArgs e)
        {
            color = Color.YellowGreen;
            Default1.BackColor = color;
        }

        //This button changes the line, border or filling color to the given syntax color.
        private void SteelBlueClick(object sender, EventArgs e)
        {
            color = Color.SteelBlue;
            Default1.BackColor = color;
        }

        //This button changes the line, border or filling color to the given syntax color.
        private void AquaClick(object sender, EventArgs e)
        {
            color = Color.Aqua;
            Default1.BackColor = color;
        }

        //This button changes the line, border or filling color to the given syntax color.
        private void MediumSlateBlueClick(object sender, EventArgs e)
        {
            color = Color.MediumSlateBlue;
            Default1.BackColor = color;
        }

        //This button changes the line, border or filling color to the given syntax color.
        private void RoyalBlueClick(object sender, EventArgs e)
        {
            color = Color.RoyalBlue;
            Default1.BackColor = color;
        }

        //This button changes the line, border or filling color to the given syntax color.
        private void PurpleClick(object sender, EventArgs e)
        {
            color = Color.Purple;
            Default1.BackColor = color;
        }

        //This button changes the line, border or filling color to the given syntax color.
        private void BisqueClick(object sender, EventArgs e)
        {
            color = Color.Bisque;
            Default1.BackColor = color;
        }

        //This section determine what happens when the mouse is down on the canvas.
        private void CanvasMouseDown(object sender, MouseEventArgs e) // MouseEventArgs provides data for the actions of the mouse
        {
            startPoint = e.Location; //Stores the location of the mouse during the mouse event
            if (e.Button == MouseButtons.Left) //defines which mouse button was pressed; in our case we verify if the left mouse button was pressed
            {
                mouseDown = 1;
            }
            /* stroring the coodinates of the mouse */
            currentX = e.X;
            currentY = e.Y;
        }

        //This section determines what happens when the mouse is moving on the canvas.
        private void CanvasMouseMove(object sender, MouseEventArgs e)
        {
            //Displays the mouse position; 
            labelX.Text = "X: " + Convert.ToString(x);
            labelY.Text = "y: " + Convert.ToString(y);
            if (mouseDown == 1)
            {
                endPoint = e.Location;
                x = e.X;
                y = e.Y;


                //This section handles the tools to the defined syntax color.
                if (figure == "pen" )
                {
                    g.DrawLine(new Pen(color), startPoint, endPoint);
                }
                else if (figure == "eraser")
                {
                    g.FillEllipse(new SolidBrush(color), e.X, e.Y, 30, 30);
                }
                else if (figure == "brush")
                {
                    g.FillEllipse(new SolidBrush(color), e.X, e.Y, 60, 60);
                }
                //sizes
                else if (figure == "size1")
                {
                    g.FillEllipse(new SolidBrush(color), e.X, e.Y, 5, 5);
                }
                else if (figure == "size2")
                {
                    g.FillEllipse(new SolidBrush(color), e.X, e.Y, 15, 15);
                }
                else if (figure == "size3")
                {
                    g.FillEllipse(new SolidBrush(color), e.X, e.Y, 25, 25);
                }
                else if (figure == "size4")
                {
                    g.FillEllipse(new SolidBrush(color), e.X, e.Y, 35, 35);
                }
                
                startPoint = endPoint; //start point = end point
            }
        }

        //This section determines what happens when the mouse is up.
        private void CanvasMouseUp(object sender, MouseEventArgs e)
        {
            /* when mouse is up we set the mousedown variable to false and nothing happens*/
            mouseDown = 0;
        }



        //This section determines what happens when the mouse is clicked.
        private void CanvasMouseClick(object sender, MouseEventArgs e)
        {
            if (mouseDown == 1)
            {
                x = e.X;
                y = e.Y;
                dimensionX = e.X - currentX;
                dimensionY = e.Y - currentY;
                if (figure == "line")
                /* Draws line */
                {
                    g.DrawLine(new Pen(color), currentX, currentY, e.X, e.Y);
                }

                if (figure == "ellipse")
                //Draws ellipse.
                {
                    g.DrawEllipse(new Pen(color), currentX, currentY, dimensionX, dimensionY);
                }
                //Draws rectangle.


                if (figure == "rectangle")

                {
                    g.DrawRectangle(new Pen(color), currentX, currentY, dimensionX, dimensionY);
                }

                // This syntax  draws the rectangle with the filling of rectangle.
                if (figure == "fillRectangle")
                {


                    g.DrawRectangle(new Pen(color), currentX, currentY, dimensionX, dimensionY);
                    Rectangle rt = new Rectangle(currentX, currentY, dimensionX, dimensionY);
                    g.FillRectangle(new SolidBrush(color), rt);


                }

                //// This syntax  draws the ellipse with the filling of the ellipse.
                if (figure == "fillEllipse")
                {

                    SolidBrush solidBrush = new SolidBrush(color);
                    g.FillEllipse(solidBrush, currentX, currentY, dimensionX, dimensionY);

                }
            }
        }

        //This button allows the user to erase all the screen.
        private void EraseAllScreenClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Start New?", "Start New?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Canvas.Refresh(); //invalidates the canvas/ drawing area
                Canvas.Image = null;
            }
        }


        //This section saves the image by calling the SaveFileDialog.
        private void SaveClick(object sender, EventArgs e)
        {
            //bitmap is an object used to images defined by pixel data
            //initializes a new instance of the bitmap class of specified image
            Bitmap bmp = new Bitmap(Canvas.Width, Canvas.Height);
            Graphics g = Graphics.FromImage(bmp);
            Rectangle rect = Canvas.RectangleToScreen(Canvas.ClientRectangle); //stores four integers(location and size of the rectangle)
            g.CopyFromScreen(rect.Location, Point.Empty, Canvas.Size); //performs transfer of color data
            g.Dispose(); //releases all resources used
            SaveFileDialog s = new SaveFileDialog(); //prompts the user to select a location to save the file
            s.Filter = "Png files|.png|jpeg files|*jpg|bitmaps|.bmp"; //gives file the set of extensions the user can chose from
            if (s.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (File.Exists(s.FileName)) //if the file we want to save already exists in the destination folder, we delete the file
                {
                    File.Delete(s.FileName);
                }
                /* here we save the file with the chosen extension */
                if (s.FileName.Contains(".jpg"))
                {
                    bmp.Save(s.FileName, ImageFormat.Jpeg);
                }
                else if (s.FileName.Contains(".png"))
                {
                    bmp.Save(s.FileName, ImageFormat.Png);
                }
                else if (s.FileName.Contains(".bmp"))
                {
                    bmp.Save(s.FileName, ImageFormat.Bmp);
                }
               
            }
        }

        //This section opens image files by calling the OpenFileDialog
        private void OpenClick(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();//displays dialog box that prompts the user to open a file
            o.Filter = "Png files|.png|jpeg files|*jpg|bitmaps|.bmp";
            if (o.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Canvas.Image = (Image)Image.FromFile(o.FileName).Clone(); //gets the image we choose
            }
        }

        //This section handles the exit command in from the file menu.
        private void Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (MessageBox.Show("Do you want to Save your work?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    Bitmap bmp = new Bitmap(Canvas.Width, Canvas.Height);
                    Graphics g = Graphics.FromImage(bmp);
                    Rectangle rect = Canvas.RectangleToScreen(Canvas.ClientRectangle);//stores four integers(location and size of the rectangle)
                    g.CopyFromScreen(rect.Location, Point.Empty, Canvas.Size);//performs transfer of color data
                    g.Dispose();//releases all resources used
                    SaveFileDialog s = new SaveFileDialog();//prompts the user to select a location to save the file
                    s.Filter = "Png files|.png|jpeg files|*jpg|bitmaps|.bmp";//gives file the set of extensions the user can chose from
                    if (s.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        if (File.Exists(s.FileName))//if the file we want to save already exists in the destination folder, we delete the file
                        {
                            File.Delete(s.FileName);
                        }
                        /* here we save the file with the chosen extension */
                        if (s.FileName.Contains(".jpg"))
                        {
                            bmp.Save(s.FileName, ImageFormat.Jpeg);
                        }
                        else if (s.FileName.Contains(".png"))
                        {
                            bmp.Save(s.FileName, ImageFormat.Png);
                        }
                        else if (s.FileName.Contains(".bmp"))
                        {
                            bmp.Save(s.FileName, ImageFormat.Bmp);
                        }
                    }
                }



                Application.Exit();// application closes
            }
        }

        private void Canvas_Click(object sender, EventArgs e)
        {

        }

        private void Default1_Click(object sender, EventArgs e)
        {

        }

        //This button allows the user to edit the colors using the color dialog.
        private void EditColorsClick(object sender, EventArgs e)
        {
            ColorDialog diag = new ColorDialog();// represents common dialog that displays available and custom colors
            diag.ShowDialog(); //runs the common dialog
            color = diag.Color; //changes the color to the selected one
            Default1.BackColor = diag.Color; //and puts it as default


        }


    }
}