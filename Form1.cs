using System.ComponentModel;
using Utility;
using System.Net;
using Newtonsoft.Json;
using System.Diagnostics;

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
            int xPos = 0;
            int yPos = 0;
            using (HttpClient client = new HttpClient())
            {
                string s = client.GetStringAsync("http://127.0.0.1/SoftwareCenter/softwareList.json").Result;
                JSONClassParser? myDeserializedClass = JsonConvert.DeserializeObject<JSONClassParser>(s);

                foreach (Software item in myDeserializedClass.Softwares)
                {
                    Label installationStatusLabel = new Label()
                    {
                        Text = "Not Installed",
                        Font = new Font("Segoe UI", 9),
                        ForeColor = Color.White,
                        Dock = DockStyle.Bottom,
                        AutoSize = false,
                        TextAlign = ContentAlignment.MiddleCenter
                    };

                    Panel panel = new Panel()
                    {
                        Size = new Size(150, 150),
                        Padding = new Padding(20, 20, 20, 20),
                        Location = new Point(xPos, yPos)
                    };
                    panel.MouseClick += ((e, d) => { StartDownload(item.FileURL, item.SilentCommand, installationStatusLabel); });
                    AppsPanel.Controls.Add(panel);

                    xPos += 150;
                    //yPos += 150;

                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Dock = DockStyle.Top;
                    pictureBox.Size = new Size(60, 60);

                    var request = WebRequest.Create(item.IconURL);
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        pictureBox.BackgroundImage = Bitmap.FromStream(stream);
                    }
                    pictureBox.BackgroundImageLayout = ImageLayout.Zoom;
                    pictureBox.MouseClick += ((e, d) => { StartDownload(item.FileURL, item.SilentCommand, installationStatusLabel); });
                    panel.Controls.Add(pictureBox);

                    Label appName = new Label()
                    {
                        Text = item.Name,
                        Dock = DockStyle.Bottom,
                        ForeColor = Color.White,
                        Font = new Font("Segoe UI", 12),
                        AutoSize = false,
                        TextAlign = ContentAlignment.MiddleCenter
                    };
                    MouseClick += ((e, d) => { StartDownload(item.FileURL, item.SilentCommand, installationStatusLabel); });
                    panel.Controls.Add(appName);
                    panel.Controls.Add(installationStatusLabel);

                    panel.Refresh();
                }
            }
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
                WebClient client = new();
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