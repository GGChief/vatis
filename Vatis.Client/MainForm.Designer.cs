
namespace Vatsim.Vatis.Client
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
            this.tabContainer = new System.Windows.Forms.Panel();
            this.atisTabs = new Vatsim.Vatis.Client.UI.Tabs();
            this.hitTestPanel1 = new Vatsim.Vatis.Client.UI.HitTestPanel();
            this.btnMinify = new Vatsim.Vatis.Client.UI.ExButton();
            this.btnSettings = new Vatsim.Vatis.Client.UI.ExButton();
            this.btnMinimize = new Vatsim.Vatis.Client.UI.ExButton();
            this.btnManageProfile = new Vatsim.Vatis.Client.UI.ExButton();
            this.utcClock = new Vatsim.Vatis.Client.UI.HitTestLabel();
            this.btnClose = new Vatsim.Vatis.Client.UI.ExButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabContainer.SuspendLayout();
            this.hitTestPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabContainer
            // 
            this.tabContainer.Controls.Add(this.atisTabs);
            this.tabContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabContainer.Location = new System.Drawing.Point(1, 46);
            this.tabContainer.Name = "tabContainer";
            this.tabContainer.Padding = new System.Windows.Forms.Padding(8);
            this.tabContainer.Size = new System.Drawing.Size(848, 323);
            this.tabContainer.TabIndex = 3;
            // 
            // atisTabs
            // 
            this.atisTabs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.atisTabs.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.atisTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.atisTabs.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.atisTabs.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.atisTabs.Location = new System.Drawing.Point(8, 8);
            this.atisTabs.Name = "atisTabs";
            this.atisTabs.SelectedIndex = 0;
            this.atisTabs.Size = new System.Drawing.Size(832, 307);
            this.atisTabs.TabIndex = 0;
            this.atisTabs.SelectedIndexChanged += new System.EventHandler(this.atisTabs_SelectedIndexChanged);
            // 
            // hitTestPanel1
            // 
            this.hitTestPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.hitTestPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.hitTestPanel1.Controls.Add(this.pictureBox1);
            this.hitTestPanel1.Controls.Add(this.btnMinify);
            this.hitTestPanel1.Controls.Add(this.btnSettings);
            this.hitTestPanel1.Controls.Add(this.btnMinimize);
            this.hitTestPanel1.Controls.Add(this.btnManageProfile);
            this.hitTestPanel1.Controls.Add(this.utcClock);
            this.hitTestPanel1.Controls.Add(this.btnClose);
            this.hitTestPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.hitTestPanel1.Location = new System.Drawing.Point(1, 1);
            this.hitTestPanel1.Name = "hitTestPanel1";
            this.hitTestPanel1.ShowBorder = false;
            this.hitTestPanel1.Size = new System.Drawing.Size(848, 45);
            this.hitTestPanel1.TabIndex = 2;
            this.hitTestPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.hitTestPanel1_Paint);
            // 
            // btnMinify
            // 
            this.btnMinify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnMinify.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnMinify.Clicked = false;
            this.btnMinify.ClickedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnMinify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinify.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnMinify.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMinify.ForeColor = System.Drawing.Color.White;
            this.btnMinify.Image = ((System.Drawing.Image)(resources.GetObject("btnMinify.Image")));
            this.btnMinify.Location = new System.Drawing.Point(766, 10);
            this.btnMinify.Name = "btnMinify";
            this.btnMinify.Pushed = false;
            this.btnMinify.PushedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnMinify.Size = new System.Drawing.Size(20, 25);
            this.btnMinify.TabIndex = 5;
            this.btnMinify.UseVisualStyleBackColor = false;
            this.btnMinify.Click += new System.EventHandler(this.btnMinify_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSettings.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnSettings.Clicked = false;
            this.btnSettings.ClickedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(9, 10);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Pushed = false;
            this.btnSettings.PushedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnSettings.Size = new System.Drawing.Size(81, 25);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnMinimize.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnMinimize.Clicked = false;
            this.btnMinimize.ClickedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(792, 10);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Pushed = false;
            this.btnMinimize.PushedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnMinimize.Size = new System.Drawing.Size(20, 25);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.Text = "–";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnManageProfile
            // 
            this.btnManageProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnManageProfile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnManageProfile.Clicked = false;
            this.btnManageProfile.ClickedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnManageProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageProfile.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnManageProfile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnManageProfile.ForeColor = System.Drawing.Color.White;
            this.btnManageProfile.Location = new System.Drawing.Point(96, 10);
            this.btnManageProfile.Name = "btnManageProfile";
            this.btnManageProfile.Pushed = false;
            this.btnManageProfile.PushedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnManageProfile.Size = new System.Drawing.Size(121, 25);
            this.btnManageProfile.TabIndex = 3;
            this.btnManageProfile.Text = "Manage Profile";
            this.btnManageProfile.UseVisualStyleBackColor = false;
            this.btnManageProfile.Click += new System.EventHandler(this.btnManageProfile_Click);
            // 
            // utcClock
            // 
            this.utcClock.AutoSize = true;
            this.utcClock.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.utcClock.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.utcClock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.utcClock.Location = new System.Drawing.Point(640, 8);
            this.utcClock.Name = "utcClock";
            this.utcClock.ShowBorder = false;
            this.utcClock.Size = new System.Drawing.Size(116, 28);
            this.utcClock.TabIndex = 1;
            this.utcClock.Text = "00:00/00";
            this.utcClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(84)))), ((int)(((byte)(51)))));
            this.btnClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnClose.Clicked = false;
            this.btnClose.ClickedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(819, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Pushed = false;
            this.btnClose.PushedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnClose.Size = new System.Drawing.Size(20, 25);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(521, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(850, 370);
            this.ControlBox = false;
            this.Controls.Add(this.tabContainer);
            this.Controls.Add(this.hitTestPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "vATIS";
            this.tabContainer.ResumeLayout(false);
            this.hitTestPanel1.ResumeLayout(false);
            this.hitTestPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UI.ExButton btnClose;
        private UI.ExButton btnMinimize;
        private UI.HitTestPanel hitTestPanel1;
        private UI.HitTestLabel utcClock;
        private System.Windows.Forms.Panel tabContainer;
        private UI.Tabs atisTabs;
        private UI.ExButton btnManageProfile;
        private UI.ExButton btnSettings;
        private UI.ExButton btnMinify;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

