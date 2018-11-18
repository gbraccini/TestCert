using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCert
{
    static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);



            splash s = new splash();
            Application.Run(s);


//            splash.ShowSplashScreen();
 
           Form1 mainForm = new Form1(); //this takes ages
            
             
  //       splash.JoinSplashScreen();
    //        splash.CloseForm();
            mainForm.Focus();
           Application.Run(mainForm);
        }



    }
}
