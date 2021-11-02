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
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace antiAircraftGame
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new AnaPencere(800, 600));
        }
    }
}
