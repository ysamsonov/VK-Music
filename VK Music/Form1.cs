using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace VK_Music
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
            Autoriz();
        }

        private void Autoriz()
        {
            this.AuthWebBrowser.Navigate(String.Format("https://oauth.vk.com/authorize?client_id={0}&scope={1}&redirect_uri={2}&display=page&response_type=token",VKSettings.AppID, VKSettings.Scope, VKSettings.RedirectUri));
        }

        private void AuthWebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (e.Url.ToString().IndexOf("access_token") != -1)
            {
                Regex mr = new Regex(@"(?<name>[\w\d\x5f]+)=(?<value>[^\x26\s]+)", RegexOptions.IgnoreCase | RegexOptions.Singleline);
                foreach(Match m in mr.Matches(e.Url.ToString()))
                {
                    if (m.Groups["name"].Value == "access_token")
                        VKSettings.AccesToken = m.Groups["value"].Value;
                    if (m.Groups["name"].Value == "user_id")
                        VKSettings.UserID = m.Groups["value"].Value;
                }
                this.Hide();
                MessageBox.Show("Авторизация прошла успешно", "Авторизация");
            }
            //if (AuthWebBrowser.DocumentText.IndexOf("OAuth Blank") != -1) this.Hide();
        }
    }
}