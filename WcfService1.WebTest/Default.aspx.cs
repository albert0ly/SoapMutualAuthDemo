using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WcfService1.WebTest
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // WARNING: This disables all SSL certificate validation. Use only for development!
            System.Net.ServicePointManager.ServerCertificateValidationCallback +=
                (sender2, cert, chain, sslPolicyErrors) => true;

            var client = new ServiceReference1.Service1Client();


            // If your service requires a client certificate, include this section
            X509Store store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
            store.Open(OpenFlags.ReadOnly);
            var certs = store.Certificates.Find(X509FindType.FindBySubjectName, "YourClientCert", false);
            if (certs.Count > 0)
            {
                client.ClientCredentials.ClientCertificate.Certificate = certs[0];
            }
            store.Close();

            // Call the GetData method with a single integer parameter
            var result = client.GetData(123);


            //var client = new localhost.Service1();

            //// Find the certificate in the store
            //X509Store store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
            //store.Open(OpenFlags.ReadOnly);
            //var certs = store.Certificates.Find(X509FindType.FindBySubjectName, "YourClientCert", false);
            //if (certs.Count > 0)
            //{
            //    client.ClientCertificates.Add(certs[0]);
            //}
            //store.Close();

            //var result = client.GetData(123, true);

        }
    }
}