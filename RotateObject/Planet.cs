using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;

namespace RotateObject
{

    class Planet
    {
        // declare fields to use in the class

        public int x, y, width, height, rotationAngle, rotationSpeed = 0;//variables for the rectangle
        public Image planetImage;//variable for the planet's image
        Random rand = new Random();
        public Matrix matrix;
        Point centre;

        public Rectangle planetRec;//variable for a rectangle to place our image in

        //Create a constructor (initialises the values of the fields)
        public Planet(int displacement)
        {
            x = displacement;
            y = 10;
            width = 40;
            height = 40;
            rotationAngle = rand.Next();
            planetImage = Properties.Resources.z3;
            planetRec = new Rectangle(x, y, width, height);
        }

        // Methods for the Planet class
        public void Draw(Graphics g)
        {
           

            centre = new Point(planetRec.X + width / 2, planetRec.Y + width / 2);
            matrix = new Matrix();
            matrix.RotateAt(rotationSpeed, centre);
            g.Transform = matrix;

            planetRec = new Rectangle(x, y, width, height);
            g.DrawImage(planetImage, planetRec);
        }
        public void MovePlanet(Graphics g)
        {
            y += 1;
            planetRec.Location = new Point(x, y);

        }
    }
}
