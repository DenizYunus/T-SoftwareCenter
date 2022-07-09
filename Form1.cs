using System.ComponentModel;
using System.Net;

namespace CustomStore
{
    public partial class Form1 : Form
    {
        public string downloadingFileName = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // JSONClassParser myDeserializedClass = JsonConvert.DeserializeObject<JSONClassParser>(myJsonResponse);
        }

        private void WhatsAppPanel_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Whatsapp Clicked");
            downloadingFileName = "WhatsApp.exe";
            StartDownload("https://web.whatsapp.com/desktop/windows/release/x64/WhatsAppSetup.exe");
        }

        private void NotePadPPPanel_MouseClick(object sender, MouseEventArgs e)
        {
            downloadingFileName = "NotePadPP.exe";
            StartDownload("https://github.com/notepad-plus-plus/notepad-plus-plus/releases/download/v8.4.3/npp.8.4.3.Installer.x64.exe");
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void StartDownload(string _url)
        {
            Thread thread = new(() => {
                WebClient client = new();
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(Client_DownloadProgressChanged);
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(Client_DownloadFileCompleted);
                client.DownloadFileAsync(new Uri(_url), Environment.CurrentDirectory + "\\" + downloadingFileName);
            });
            thread.Start();
        }

        void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate {
                double bytesIn = double.Parse(e.BytesReceived.ToString());
                double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = bytesIn / totalBytes * 100;
                //label2.Text = "Downloaded " + e.BytesReceived + " of " + e.TotalBytesToReceive;
                downloadingProgressBar.Value = int.Parse(Math.Truncate(percentage).ToString());
            });
        }
        void Client_DownloadFileCompleted(object? sender, AsyncCompletedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate {
                System.Diagnostics.Process process = new();
                System.Diagnostics.ProcessStartInfo startInfo = new()
                {
                    WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                    FileName = "cmd.exe",
                    Arguments = Environment.CurrentDirectory + "\\" + downloadingFileName + (downloadingFileName == "WhatsApp.exe" ? " --silent" : " /S"),
                    Verb = "runas"
                };
                process.StartInfo = startInfo;
                process.Start();
            });
        }
    }
}