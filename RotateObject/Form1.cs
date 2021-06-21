using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RotateObject
{
    public partial class Form1 : Form
    {
        Planet[] planet = new Planet[7];
        Graphics g; //declare a graphics object called g so we can draw on the Form
        Spaceship spaceship = new Spaceship(); //create an instance of the Spaceship Class called spaceship
        bool turnLeft, turnRight;
        //declare a list  missiles from the Missile class
        List<Planet> planets = new List<Planet>();
        List<Missile> missiles = new List<Missile>();
        string move;
        int score, lives;





        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 7; i++)
            {
                int displacement = 10 + (i * 70);
                planets.Add(new Planet(displacement));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //get the graphics used to paint on the Form control
            g = e.Graphics;
            //Draw the spaceship
            spaceship.drawSpaceship(g);
            foreach (Missile m in missiles)
            {
                m.drawMissile(g);
                m.moveMissile(g);
            }
            foreach (Planet p in planets)
            {
                p.Draw(g);//Draw the planet
                p.MovePlanet(g);//move the planet



                //if the planet reaches the bottom of the form relocate it back to the top
                if (p.y >= ClientSize.Height)
                {
                    p.y = -20;
                }

            }
            }



        private void tmrSpaceship_Tick(object sender, EventArgs e)
        {
            if (turnRight)
            {
                spaceship.rotationAngle += 5;
            }
            if (turnLeft) { 
                spaceship.rotationAngle -= 5;
        }
    
        Invalidate();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { turnLeft = true; }
            if (e.KeyData == Keys.Right) { turnRight = true; }

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                missiles.Add(new Missile(spaceship.spaceRec, spaceship.rotationAngle));
            }

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void tmrShoot_Tick(object sender, EventArgs e)
        {
            foreach (Planet p in planets)
            {

                {
                    foreach (Missile m in missiles)
                    {
                        //sort out removing missiles that exit the game area
                        if (m.missileRec.Y > (this.ClientSize.Height) || (m.missileRec.Y < 0) || (m.missileRec.X > this.ClientSize.Width) || (m.missileRec.X < 0))
                        {
                            missiles.Remove(m);
                            break;
                        }
                        if (p.planetRec.IntersectsWith(m.missileRec))


                        {
                            p.y = -20;// relocate planet to the top of the form
                            missiles.Remove(m);
                            break;
                        }
                      
                    }
                }
            }
            }

        private void LbsScore1_Click(object sender, EventArgs e)
        {

        }

        private void LbLives_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { turnLeft = false; }
            if (e.KeyData == Keys.Right) { turnRight = false ; }
        }
    }
}
