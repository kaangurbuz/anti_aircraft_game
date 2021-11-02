/****************************************************************************
***								SAKARYA UNIVERSITY
***					FACULTY OF COMPUTER AND INFORMATION SCIENCES
***							   COMPUTER ENGINEERING
***						    OBJECT ORIENTED PROGRAMMING
***
***         HOMEWORK.......: PROJECT
***			NAME...........: Kaan GURBUZ
***			STUDENT NUMBER.: G1512.10096
***         GROUP..........: D
*** 
****************************************************************************/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace antiAircraftGame
{
    class Jet
    {
        Image JetPNG;
        private int x;
        private int y;
        private int JetZeminde = 0;

        private int[] JetSpawnX = { 0, 50, 100, 150, 200, 250, 300, 350, 400, 450, 500, 550, 600, 650, 700, 750 };

        public Jet()
        {
            JetPNG = Image.FromFile("Jet.png");

            y = 0;
            x = JetSpawnX[RastgeleSayi.SayiUret(0, 15)];

        }


        public void JetCiz(Graphics g)
        {
            g.DrawImage(JetPNG, x, y);
        }

        public void JetAsagiIndir()
        {

            if (y < 520)
                y += 5;
            else
                JetZeminde++;

        }

        public int JetZemindemi()
        {
            return JetZeminde;
        }

        public int aktifJetX()
        {
            return x;
        }
        public int aktifJetY()
        {
            return y;
        }
        public void jetYoket(int yoket)
        {
            x = yoket;
            
            
        }
      
    }
}
