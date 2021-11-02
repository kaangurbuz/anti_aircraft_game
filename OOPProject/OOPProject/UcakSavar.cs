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
using System.Windows.Forms;

namespace antiAircraftGame
{
    class UcakSavar
    {


        Image UcakSavarPNG;


        public UcakSavar() // constructor
        {

            UcakSavarPNG = Image.FromFile("UcakSavar.png");

            USavarX = 0;


        }


        public void UcakSavarCiz(Graphics g)
        {
            g.DrawImage(UcakSavarPNG, USavarX, 500);
        }

        public void USavarSolaGit()
        {
            if (USavarX > 0)
                USavarX -= 50;
        }
        public void USavarSagaGit()
        {
            if (USavarX < 700)
                USavarX += 50;
        }

        public int MermiIcinX()
        {
            return USavarX;
        }


        private int USavarX;



    } // end of class
}// end of namespace
