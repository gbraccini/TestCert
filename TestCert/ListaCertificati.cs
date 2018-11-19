using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestCert
{
    class ListaCertificati
    {
  
        private static ListaCertificati instance = null;
        private static readonly object padlock = new object();
        public  ArrayList lista;

        ListaCertificati()
        {
            lista = new ArrayList();

        }

        public static ListaCertificati Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new ListaCertificati();
                    }
                    return instance;
                }
            }
        }

          public void Sort( )
        {
            lista.Sort();
             
        }

         public void  Add( string s )
        {
            lista.Add(s);
        }

    }
}
