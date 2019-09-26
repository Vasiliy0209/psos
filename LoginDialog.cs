using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;

namespace MessengerApp
{
    public partial class LoginDialog : Form
    {
        private string _vk_access_token;
        public LoginDialog()
        {
            InitializeComponent();
        }

        public string vk_access_token
        {
            get { return _vk_access_token; }
            set { _vk_access_token = value; }
        }
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            try
            {
                string args = e.Url.OriginalString.Split(new string[] { "#" }, StringSplitOptions.None)[1];
                var get_params = HttpUtility.ParseQueryString(args);
                // MessageBox.Show(get_params["access_token"]);
                _vk_access_token = get_params["access_token"];
                Close();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
