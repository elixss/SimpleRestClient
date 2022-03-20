using System.Net;
using Newtonsoft.Json;

namespace PerformApiCalls
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void GetRequest()
        {
            Cursor = Cursors.WaitCursor;
            var url = UriTextBox.Text;
            try
            {
                var request = (HttpWebRequest)WebRequest.Create(url);
                ResponseTextBox.Text = "Executing request ...";
                if (!AuthTextBox.Text.Replace(" ", String.Empty).Replace(" ", String.Empty).Equals("") || AuthTextBox.Text != null)
                {
                    request.Headers.Add("Authorization", AuthTextBox.Text);
                }
                request.Method = "GET";
                request.Accept = "application/json";
                var response = (HttpWebResponse)request.GetResponse();
                using (var streamReader = new StreamReader(response.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    ResponseTextBox.Text = result;
                };
            }
            catch (Exception ex)
            {
                if (ex is WebException)
                {
                    ResponseTextBox.Text = ex.Message;
                }
                else if (ex is UriFormatException)
                {
                    MessageBox.Show("Invalid URI entered", "The URI you entered is invalid.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("An error occurred", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Cursor = Cursors.Default;
        }

        private static string FormatJson(string json)
        {
            dynamic parseJson = JsonConvert.DeserializeObject(json);
            return JsonConvert.SerializeObject(parseJson, Formatting.Indented);
        }


        // element events
        private void RequestButton_Click(object sender, EventArgs e)
        {
            GetRequest();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            const string Information = "Developed by elixss - Open Source on GitHub.\nCreated to provide non-blocking way of fetching data from REST APIs that don't have Access-Control-Origin for browsers.";
            const string Header = "About this program";
            MessageBox.Show(Information, Header, MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void SourceButton_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://github.com/elixss/SimpleRestClient",
                UseShellExecute = true
            });
        }

        private void HideAuthCheck_Click(object sender, EventArgs e)
        {
            if (HideAuthCheck.Checked)
            {
                AuthTextBox.UseSystemPasswordChar = true;
            }
            else
            {
                AuthTextBox.UseSystemPasswordChar = false;
            }
        }

        private void SupportButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "http://invite.managebot.xyz",
                UseShellExecute = true
            });
            SupportButton.Text = "Thanks for supporting me!";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}