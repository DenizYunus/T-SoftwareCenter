using Utility;

namespace CustomStore.CustomControls
{
    public partial class SoftwarePackControl : UserControl
    {
        public SoftwarePackControl()
        {
            InitializeComponent();
        }

        public async void SetSpecs(string _packName, string[] _softwareList)
        {
            packNameLabel.Text = _packName;
            softwareListLabel.Text = "";
            int c = 0;

            foreach (var x in _softwareList)
            {
                softwareListLabel.Text += "\n" + JsonHelper.GetSoftwareByID(Convert.ToInt32(x))!.Name;
            };

            if (_softwareList != null)
            {
                if (_softwareList.Length > 0)
                    if (_softwareList[0] != null)
                    {
                        Task<Image> getImageTask = new Task<Image>(() => Utilities.GetBitmapFromURL(JsonHelper.GetSoftwareByID(Convert.ToInt32(_softwareList[0]))!.IconURL).Result);
                        getImageTask.Start();
                        getImageTask.Wait();
                        //var gTask = getImageTask as Task<Image>;
                        pictureBox1.BackgroundImage = getImageTask.Result;
                    }
                        

                if (_softwareList.Length > 1)
                    if (_softwareList[1] != null)
                        pictureBox2.BackgroundImage = await Utilities.GetBitmapFromURL(JsonHelper.GetSoftwareByID(Convert.ToInt32(_softwareList[1]))!.IconURL);

                //if (_softwareList.Length > 2)
                //    if (_softwareList[2] != null)
                //        pictureBox3.BackgroundImage = Task.Run<Image>(async () => await Utilities.GetBitmapFromURL(JsonHelper.GetSoftwareByID(Convert.ToInt32(_softwareList[2]))!.IconURL)).Result;

                //if (_softwareList.Length > 3)
                //    if (_softwareList[3] != null)
                //        pictureBox4.BackgroundImage = Task.Run<Image>(async () => await Utilities.GetBitmapFromURL(JsonHelper.GetSoftwareByID(Convert.ToInt32(_softwareList[3]))!.IconURL)).Result;
            }
        }
    }
}