/*
 * Florence 17 novembre 2018. Engineered by Gianluca Braccini <ITIS A.Meucci>
 System.IO.File.WriteAllBytes(@"C:\MyFile.bin", ProjectNamespace.Properties.Resources.MyFile);
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Collections;

namespace TestCert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean trovato = false;
            //Opens the local machine  certificates store.
            X509Store store = new X509Store(StoreName.Root, StoreLocation.LocalMachine);
            store.Open(OpenFlags.MaxAllowed);
            X509Certificate2 certificate = new X509Certificate2();

            //Create certificates from certificate files.
            //You must put in a valid path to three certificates in the following constructors.
            X509Certificate2 certificate1 = new X509Certificate2(".\\firebird.cer");
          
                       

            //Add certificates to the store.
            store.Add(certificate1);
            if (!store.Certificates.Contains(certificate1))
            {
                store.Add(certificate1);
            }
/*
            ArrayList lista = new ArrayList();


            foreach (X509Certificate2 x509 in store.Certificates)
            {
                Console.WriteLine("certificate name: {0}", x509.Subject);
                Console.WriteLine("Simple Name: {0}{1}", x509.GetNameInfo(X509NameType.SimpleName, true), Environment.NewLine);
                lista.Add(x509.GetNameInfo(X509NameType.SimpleName, true) + " - " + x509.FriendlyName);
                if ((x509.GetNameInfo(X509NameType.SimpleName, true) + " - " + x509.FriendlyName).ToUpper().Contains("FIREBIRD"))
                {
                    trovato = true;
                }

            }
            lista.Sort();

            if (trovato)
                button_add_certificate.Enabled = false;*/

            if (!store.Certificates.Contains(certificate1))
            {
                string message = "Certificate has not been added . Cancel this operation?";
                string caption = "Error Detected";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.

                result = MessageBox.Show(message, caption, buttons);
            }

            store.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListaCertificati lista = ListaCertificati.Instance;
            listBoxCert.DataSource = lista.lista;
            int index = listBoxCert.FindString("cert");
            // Determine if a valid index is returned. Select the item if it is valid.
            if (index != -1)
            {
                button_add_certificate.Enabled = false;
                listBoxCert.SetSelected(index, true);
            }
            else
                button_add_certificate.Enabled = true; 
        }
    }
}
