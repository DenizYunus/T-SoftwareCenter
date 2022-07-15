namespace CustomStore.CustomControls
{
    partial class SoftwareControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.installStatusLabel = new System.Windows.Forms.Label();
            this.appNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox.Location = new System.Drawing.Point(20, 20);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(110, 60);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // installStatusLabel
            // 
            this.installStatusLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.installStatusLabel.Location = new System.Drawing.Point(20, 115);
            this.installStatusLabel.Name = "installStatusLabel";
            this.installStatusLabel.Size = new System.Drawing.Size(110, 15);
            this.installStatusLabel.TabIndex = 1;
            this.installStatusLabel.Text = "Not Installed";
            this.installStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // appNameLabel
            // 
            this.appNameLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.appNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.appNameLabel.Location = new System.Drawing.Point(20, 88);
            this.appNameLabel.Name = "appNameLabel";
            this.appNameLabel.Size = new System.Drawing.Size(110, 27);
            this.appNameLabel.TabIndex = 2;
            this.appNameLabel.Text = "SoftwareName";
            this.appNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SoftwareControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.appNameLabel);
            this.Controls.Add(this.installStatusLabel);
            this.Controls.Add(this.pictureBox);
            this.Name = "SoftwareControl";
            this.Padding = new System.Windows.Forms.Padding(20);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox;
        private Label installStatusLabel;
        private Label appNameLabel;
    }
}
