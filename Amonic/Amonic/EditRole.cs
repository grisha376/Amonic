using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amonic
{
    public partial class EditRole : Form
    {
        string FName;
        string emUs;
        int idUs;
        Session1_XXEntities db = new Session1_XXEntities();
        public EditRole(int id, string email)
        {
            InitializeComponent();
            idUs = id;
            emUs = email;
        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmailTxtBox.Text != string.Empty && FirstName.Text != string.Empty && LastName.Text != string.Empty || (UserRadioBtn.Checked == false && AdminRadioBtn.Checked == false))
                {
                    if (UserRadioBtn.Checked)
                    {
                        Users userss = db.Users.Where(p => p.ID == idUs).FirstOrDefault();
                        userss.Email = EmailTxtBox.Text;
                        userss.FirstName = FirstName.Text;
                        userss.LastName = LastName.Text;
                        userss.RoleID = 2;
                        userss.OfficeID = Convert.ToInt32(officeBox.SelectedValue);
                        db.SaveChanges();
                        MessageBox.Show("Вы успешно обновили данные о пользователе!");
                    }
                    if (AdminRadioBtn.Checked)
                    {
                        Users userss = db.Users.Where(p => p.ID == idUs).FirstOrDefault();
                        userss.Email = EmailTxtBox.Text;
                        userss.FirstName = FirstName.Text;
                        userss.LastName = LastName.Text;
                        userss.RoleID = 1;
                        userss.OfficeID = Convert.ToInt32(officeBox.SelectedValue);
                        db.SaveChanges();
                        MessageBox.Show("Вы успешно обновили данные о пользователе!");
                    }

                }
                else
                {
                    MessageBox.Show("Заполните все поля!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            MineAdmin mine = new MineAdmin(emUs);
            mine.Show();
            this.Hide();
        }

        private void EditRole_Load(object sender, EventArgs e)
        {
            Users userss = db.Users.Where(p => p.ID == idUs).FirstOrDefault();
            EmailTxtBox.Text = userss.Email.ToString();
            FirstName.Text = userss.FirstName.ToString();
            LastName.Text = userss.LastName.ToString();

            if(userss.RoleID==1)
            {
                AdminRadioBtn.Checked = true;
                UserRadioBtn.Checked = false;
            }
            if (userss.RoleID == 2)
            {
                UserRadioBtn.Checked = true;
                AdminRadioBtn.Checked = false;

            }
            var TablePr = db.Offices.ToList();
            officeBox.DataSource = TablePr;
            officeBox.DisplayMember = "Title";
            officeBox.ValueMember = "ID";

        }
    }
}
