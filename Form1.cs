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

                foreach(Software item in myDeserializedClass.Softwares)
                {
                    Panel panel = new Panel();
                    panel.Size = new Size(150, 150);
                    panel.Padding = new Padding(20, 20, 20, 20);
                    panel.Location = new Point(xPos, yPos);
                    panel.MouseClick += ((e, d) => { StartDownload(item.FileURL, item.SilentCommand); });
                    AppsPanel.Controls.Add(panel);

                    xPos += 150;
                    //yPos += 150;

                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Dock = DockStyle.Top;
                    pictureBox.Size = new Size(140, 80);

                    var request = WebRequest.Create(item.IconURL);
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        pictureBox.BackgroundImage = Bitmap.FromStream(stream);
                    }
                    pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureBox.MouseClick += ((e, d) => { StartDownload(item.FileURL, item.SilentCommand); });
                    panel.Controls.Add(pictureBox);

                    Label label = new Label();
                    label.Text = item.Name;
                    label.Dock = DockStyle.Bottom;
                    label.ForeColor = Color.White;
                    label.Font = new Font("Segoe UI", 12);
                    label.MouseClick += ((e, d) => { StartDownload(item.FileURL, item.SilentCommand); });
                    panel.Controls.Add(label);

                    panel.Refresh();
                }
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void StartDownload(string _url, string _silentCommand)
        {
            itemSilenceCommand = _silentCommand;
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
            });
        }
    }
}