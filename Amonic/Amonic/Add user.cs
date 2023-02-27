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
    public partial class Add_user : Form
    {
        Session1_XXEntities db = new Session1_XXEntities();
        string emUs;
        public Add_user(string email)
        {
            InitializeComponent();
            emUs = email;

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Add_user_Load(object sender, EventArgs e)
        {
            Offices offices = db.Offices.FirstOrDefault();
            var TablePr = db.Offices.ToList();
            officeBox.DataSource = TablePr;
            officeBox.DisplayMember = "Title";
            officeBox.ValueMember = "ID";
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmailTxtBox.Text != string.Empty && FirstName.Text != string.Empty && LastName.Text != string.Empty && Password.Text!=string.Empty)
                {
                    string emailNewUs, FName, LName, Passwod;
                    DateTime Bith;
                    int idOf;

                    emailNewUs = EmailTxtBox.Text;
                    FName = FirstName.Text;
                    LName = LastName.Text;
                    Passwod = Password.Text;
                    idOf = Convert.ToInt32(officeBox.SelectedValue);
                    Bith =Convert.ToDateTime(BithdateDateTime.Value.ToShortDateString());

                    Users user_new = new Users { Email = emailNewUs, FirstName = FName, Birthdate = Bith, Password = Passwod, LastName = LName, RoleID = 2, OfficeID = idOf, Active = false };

                    db.Users.Add(user_new);
                    db.SaveChanges();
                    MessageBox.Show("Вы успешно добавили нового пользователя");
                    //IngredientsForm ingredients = new IngredientsForm();
                    //this.Close();
                    //ingredients.IngredientTable();
                    //ingredients.Visible = true;
                    //ingredients.ShowInTaskbar = true;

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

        private void CancelButton_Click(object sender, EventArgs e)
        {
            MineAdmin mineAdmin = new MineAdmin(emUs);
            mineAdmin.Show();
            this.Hide();
        }
    }
}
