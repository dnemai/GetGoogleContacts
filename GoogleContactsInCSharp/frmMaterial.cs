using System;
using Google.Apis.Auth.OAuth2;
using System.Windows.Forms;
using Google.GData.Client;
using Google.Contacts;
using System.IO;
using System.Threading;
using Google.Apis.Util.Store;

namespace GoogleContactsInCSharp
{
    public partial class frmMaterial : Form
    {
        public frmMaterial()
        {
            InitializeComponent();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdGetGoogleContacts_Click(object sender, EventArgs e)
        {
            string[] scopes = new string[] { "https://www.googleapis.com/auth/contacts.readonly" }; 
            var stream = new FileStream("..\\..\\client_secret.json", FileMode.Open, FileAccess.Read);
            UserCredential credential = GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.Load(stream).Secrets
                                                                                             , scopes
                                                                                             , "user"
                                                                                             , CancellationToken.None
                                                                                             , new FileDataStore("user")).Result;

            
            OAuth2Parameters parameters = new OAuth2Parameters();
            parameters.AccessToken = credential.Token.AccessToken;
            parameters.RefreshToken = credential.Token.RefreshToken;
            parameters.ApprovalPrompt = "force";
            parameters.AccessType = "offline";
            PpulateContacts(parameters);
        }

        private void PpulateContacts(OAuth2Parameters parameters)
        {

            RequestSettings settings = new RequestSettings("Google contacts tutorial", parameters);
            ContactsRequest cr = new ContactsRequest(settings);
            Feed<Contact> f = cr.GetContacts();
            foreach (Contact c in f.Entries)
            {
                lstContacts.Items.Add(c.Name.FullName + Environment.NewLine + c.PrimaryEmail.Address);
            }


        }
    }
}
