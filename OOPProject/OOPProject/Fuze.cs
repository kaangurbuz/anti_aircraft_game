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
    class Fuze
    {
        Image FuzePNG;
        private int x;
        private int y;


        public Fuze()
        {
            FuzePNG = Image.FromFile("Fuze.png");

            y = 475;

        }





        public void FuzeCiz(Graphics g)
        {
            g.DrawImage(FuzePNG, x, y);
        }

        public void FuzeAtes(int x)
        {
            this.x = x + 15;
        }

        public void FuzeYukari()
        {
            if (y > -20)
                y -= 10;
        }
        public int aktifFuzeX()
        {
            return x;
        }
        public int aktifFuzeY()
        {
            return y;
        }
        public void fuzeYoket(int yoket)
        {
            x = yoket;
        }
    }
}
