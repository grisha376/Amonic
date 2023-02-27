
namespace Amonic
{
    partial class EditRole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditRole));
            this.CancelButton = new Guna.UI2.WinForms.Guna2Button();
            this.ApplyBtn = new Guna.UI2.WinForms.Guna2Button();
            this.officeLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.officeBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.FirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.EmailTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnExit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.LogLable = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.UserRadioBtn = new Guna.UI2.WinForms.Guna2RadioButton();
            this.AdminRadioBtn = new Guna.UI2.WinForms.Guna2RadioButton();
            this.RoleLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.BorderRadius = 2;
            this.CancelButton.BorderThickness = 1;
            this.CancelButton.CheckedState.Parent = this.CancelButton;
            this.CancelButton.CustomImages.Parent = this.CancelButton;
            this.CancelButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CancelButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CancelButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CancelButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CancelButton.DisabledState.Parent = this.CancelButton;
            this.CancelButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.CancelButton.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.CancelButton.ForeColor = System.Drawing.Color.Black;
            this.CancelButton.HoverState.Parent = this.CancelButton;
            this.CancelButton.Location = new System.Drawing.Point(295, 408);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.ShadowDecoration.Parent = this.CancelButton;
            this.CancelButton.Size = new System.Drawing.Size(120, 32);
            this.CancelButton.TabIndex = 50;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ApplyBtn
            // 
            this.ApplyBtn.BorderRadius = 2;
            this.ApplyBtn.BorderThickness = 1;
            this.ApplyBtn.CheckedState.Parent = this.ApplyBtn;
            this.ApplyBtn.CustomImages.Parent = this.ApplyBtn;
            this.ApplyBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ApplyBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ApplyBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ApplyBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ApplyBtn.DisabledState.Parent = this.ApplyBtn;
            this.ApplyBtn.FillColor = System.Drawing.Color.White;
            this.ApplyBtn.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.ApplyBtn.ForeColor = System.Drawing.Color.Black;
            this.ApplyBtn.HoverState.Parent = this.ApplyBtn;
            this.ApplyBtn.Location = new System.Drawing.Point(74, 408);
            this.ApplyBtn.Name = "ApplyBtn";
            this.ApplyBtn.ShadowDecoration.Parent = this.ApplyBtn;
            this.ApplyBtn.Size = new System.Drawing.Size(120, 32);
            this.ApplyBtn.TabIndex = 49;
            this.ApplyBtn.Text = "Apply";
            this.ApplyBtn.Click += new System.EventHandler(this.ApplyBtn_Click);
            // 
            // officeLabel
            // 
            this.officeLabel.BackColor = System.Drawing.Color.Transparent;
            this.officeLabel.Font = new System.Drawing.Font("Verdana", 10F);
            this.officeLabel.Location = new System.Drawing.Point(91, 232);
            this.officeLabel.Name = "officeLabel";
            this.officeLabel.Size = new System.Drawing.Size(48, 18);
            this.officeLabel.TabIndex = 46;
            this.officeLabel.Text = "Office:";
            // 
            // officeBox
            // 
            this.officeBox.BackColor = System.Drawing.Color.Transparent;
            this.officeBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.officeBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.officeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.officeBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.officeBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.officeBox.FocusedState.Parent = this.officeBox;
            this.officeBox.Font = new System.Drawing.Font("Verdana", 9F);
            this.officeBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.officeBox.HoverState.Parent = this.officeBox;
            this.officeBox.ItemHeight = 30;
            this.officeBox.ItemsAppearance.Parent = this.officeBox;
            this.officeBox.Location = new System.Drawing.Point(209, 225);
            this.officeBox.Name = "officeBox";
            this.officeBox.ShadowDecoration.Parent = this.officeBox;
            this.officeBox.Size = new System.Drawing.Size(238, 36);
            this.officeBox.TabIndex = 45;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Verdana", 10F);
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(87, 171);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(78, 18);
            this.guna2HtmlLabel3.TabIndex = 42;
            this.guna2HtmlLabel3.Text = "Last Name:";
            // 
            // LastName
            // 
            this.LastName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.LastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LastName.DefaultText = "";
            this.LastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LastName.DisabledState.Parent = this.LastName;
            this.LastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LastName.FocusedState.Parent = this.LastName;
            this.LastName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.LastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LastName.HoverState.Parent = this.LastName;
            this.LastName.Location = new System.Drawing.Point(209, 168);
            this.LastName.Name = "LastName";
            this.LastName.PasswordChar = '\0';
            this.LastName.PlaceholderText = "";
            this.LastName.SelectedText = "";
            this.LastName.ShadowDecoration.Parent = this.LastName;
            this.LastName.Size = new System.Drawing.Size(238, 28);
            this.LastName.TabIndex = 41;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Verdana", 10F);
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(87, 121);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(79, 18);
            this.guna2HtmlLabel2.TabIndex = 40;
            this.guna2HtmlLabel2.Text = "First Name:";
            // 
            // FirstName
            // 
            this.FirstName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.FirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FirstName.DefaultText = "";
            this.FirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FirstName.DisabledState.Parent = this.FirstName;
            this.FirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FirstName.FocusedState.Parent = this.FirstName;
            this.FirstName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.FirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FirstName.HoverState.Parent = this.FirstName;
            this.FirstName.Location = new System.Drawing.Point(209, 118);
            this.FirstName.Name = "FirstName";
            this.FirstName.PasswordChar = '\0';
            this.FirstName.PlaceholderText = "";
            this.FirstName.SelectedText = "";
            this.FirstName.ShadowDecoration.Parent = this.FirstName;
            this.FirstName.Size = new System.Drawing.Size(238, 28);
            this.FirstName.TabIndex = 39;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Verdana", 10F);
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(87, 65);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(98, 18);
            this.guna2HtmlLabel1.TabIndex = 38;
            this.guna2HtmlLabel1.Text = "Email address:";
            // 
            // EmailTxtBox
            // 
            this.EmailTxtBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.EmailTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailTxtBox.DefaultText = "";
            this.EmailTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmailTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmailTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailTxtBox.DisabledState.Parent = this.EmailTxtBox;
            this.EmailTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailTxtBox.FocusedState.Parent = this.EmailTxtBox;
            this.EmailTxtBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EmailTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(66)))), ((int)(((byte)(61)))));
            this.EmailTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailTxtBox.HoverState.Parent = this.EmailTxtBox;
            this.EmailTxtBox.Location = new System.Drawing.Point(209, 62);
            this.EmailTxtBox.Name = "EmailTxtBox";
            this.EmailTxtBox.PasswordChar = '\0';
            this.EmailTxtBox.PlaceholderText = "";
            this.EmailTxtBox.SelectedText = "";
            this.EmailTxtBox.ShadowDecoration.Parent = this.EmailTxtBox;
            this.EmailTxtBox.Size = new System.Drawing.Size(238, 28);
            this.EmailTxtBox.TabIndex = 37;
            // 
            // BtnExit
            // 
            this.BtnExit.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnExit.CheckedState.Parent = this.BtnExit;
            this.BtnExit.HoverState.ImageSize = new System.Drawing.Size(24, 24);
            this.BtnExit.HoverState.Parent = this.BtnExit;
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.ImageOffset = new System.Drawing.Point(0, 0);
            this.BtnExit.ImageRotate = 0F;
            this.BtnExit.ImageSize = new System.Drawing.Size(24, 24);
            this.BtnExit.Location = new System.Drawing.Point(480, 2);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.PressedState.ImageSize = new System.Drawing.Size(24, 24);
            this.BtnExit.PressedState.Parent = this.BtnExit;
            this.BtnExit.ShadowDecoration.Parent = this.BtnExit;
            this.BtnExit.Size = new System.Drawing.Size(20, 20);
            this.BtnExit.TabIndex = 36;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LogLable
            // 
            this.LogLable.BackColor = System.Drawing.Color.Transparent;
            this.LogLable.Font = new System.Drawing.Font("Verdana", 10F);
            this.LogLable.Location = new System.Drawing.Point(12, 2);
            this.LogLable.Name = "LogLable";
            this.LogLable.Size = new System.Drawing.Size(60, 18);
            this.LogLable.TabIndex = 35;
            this.LogLable.Text = "Edit Role";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.Black;
            this.guna2Separator1.Location = new System.Drawing.Point(-1, 19);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(522, 10);
            this.guna2Separator1.TabIndex = 34;
            // 
            // UserRadioBtn
            // 
            this.UserRadioBtn.AutoSize = true;
            this.UserRadioBtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserRadioBtn.CheckedState.BorderThickness = 0;
            this.UserRadioBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserRadioBtn.CheckedState.InnerColor = System.Drawing.Color.White;
            this.UserRadioBtn.CheckedState.InnerOffset = -4;
            this.UserRadioBtn.Font = new System.Drawing.Font("Verdana", 10F);
            this.UserRadioBtn.Location = new System.Drawing.Point(209, 293);
            this.UserRadioBtn.Name = "UserRadioBtn";
            this.UserRadioBtn.Size = new System.Drawing.Size(58, 21);
            this.UserRadioBtn.TabIndex = 51;
            this.UserRadioBtn.Text = "User";
            this.UserRadioBtn.UncheckedState.BorderColor = System.Drawing.Color.Black;
            this.UserRadioBtn.UncheckedState.BorderThickness = 2;
            this.UserRadioBtn.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.UserRadioBtn.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // AdminRadioBtn
            // 
            this.AdminRadioBtn.AutoSize = true;
            this.AdminRadioBtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AdminRadioBtn.CheckedState.BorderThickness = 0;
            this.AdminRadioBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AdminRadioBtn.CheckedState.InnerColor = System.Drawing.Color.White;
            this.AdminRadioBtn.CheckedState.InnerOffset = -4;
            this.AdminRadioBtn.Font = new System.Drawing.Font("Verdana", 10F);
            this.AdminRadioBtn.Location = new System.Drawing.Point(209, 331);
            this.AdminRadioBtn.Name = "AdminRadioBtn";
            this.AdminRadioBtn.Size = new System.Drawing.Size(122, 21);
            this.AdminRadioBtn.TabIndex = 52;
            this.AdminRadioBtn.Text = "Administrator";
            this.AdminRadioBtn.UncheckedState.BorderColor = System.Drawing.Color.Black;
            this.AdminRadioBtn.UncheckedState.BorderThickness = 2;
            this.AdminRadioBtn.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.AdminRadioBtn.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // RoleLbl
            // 
            this.RoleLbl.BackColor = System.Drawing.Color.Transparent;
            this.RoleLbl.Font = new System.Drawing.Font("Verdana", 10F);
            this.RoleLbl.Location = new System.Drawing.Point(91, 296);
            this.RoleLbl.Name = "RoleLbl";
            this.RoleLbl.Size = new System.Drawing.Size(36, 18);
            this.RoleLbl.TabIndex = 53;
            this.RoleLbl.Text = "Role:";
            // 
            // EditRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(520, 466);
            this.Controls.Add(this.RoleLbl);
            this.Controls.Add(this.AdminRadioBtn);
            this.Controls.Add(this.UserRadioBtn);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ApplyBtn);
            this.Controls.Add(this.officeLabel);
            this.Controls.Add(this.officeBox);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.EmailTxtBox);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.LogLable);
            this.Controls.Add(this.guna2Separator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditRole";
            this.Load += new System.EventHandler(this.EditRole_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button CancelButton;
        private Guna.UI2.WinForms.Guna2Button ApplyBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel officeLabel;
        private Guna.UI2.WinForms.Guna2ComboBox officeBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox LastName;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox FirstName;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox EmailTxtBox;
        private Guna.UI2.WinForms.Guna2ImageButton BtnExit;
        private Guna.UI2.WinForms.Guna2HtmlLabel LogLable;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2RadioButton UserRadioBtn;
        private Guna.UI2.WinForms.Guna2RadioButton AdminRadioBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel RoleLbl;
    }
}