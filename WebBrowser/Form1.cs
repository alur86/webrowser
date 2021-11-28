using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;




namespace WebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
          
                string URL = textURL.Text.Trim();
                webBrowser1.Navigate(URL, "_self", null, "User-Agent:Mozilla/5.0 (iPhone; U; CPU like Mac OS X; en) AppleWebKit/420+ (KHTML, like Gecko) Version/3.0 Mobile/1C25 Safari/419.3");
                Form1.ActiveForm.Text = URL;
                    


        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void exitMenuItem_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void homeMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void forwardMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void backMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void refreshMenuItem_Click(object sender, EventArgs e)
        {
            if (!webBrowser1.Url.Equals("about:blank"))
            {
                webBrowser1.Refresh();
            }
        }

        private void stopMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }


        private void searchMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoSearch();
        }

    

        private void exitToolItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonGo_KeyDown(object sender, KeyEventArgs e)
        {
            string URL = textURL.Text.Trim();
            webBrowser1.Navigate(URL, "_self", null, "User-Agent:Mozilla/5.0 (iPhone; U; CPU like Mac OS X; en) AppleWebKit/420+ (KHTML, like Gecko) Version/3.0 Mobile/1C25 Safari/419.3");
        }

        private void textURL_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textURL.Text.Trim()))
            {
               errorProvider1.SetError(textURL, "URL address is required.");
            }
            else
            {
                errorProvider1.SetError(textURL, string.Empty);
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            textURL.Text = webBrowser1.Url.ToString();

            if (webBrowser1.CanGoBack)
            {
              backMenuItem.Enabled = true;
            }
            else
            {
                backMenuItem.Enabled = false;
            }

            if (webBrowser1.CanGoForward)
            {
                forwardMenuItem.Enabled = true;
            }
            else
            {
                forwardMenuItem.Enabled = false;
            }
        }

      
    }
}
