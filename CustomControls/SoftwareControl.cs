using Utility;

namespace CustomStore.CustomControls
{
    public partial class SoftwareControl : UserControl
    {
        public SoftwareControl()
        {
            InitializeComponent();
        }

        public async Task SetSpecs(Software _software)
        {
            appNameLabel.Text = _software.Name;
            installStatusLabel.Text = JsonHelper.CheckSoftwareIsInstalledByID(_software.Id) ? "Installed" : "Not Installed";
            //pictureBox.BackgroundImage = Utilities.GetBitmapFromURL(_iconURL).Result;
            pictureBox.BackgroundImage = Task.Run<Image>(async () => await Utilities.GetBitmapFromURL(_software.IconURL)).Result;
        }
    }
}
