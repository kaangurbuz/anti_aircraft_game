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
    class AnaPencere : Form
    {
        
        Jet jett;
        UcakSavar ucakSavar;
        List<Jet> jetler = new List<Jet>();
        List<Fuze> fuzeler = new List<Fuze>();
        Fuze fuze;
        Timer zamanlayici;
        Timer mermiZamanlayici;
        Timer ucakSpawn;
        Timer CarpismaKontrol;
        Random rnd = new Random();
        int restart;
      

        public AnaPencere(int width, int height)
        {
            Height = height;
            Width = width;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            Paint += AnaPencere_Paint;
            KeyDown += AnaPencere_KeyDown;
            Text = "Anti-Aircraft Game (version alpha) ";
            BackColor = System.Drawing.Color.LightBlue;
           
            DoubleBuffered = true;
            ucakSavar = new UcakSavar();
            zamanlayici = new Timer();
            mermiZamanlayici = new Timer();
            ucakSpawn = new Timer();
            fuze = new Fuze();
            CarpismaKontrol = new Timer();
            restart = 1;

            zamanlayici.Interval = 50;
            zamanlayici.Tick += Zamanlayici_Tick;
            mermiZamanlayici.Interval = 100;
            mermiZamanlayici.Tick += MermiZamanlayici_Tick;
            ucakSpawn.Interval = 900;
            ucakSpawn.Tick += UcakSpawn_Tick;
            CarpismaKontrol.Interval = 1;
            CarpismaKontrol.Tick += CarpismaKontrol_Tick;

        }

        private void CarpismaKontrol_Tick(object sender, EventArgs e)
        {
           foreach(var siradaki in jetler)
            {
                foreach(var siradakii in fuzeler)
                {
                    if ((siradaki.aktifJetX() + 50) >= (siradakii.aktifFuzeX()) && (siradaki.aktifJetX())<=((siradakii.aktifFuzeX()+25)) && (siradaki.aktifJetY()+50)>=(siradakii.aktifFuzeY())&&(siradaki.aktifJetY())<=(siradakii.aktifFuzeY()+25))
                        {
                        siradaki.jetYoket(-100);
                        siradakii.fuzeYoket(-100);

                       

                    }

                }
            }
           
        }

        private void UcakSpawn_Tick(object sender, EventArgs e)
        {
            jett = new Jet();

            jetler.Add(jett);

           

        }

        private void MermiZamanlayici_Tick(object sender, EventArgs e)
        {
            foreach (var siradaki in fuzeler)
            {

                siradaki.FuzeYukari();
            }

            Invalidate();
        }

        private void Zamanlayici_Tick(object sender, EventArgs e)
        {
            ucakSpawn.Start();
            foreach (var siradaki in jetler)
            {
                if (siradaki.JetZemindemi() > 0&& siradaki.aktifJetX()>0)
                {
                    zamanlayici.Stop();
                    ucakSpawn.Stop();
                    MessageBox.Show("GAME OVER , Please press \"enter\" for new game..");
                    restart = 0;
                }

            }


            foreach (var siradaki in jetler)
            {

                siradaki.JetAsagiIndir();

            }


            Invalidate();
        }

        private void AnaPencere_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (restart == 0)
                    Application.Restart();

                
                    zamanlayici.Start();
                    CarpismaKontrol.Start();
            }

            if (e.KeyCode == Keys.Right)
            {
                ucakSavar.USavarSagaGit();
                Invalidate();
            }
            if (e.KeyCode == Keys.Left)
            {
                ucakSavar.USavarSolaGit();
                Invalidate();
            }
            if (e.KeyCode == Keys.Space)
            {
                fuze = new Fuze();
                fuzeler.Add(fuze);
                fuze.FuzeAtes(ucakSavar.MermiIcinX());
                mermiZamanlayici.Start();
               
               
                Invalidate();

            }




        }

        private void AnaPencere_Paint(object sender, PaintEventArgs e)
        {
            
           

            foreach (var siradaki in jetler)
            {
                siradaki.JetCiz(e.Graphics);


            }
            foreach (var siradaki in fuzeler)
            {
                siradaki.FuzeCiz(e.Graphics);

            }
            ucakSavar.UcakSavarCiz(e.Graphics);
        }

       

    } // end of class
}// end of namespace
