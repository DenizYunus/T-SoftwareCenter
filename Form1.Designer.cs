namespace CustomStore
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.downloadingProgressBar = new System.Windows.Forms.ProgressBar();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.roundedButton1 = new CustomStore.RoundedButton();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TopPickPanel = new System.Windows.Forms.Panel();
            this.AppsPanel = new System.Windows.Forms.Panel();
            this.itemContainer = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.GamesPanel = new System.Windows.Forms.Panel();
            this.LeftPanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.AppsPanel.SuspendLayout();
            this.itemContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(156)))), ((int)(((byte)(228)))));
            this.LeftPanel.Controls.Add(this.downloadingProgressBar);
            this.LeftPanel.Controls.Add(this.button2);
            this.LeftPanel.Controls.Add(this.button1);
            this.LeftPanel.Controls.Add(this.roundedButton1);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(30, 20);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(200, 821);
            this.LeftPanel.TabIndex = 0;
            // 
            // downloadingProgressBar
            // 
            this.downloadingProgressBar.Location = new System.Drawing.Point(9, 234);
            this.downloadingProgressBar.Name = "downloadingProgressBar";
            this.downloadingProgressBar.Size = new System.Drawing.Size(183, 23);
            this.downloadingProgressBar.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(30, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "User Panel";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(30, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Home";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.Location = new System.Drawing.Point(30, 175);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(148, 39);
            this.roundedButton1.TabIndex = 0;
            this.roundedButton1.Text = "Settings";
            this.roundedButton1.UseVisualStyleBackColor = false;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.panel1);
            this.HeaderPanel.Controls.Add(this.button3);
            this.HeaderPanel.Controls.Add(this.textBox1);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(230, 20);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(624, 100);
            this.HeaderPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(593, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(31, 100);
            this.panel1.TabIndex = 2;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.BackgroundImage = global::CustomStore.Properties.Resources.cancel_96px;
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Location = new System.Drawing.Point(0, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(31, 30);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(170, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(54, 50);
            this.button3.TabIndex = 1;
            this.button3.Text = "Find";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 23);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 48);
            this.textBox1.TabIndex = 0;
            // 
            // TopPickPanel
            // 
            this.TopPickPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPickPanel.Location = new System.Drawing.Point(230, 120);
            this.TopPickPanel.Name = "TopPickPanel";
            this.TopPickPanel.Size = new System.Drawing.Size(624, 173);
            this.TopPickPanel.TabIndex = 2;
            // 
            // AppsPanel
            // 
            this.AppsPanel.Controls.Add(this.itemContainer);
            this.AppsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AppsPanel.Location = new System.Drawing.Point(230, 293);
            this.AppsPanel.Name = "AppsPanel";
            this.AppsPanel.Size = new System.Drawing.Size(624, 300);
            this.AppsPanel.TabIndex = 3;
            // 
            // itemContainer
            // 
            this.itemContainer.Controls.Add(this.label3);
            this.itemContainer.Controls.Add(this.pictureBox3);
            this.itemContainer.Location = new System.Drawing.Point(1, -8);
            this.itemContainer.Name = "itemContainer";
            this.itemContainer.Padding = new System.Windows.Forms.Padding(20, 0, 20, 10);
            this.itemContainer.Size = new System.Drawing.Size(150, 150);
            this.itemContainer.TabIndex = 3;
            this.itemContainer.TabStop = false;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "WhatsApp";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::CustomStore.Properties.Resources.WhatsApp1;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox3.Location = new System.Drawing.Point(20, 16);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(110, 90);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // GamesPanel
            // 
            this.GamesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GamesPanel.Location = new System.Drawing.Point(230, 593);
            this.GamesPanel.Name = "GamesPanel";
            this.GamesPanel.Size = new System.Drawing.Size(624, 248);
            this.GamesPanel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(79)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(884, 861);
            this.Controls.Add(this.GamesPanel);
            this.Controls.Add(this.AppsPanel);
            this.Controls.Add(this.TopPickPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.LeftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LeftPanel.ResumeLayout(false);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.AppsPanel.ResumeLayout(false);
            this.itemContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel LeftPanel;
        private RoundedButton roundedButton1;
        private Button button1;
        private Button button2;
        private Panel HeaderPanel;
        private Button button3;
        private TextBox textBox1;
        private Panel TopPickPanel;
        private Panel AppsPanel;
        private Panel GamesPanel;
        private Button CloseButton;
        private ProgressBar downloadingProgressBar;
        private Panel panel1;
        private GroupBox itemContainer;
        private Label label3;
        private PictureBox pictureBox3;
    }
}