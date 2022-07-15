using System.ComponentModel;
using Utility;
using System.Net;
using Newtonsoft.Json;
using System.Diagnostics;
using CustomStore.CustomControls;

namespace CustomStore
{
    public partial class Form1 : Form
    {
        public string downloadingFileName = "";
        public string itemSilenceCommand = null!;
        Label installationStatusLabel = null!;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Task.Run(() => InitializeSoftwaresInForm());
        }

        public void InitializeSoftwaresInForm()
        {
            if (InvokeRequired) ///TODO: INVOKING PREVENTS LOADING AS ASYNC, HERE WILL BE CHANGED TO ASYNC
                Invoke((Delegate)(() =>
                {
                    int xPos = 0;
                    int yPos = 0;

                    foreach (Software item in JsonHelper.GetSoftwares())
                    {
                        SoftwareControl sc = new();
                        sc.SetSpecs(item.Name, JsonHelper.CheckSoftwareIsInstalledByID(item.Id) ? "Installed" : "Not Installed", Task.Run<Image>(async () => await Utilities.GetBitmapFromURL(item.IconURL)).Result);
                        sc.Location = new Point(xPos, yPos);
                        AppsPanel.Controls.Add(sc);
                        xPos += 150;
                    }

                    xPos = 0;
                    foreach (SoftwarePack sp in JsonHelper.GetSoftwarePacks())
                    {
                        SoftwarePackControl spc = new();
                        spc.SetSpecs(sp.Name, sp.Softwares);
                        spc.Location = new Point(xPos, yPos);
                        PacksPanel.Controls.Add(spc);
                        yPos += 150;
                    }
                }));
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void StartDownload(string _url, string _silentCommand, Label _installationstatusLabel)
        {
            itemSilenceCommand = _silentCommand;
            installationStatusLabel = _installationstatusLabel;
            Thread thread = new(() => {
#pragma warning disable SYSLIB0014 // Type or member is obsolete
                WebClient client = new();
#pragma warning restore SYSLIB0014 // Type or member is obsolete
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(Client_DownloadProgressChanged);
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(Client_DownloadFileCompleted);
                client.DownloadFileAsync(new Uri(_url), Environment.CurrentDirectory + "\\temp.exe");
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
                Process process = new();
                ProcessStartInfo startInfo = new()
                {
                    WindowStyle = ProcessWindowStyle.Hidden,
                    FileName = Environment.CurrentDirectory + @"\temp.exe",
                    Arguments = itemSilenceCommand,
                    Verb = "runas",
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                process.StartInfo = startInfo;
                process.Start();
                installationStatusLabel.Text = "Installed";
            });
        }
    }
}