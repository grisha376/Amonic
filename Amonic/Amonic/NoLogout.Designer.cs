
namespace Amonic
{
    partial class NoLogout
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoLogout));
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.Logout = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.noLogoutLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.reasonLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.reasonBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.softwareRadioButton = new Guna.UI2.WinForms.Guna2RadioButton();
            this.systemRadioButton = new Guna.UI2.WinForms.Guna2RadioButton();
            this.confirmButton = new Guna.UI2.WinForms.Guna2Button();
            this.Excitbtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.Black;
            this.guna2Separator1.Location = new System.Drawing.Point(0, 19);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(638, 10);
            this.guna2Separator1.TabIndex = 0;
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.Color.Transparent;
            this.Logout.Font = new System.Drawing.Font("Verdana", 10F);
            this.Logout.Location = new System.Drawing.Point(13, 2);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(131, 18);
            this.Logout.TabIndex = 1;
            this.Logout.Text = "No logout detected";
            // 
            // noLogoutLabel
            // 
            this.noLogoutLabel.BackColor = System.Drawing.Color.Transparent;
            this.noLogoutLabel.Font = new System.Drawing.Font("Verdana", 11F);
            this.noLogoutLabel.Location = new System.Drawing.Point(50, 73);
            this.noLogoutLabel.Name = "noLogoutLabel";
            this.noLogoutLabel.Size = new System.Drawing.Size(476, 20);
            this.noLogoutLabel.TabIndex = 3;
            this.noLogoutLabel.Text = "No logout detected for your last login on 06/07/2017 at 08:22";
            // 
            // reasonLabel
            // 
            this.reasonLabel.BackColor = System.Drawing.Color.Transparent;
            this.reasonLabel.Font = new System.Drawing.Font("Verdana", 11F);
            this.reasonLabel.Location = new System.Drawing.Point(50, 129);
            this.reasonLabel.Name = "reasonLabel";
            this.reasonLabel.Size = new System.Drawing.Size(65, 20);
            this.reasonLabel.TabIndex = 4;
            this.reasonLabel.Text = "Reason:";
            // 
            // reasonBox
            // 
            this.reasonBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.reasonBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.reasonBox.DefaultText = "";
            this.reasonBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.reasonBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.reasonBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.reasonBox.DisabledState.Parent = this.reasonBox;
            this.reasonBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.reasonBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.reasonBox.FocusedState.Parent = this.reasonBox;
            this.reasonBox.Font = new System.Drawing.Font("Verdana", 9F);
            this.reasonBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.reasonBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.reasonBox.HoverState.Parent = this.reasonBox;
            this.reasonBox.Location = new System.Drawing.Point(50, 165);
            this.reasonBox.Multiline = true;
            this.reasonBox.Name = "reasonBox";
            this.reasonBox.PasswordChar = '\0';
            this.reasonBox.PlaceholderText = "";
            this.reasonBox.SelectedText = "";
            this.reasonBox.ShadowDecoration.Parent = this.reasonBox;
            this.reasonBox.Size = new System.Drawing.Size(493, 183);
            this.reasonBox.TabIndex = 5;
            // 
            // softwareRadioButton
            // 
            this.softwareRadioButton.AutoSize = true;
            this.softwareRadioButton.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.softwareRadioButton.CheckedState.BorderThickness = 0;
            this.softwareRadioButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.softwareRadioButton.CheckedState.InnerColor = System.Drawing.Color.White;
            this.softwareRadioButton.CheckedState.InnerOffset = -4;
            this.softwareRadioButton.Font = new System.Drawing.Font("Verdana", 9F);
            this.softwareRadioButton.Location = new System.Drawing.Point(50, 374);
            this.softwareRadioButton.Name = "softwareRadioButton";
            this.softwareRadioButton.Size = new System.Drawing.Size(123, 18);
            this.softwareRadioButton.TabIndex = 6;
            this.softwareRadioButton.Text = "Software Crash";
            this.softwareRadioButton.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.softwareRadioButton.UncheckedState.BorderThickness = 2;
            this.softwareRadioButton.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.softwareRadioButton.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // systemRadioButton
            // 
            this.systemRadioButton.AutoSize = true;
            this.systemRadioButton.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.systemRadioButton.CheckedState.BorderThickness = 0;
            this.systemRadioButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.systemRadioButton.CheckedState.InnerColor = System.Drawing.Color.White;
            this.systemRadioButton.CheckedState.InnerOffset = -4;
            this.systemRadioButton.Font = new System.Drawing.Font("Verdana", 9F);
            this.systemRadioButton.Location = new System.Drawing.Point(225, 374);
            this.systemRadioButton.Name = "systemRadioButton";
            this.systemRadioButton.Size = new System.Drawing.Size(112, 18);
            this.systemRadioButton.TabIndex = 7;
            this.systemRadioButton.Text = "System Crash";
            this.systemRadioButton.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.systemRadioButton.UncheckedState.BorderThickness = 2;
            this.systemRadioButton.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.systemRadioButton.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // confirmButton
            // 
            this.confirmButton.BorderRadius = 2;
            this.confirmButton.BorderThickness = 1;
            this.confirmButton.CheckedState.Parent = this.confirmButton;
            this.confirmButton.CustomImages.Parent = this.confirmButton;
            this.confirmButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.confirmButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.confirmButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.confirmButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.confirmButton.DisabledState.Parent = this.confirmButton;
            this.confirmButton.FillColor = System.Drawing.Color.White;
            this.confirmButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirmButton.ForeColor = System.Drawing.Color.Black;
            this.confirmButton.HoverState.Parent = this.confirmButton;
            this.confirmButton.Location = new System.Drawing.Point(420, 366);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.ShadowDecoration.Parent = this.confirmButton;
            this.confirmButton.Size = new System.Drawing.Size(121, 32);
            this.confirmButton.TabIndex = 8;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // Excitbtn
            // 
            this.Excitbtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Excitbtn.CheckedState.Parent = this.Excitbtn;
            this.Excitbtn.HoverState.ImageSize = new System.Drawing.Size(24, 24);
            this.Excitbtn.HoverState.Parent = this.Excitbtn;
            this.Excitbtn.Image = ((System.Drawing.Image)(resources.GetObject("Excitbtn.Image")));
            this.Excitbtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.Excitbtn.ImageRotate = 0F;
            this.Excitbtn.ImageSize = new System.Drawing.Size(24, 24);
            this.Excitbtn.Location = new System.Drawing.Point(610, 2);
            this.Excitbtn.Name = "Excitbtn";
            this.Excitbtn.PressedState.ImageSize = new System.Drawing.Size(24, 24);
            this.Excitbtn.PressedState.Parent = this.Excitbtn;
            this.Excitbtn.ShadowDecoration.Parent = this.Excitbtn;
            this.Excitbtn.Size = new System.Drawing.Size(20, 20);
            this.Excitbtn.TabIndex = 9;
            this.Excitbtn.Click += new System.EventHandler(this.Excitbtn_Click);
            // 
            // NoLogout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(637, 450);
            this.Controls.Add(this.Excitbtn);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.systemRadioButton);
            this.Controls.Add(this.softwareRadioButton);
            this.Controls.Add(this.reasonBox);
            this.Controls.Add(this.reasonLabel);
            this.Controls.Add(this.noLogoutLabel);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.guna2Separator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NoLogout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.NoLogout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2HtmlLabel Logout;
        private Guna.UI2.WinForms.Guna2HtmlLabel noLogoutLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel reasonLabel;
        private Guna.UI2.WinForms.Guna2TextBox reasonBox;
        private Guna.UI2.WinForms.Guna2RadioButton softwareRadioButton;
        private Guna.UI2.WinForms.Guna2RadioButton systemRadioButton;
        private Guna.UI2.WinForms.Guna2Button confirmButton;
        private Guna.UI2.WinForms.Guna2ImageButton Excitbtn;
    }
}

