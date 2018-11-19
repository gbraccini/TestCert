using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Collections;
using System.Threading;
using System.ComponentModel;
namespace TestCert
{
    
  
    public partial class splash : Form
    { 
        //Delegate for cross thread call to close
        private delegate void CloseDelegate();

        //The type of form to be displayed as the splash screen.
        private static splash splashForm;

        private static Thread thread, threadLoadCErtificate;
        public splash()
        {
            InitializeComponent();
        }
       

        static public void ShowSplashScreen()
        {
            // Make sure it is only launched once.

            if (splashForm != null)
                return;
            thread = new Thread(new ThreadStart(splash.ShowForm));
            thread.IsBackground = false;
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        static public void JoinSplashScreen()
        {
           // thread.Join();
            threadLoadCErtificate.Join();
        }
        static private void ShowForm()
        {
            splashForm = new splash();
            Application.Run(splashForm);
        }

        static public void CloseForm()
        {
            splashForm.Invoke(new CloseDelegate(splash.CloseFormInternal));
        }

        static private void CloseFormInternal()
        {
            splashForm.Close();
            splashForm = null;
        }

        private void splash_Load(object sender, EventArgs e)
        {
        }

        
        private void splash_Activated(object sender, EventArgs e)
        {
        }

        private void LoadCertificate()
        {
            var store = new X509Store(StoreName.Root, StoreLocation.LocalMachine);
            store.Open(OpenFlags.ReadOnly);


            // Set Minimum to 1 to represent the first file being copied.
            this.InvokeEx(f => f.pBarCert.Minimum = 1);

            // Set Maximum to the total number of files to copy.
            this.InvokeEx(f => f.pBarCert.Maximum = store.Certificates.Count);
            // Set the initial value of the ProgressBar.
            this.InvokeEx(f => f.pBarCert.Value = 1);
            // Set the Step property to a value of 1 to represent each file being copied.
            this.InvokeEx(f => f.pBarCert.Step = 1);

            ListaCertificati lista = ListaCertificati.Instance;


            foreach (X509Certificate2 x509 in store.Certificates)
            {
                this.InvokeEx(f => f.pBarCert.PerformStep());
                Console.WriteLine("certificate name: {0}", x509.Subject);
                Console.WriteLine("Simple Name: {0}{1}", x509.GetNameInfo(X509NameType.SimpleName, true), Environment.NewLine);
                lista.Add(x509.GetNameInfo(X509NameType.SimpleName, true) + " - " + x509.FriendlyName);
               // Thread.Sleep(1);


            }
            lista.Sort();
            Thread.Sleep(500);
            this.InvokeEx(f => f.Close());
           
        }
        private void splash_Shown(object sender, EventArgs e)
        {
            threadLoadCErtificate = new Thread(new ThreadStart(LoadCertificate));
            threadLoadCErtificate.IsBackground = false;
            threadLoadCErtificate.SetApartmentState(ApartmentState.STA);
            threadLoadCErtificate.Start();

            
        }

      
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void splash_FormClosed(object sender, FormClosedEventArgs e)
        {
       Thread.Sleep(50);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    public static class ISynchronizeInvokeExtensions
    {
        public static void InvokeEx<T>(this T @this, Action<T> action) where T : ISynchronizeInvoke
        {
            if (@this.InvokeRequired)
            {
                @this.Invoke(action, new object[] { @this });
            }
            else
            {
                action(@this);
            }
        }
    }
}
