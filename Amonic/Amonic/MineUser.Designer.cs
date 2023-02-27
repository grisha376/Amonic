
namespace Amonic
{
    partial class MineUser
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MineUser));
            this.WelcomeLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TrecingGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.LogLable = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.spentTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.timerLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CrashesLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ExitButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator4 = new Guna.UI2.WinForms.Guna2Separator();
            ((System.ComponentModel.ISupportInitialize)(this.TrecingGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeLabel.Font = new System.Drawing.Font("Verdana", 10F);
            this.WelcomeLabel.Location = new System.Drawing.Point(19, 82);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(256, 18);
            this.WelcomeLabel.TabIndex = 39;
            this.WelcomeLabel.Text = "Hi USER, Welcome to AMONIC Airlines.";
            // 
            // TrecingGridView
            // 
            this.TrecingGridView.AllowUserToAddRows = false;
            this.TrecingGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.TrecingGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.TrecingGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TrecingGridView.BackgroundColor = System.Drawing.Color.White;
            this.TrecingGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TrecingGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TrecingGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TrecingGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.TrecingGridView.ColumnHeadersHeight = 20;
            this.TrecingGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TrecingGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.TrecingGridView.EnableHeadersVisualStyles = false;
            this.TrecingGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TrecingGridView.Location = new System.Drawing.Point(19, 170);
            this.TrecingGridView.Name = "TrecingGridView";
            this.TrecingGridView.ReadOnly = true;
            this.TrecingGridView.RowHeadersVisible = false;
            this.TrecingGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TrecingGridView.Size = new System.Drawing.Size(789, 302);
            this.TrecingGridView.TabIndex = 37;
            this.TrecingGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.TrecingGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.TrecingGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.TrecingGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.TrecingGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.TrecingGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.TrecingGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TrecingGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TrecingGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TrecingGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.TrecingGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.TrecingGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TrecingGridView.ThemeStyle.HeaderStyle.Height = 20;
            this.TrecingGridView.ThemeStyle.ReadOnly = true;
            this.TrecingGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.TrecingGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TrecingGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.TrecingGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.TrecingGridView.ThemeStyle.RowsStyle.Height = 22;
            this.TrecingGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TrecingGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2Separator3
            // 
            this.guna2Separator3.FillColor = System.Drawing.Color.Black;
            this.guna2Separator3.Location = new System.Drawing.Point(-1, 54);
            this.guna2Separator3.Name = "guna2Separator3";
            this.guna2Separator3.Size = new System.Drawing.Size(827, 3);
            this.guna2Separator3.TabIndex = 34;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(24, 24);
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(24, 24);
            this.guna2ImageButton1.Location = new System.Drawing.Point(792, 1);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(24, 24);
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.ShadowDecoration.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(20, 20);
            this.guna2ImageButton1.TabIndex = 29;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // LogLable
            // 
            this.LogLable.BackColor = System.Drawing.Color.Transparent;
            this.LogLable.Font = new System.Drawing.Font("Verdana", 10F);
            this.LogLable.Location = new System.Drawing.Point(12, 2);
            this.LogLable.Name = "LogLable";
            this.LogLable.Size = new System.Drawing.Size(241, 18);
            this.LogLable.TabIndex = 28;
            this.LogLable.Text = "AMONIC Airlines Automation System";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.Black;
            this.guna2Separator1.Location = new System.Drawing.Point(-1, 19);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(827, 10);
            this.guna2Separator1.TabIndex = 27;
            // 
            // spentTimeTimer
            // 
            this.spentTimeTimer.Interval = 1000;
            this.spentTimeTimer.Tick += new System.EventHandler(this.spentTimeTimer_Tick);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Verdana", 10F);
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(267, 120);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(155, 18);
            this.guna2HtmlLabel1.TabIndex = 40;
            this.guna2HtmlLabel1.Text = "Time spent on system:";
            // 
            // timerLabel
            // 
            this.timerLabel.BackColor = System.Drawing.Color.Transparent;
            this.timerLabel.Font = new System.Drawing.Font("Verdana", 10F);
            this.timerLabel.Location = new System.Drawing.Point(428, 120);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(63, 18);
            this.timerLabel.TabIndex = 41;
            this.timerLabel.Text = "00:00:00";
            // 
            // CrashesLbl
            // 
            this.CrashesLbl.BackColor = System.Drawing.Color.Transparent;
            this.CrashesLbl.Font = new System.Drawing.Font("Verdana", 10F);
            this.CrashesLbl.Location = new System.Drawing.Point(551, 120);
            this.CrashesLbl.Name = "CrashesLbl";
            this.CrashesLbl.Size = new System.Drawing.Size(145, 18);
            this.CrashesLbl.TabIndex = 42;
            this.CrashesLbl.Text = "Number of crashes: 0";
            // 
            // ExitButton
            // 
            this.ExitButton.CheckedState.Parent = this.ExitButton;
            this.ExitButton.CustomImages.Parent = this.ExitButton;
            this.ExitButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ExitButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ExitButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ExitButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ExitButton.DisabledState.Parent = this.ExitButton;
            this.ExitButton.FillColor = System.Drawing.Color.White;
            this.ExitButton.Font = new System.Drawing.Font("Verdana", 8F);
            this.ExitButton.ForeColor = System.Drawing.Color.Black;
            this.ExitButton.HoverState.Parent = this.ExitButton;
            this.ExitButton.Location = new System.Drawing.Point(-1, 33);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.ShadowDecoration.Parent = this.ExitButton;
            this.ExitButton.Size = new System.Drawing.Size(50, 15);
            this.ExitButton.TabIndex = 44;
            this.ExitButton.Text = "Exit";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // guna2Separator4
            // 
            this.guna2Separator4.FillColor = System.Drawing.Color.Black;
            this.guna2Separator4.Location = new System.Drawing.Point(14, 49);
            this.guna2Separator4.Name = "guna2Separator4";
            this.guna2Separator4.Size = new System.Drawing.Size(7, 1);
            this.guna2Separator4.TabIndex = 43;
            // 
            // MineUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(825, 519);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.guna2Separator4);
            this.Controls.Add(this.CrashesLbl);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.TrecingGridView);
            this.Controls.Add(this.guna2Separator3);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.LogLable);
            this.Controls.Add(this.guna2Separator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MineUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MineUser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MineUser_FormClosing);
            this.Load += new System.EventHandler(this.MineUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TrecingGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel WelcomeLabel;
        private Guna.UI2.WinForms.Guna2DataGridView TrecingGridView;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator3;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2HtmlLabel LogLable;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Timer spentTimeTimer;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel timerLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel CrashesLbl;
        private Guna.UI2.WinForms.Guna2Button ExitButton;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator4;
    }
}