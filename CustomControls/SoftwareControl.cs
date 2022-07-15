using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomStore.CustomControls
{
    public partial class SoftwareControl : UserControl
    {
        public SoftwareControl()
        {
            InitializeComponent();
        }

        public void SetSpecs(string _appName, string _installationStatus, Image _pictureIcon)
        {
            appNameLabel.Text = _appName;
            installStatusLabel.Text = _installationStatus;
            pictureBox.BackgroundImage = _pictureIcon;
        }
    }
}
