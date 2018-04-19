namespace RadioProject
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnPlay = new System.Windows.Forms.Button();
            this.WindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.cmbChannel = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(5, 93);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(272, 32);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.Play_Click);
            // 
            // WindowsMediaPlayer1
            // 
            this.WindowsMediaPlayer1.CausesValidation = false;
            this.WindowsMediaPlayer1.Enabled = true;
            this.WindowsMediaPlayer1.Location = new System.Drawing.Point(6, 5);
            this.WindowsMediaPlayer1.Name = "WindowsMediaPlayer1";
            this.WindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WindowsMediaPlayer1.OcxState")));
            this.WindowsMediaPlayer1.Size = new System.Drawing.Size(270, 63);
            this.WindowsMediaPlayer1.TabIndex = 1;
            // 
            // cmbCountry
            // 
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(6, 70);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(110, 21);
            this.cmbCountry.TabIndex = 2;
            this.cmbCountry.SelectedIndexChanged += new System.EventHandler(this.cmbCountry_SelectedIndexChanged);
            // 
            // cmbChannel
            // 
            this.cmbChannel.FormattingEnabled = true;
            this.cmbChannel.Location = new System.Drawing.Point(122, 70);
            this.cmbChannel.Name = "cmbChannel";
            this.cmbChannel.Size = new System.Drawing.Size(154, 21);
            this.cmbChannel.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnPlay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(281, 132);
            this.Controls.Add(this.cmbChannel);
            this.Controls.Add(this.cmbCountry);
            this.Controls.Add(this.WindowsMediaPlayer1);
            this.Controls.Add(this.btnPlay);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(297, 171);
            this.MinimumSize = new System.Drawing.Size(297, 171);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "World Radio";
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private AxWMPLib.AxWindowsMediaPlayer WindowsMediaPlayer1;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.ComboBox cmbChannel;
    }
}

