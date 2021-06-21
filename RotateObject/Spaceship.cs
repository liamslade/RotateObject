using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Drawing2D;
using System.Drawing;

using System.Threading.Tasks;

namespace RotateObject
{
    class Spaceship
    {
        // declare fields to use in the class

        public int x, y, width, height;//variables for the rectangle
        public Image spaceship;//variable for the planet's image

        public Rectangle spaceRec;//variable for a rectangle to place our image in
        public int rotationAngle;
        public Matrix matrix;
        Point centre;


        //Create a constructor (initialises the values of the fields)
        public Spaceship()
        {
            x = 200;
            y = 180;
            width = 50;
            height = 50;
            rotationAngle = 90;
            spaceship = Properties.Resources.gif3;
            spaceRec = new Rectangle(x, y, width, height);
        }
      

        //methods
        public void drawSpaceship(Graphics g)
        {
            //find the centre point of spaceRec
            centre = new Point(spaceRec.X + width / 2, spaceRec.Y + width / 2);
            //instantiate a Matrix object called matrix
            matrix = new Matrix();
            //rotate the matrix (spaceRec) about its centre
            matrix.RotateAt(rotationAngle, centre);
            //Set the current draw location to the rotated matrix point
            g.Transform = matrix;
            //draw the spaceship

            g.DrawImage(spaceship, spaceRec);
        }
    }



}
