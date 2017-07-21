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
            //Using GUID to force application asking for consent every time button is clicked
            string user = Guid.NewGuid().ToString();
            string[] scopes = new string[] { "https://www.googleapis.com/auth/contacts.readonly" }; 

            //Get this JSON by creating project in developer console. Download the JSON
            var stream = new FileStream("..\\..\\client_secret.json", FileMode.Open, FileAccess.Read);
            UserCredential credential = GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.Load(stream).Secrets
                                                                                             , scopes
                                                                                             , user
                                                                                             , CancellationToken.None
                                                                                             , new FileDataStore(user)).Result;

            //Authorize : Use assemblies from DLL distribution
            OAuth2Parameters parameters = new OAuth2Parameters();
            parameters.AccessToken = credential.Token.AccessToken;
            parameters.RefreshToken = credential.Token.RefreshToken;
            parameters.ApprovalPrompt = "force";
            parameters.AccessType = "offline";

            //Show contacts
            PopulateContacts(parameters);
        }

        private void PopulateContacts(OAuth2Parameters parameters)
        {

            RequestSettings settings = new RequestSettings("Material Login", parameters);
            ContactsRequest cr = new ContactsRequest(settings);
            Feed<Contact> f = cr.GetContacts();
            foreach (Contact c in f.Entries)
            {
                Label lbl = new Label();
                lbl.Text = c.Name.FullName + Environment.NewLine + c.PrimaryEmail.Address;

                var index = dataGridContacts.Rows.Add();
                dataGridContacts.Rows[index].Cells["NameAndEmail"].Value = c.Name.FullName + Environment.NewLine + c.PrimaryEmail.Address;
                dataGridContacts.Rows[index].Cells["chkBox"].Value = "true";

            }


        }
    }
}
