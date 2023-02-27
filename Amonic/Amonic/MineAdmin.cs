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
    public partial class MineAdmin : Form
    {
        string emailAdministrator, enterDateTime;
        Session1_XXEntities db = new Session1_XXEntities();
        public MineAdmin(string email)
        {
            InitializeComponent();
            emailAdministrator = email;
        }

        private void MineAdmin_Load(object sender, EventArgs e)
        {
            OfTable();


        }

        string FName, LName, EmailAd, OfficeName, UserRole;
        bool act;
        private void officeBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            OfTable();
        }


        private void changeRoleButton_Click(object sender, EventArgs e)
        {
            EditRole editRole = new EditRole(id, emailAdministrator);
            editRole.Show();
            this.Hide();
        }

        private void AddUsBtn_Click(object sender, EventArgs e)
        {
            Add_user add_User = new Add_user(emailAdministrator);
            add_User.Show();
            this.Hide();
        }
        int idTrec, idInform;
        DateTime Getdt = DateTime.Now;
        private void ExitButton_Click(object sender, EventArgs e)
        {
   

            trecking tr_U= db.trecking.Where(p => p.Email == emailAdministrator).FirstOrDefault();
            idTrec = tr_U.ID;
            NoLogout logout = new NoLogout(idTrec, Convert.ToDateTime(Getdt.ToShortDateString()), Getdt.TimeOfDay);
            logout.Show();
            this.Hide();

        }
     
        private void enableDisableButton_DoubleClick(object sender, EventArgs e)
        {

        }

        private void administratorGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = Convert.ToInt32(administratorGridView[0, e.RowIndex].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        int id, id_USER;
        string Fname;

        DateTime age;

        public void OfTable()
        {
            try
            {

                if (officeBox.Text == "")
                {
                    var vivodIn = from us in db.Users
                                  join rl in db.Roles on us.RoleID equals rl.ID
                                  join of in db.Offices on us.OfficeID equals of.ID
                                  select new
                                  {
                                      id = us.ID,
                                      FName = us.FirstName,
                                      LName = us.LastName,
                                      age = us.Birthdate,
                                      //age = DateTime.Now.Year-Convert.ToDateTime(us.Birthdate),
                                      //age = DateTime.Now.Year - Convert.ToInt32(us.Birthdate),
                                      UserRole = rl.Title,
                                      EmailAd = us.Email,
                                      OfficeName = of.Title,
                                      act = us.Active

                                  };
                    administratorGridView.DataSource = vivodIn.ToList(); /*db.Ingredients.ToList();*/
                    if (administratorGridView.Rows.Count > 0)
                    {
                        administratorGridView.Columns[0].Visible = false;
                        administratorGridView.Columns[1].HeaderText = "Name";
                        administratorGridView.Columns[2].HeaderText = "Last Name";
                        administratorGridView.Columns[3].HeaderText = "Age";
                        administratorGridView.Columns[4].HeaderText = "User role";
                        administratorGridView.Columns[5].HeaderText = "Email address";
                        administratorGridView.Columns[6].HeaderText = "Office";
                        administratorGridView.Columns[7].Visible = false;

                        id = Convert.ToInt32(administratorGridView[0, 0].Value);

                    }


                }
                else  if (officeBox.Text == "All offices")
                {
                    var vivodIn = from us in db.Users
                                  join rl in db.Roles on us.RoleID equals rl.ID
                                  join of in db.Offices on us.OfficeID equals of.ID
                                  select new
                                  {
                                      id=us.ID,
                                      FName = us.FirstName,
                                      LName = us.LastName,
                                      age= us.Birthdate,
                                      //age = DateTime.Now.Year-Convert.ToDateTime(us.Birthdate),
                                      //age = DateTime.Now.Year - Convert.ToInt32(us.Birthdate),
                                      UserRole = rl.Title,
                                      EmailAd = us.Email,
                                      OfficeName = of.Title, 
                                      act=us.Active

                                  };
                    administratorGridView.DataSource = vivodIn.ToList(); /*db.Ingredients.ToList();*/
                    if (administratorGridView.Rows.Count > 0)
                    {
                        administratorGridView.Columns[0].Visible = false;
                        administratorGridView.Columns[1].HeaderText = "Name";
                        administratorGridView.Columns[2].HeaderText = "Last Name";
                        administratorGridView.Columns[3].HeaderText = "Age";
                        administratorGridView.Columns[4].HeaderText = "User role";
                        administratorGridView.Columns[5].HeaderText = "Email address";
                        administratorGridView.Columns[6].HeaderText = "Office";
                        administratorGridView.Columns[7].Visible = false;


                        foreach (DataGridViewRow row in administratorGridView.Rows)
                        {
                            if (row.Cells[4].Value.ToString() == "Administrator")
                            {
                                row.DefaultCellStyle.BackColor = Color.LightGreen;
                            }
                            if (row.Cells[7].Value.ToString() == "False")
                            {
                                row.DefaultCellStyle.BackColor = Color.Red;
                            }
                        }
                        id = Convert.ToInt32(administratorGridView[0, 0].Value);

                    }


                }
                else
                {
                    var vivodIn = from us in db.Users
                                  join rl in db.Roles on us.RoleID equals rl.ID
                                  join of in db.Offices on us.OfficeID equals of.ID
                                  where of.Title == officeBox.Text
                                  select new
                                  {
                                      id = us.ID,
                                      FName = us.FirstName,
                                      LName = us.LastName,
                                      age = us.Birthdate,
                                      //age = DateTime.Now.Year - Convert.ToInt32(us.Birthdate),
                                      UserRole = rl.Title,
                                      EmailAd = us.Email,
                                      OfficeName = of.Title,
                                      act = us.Active
                                      
                                  };
                    administratorGridView.DataSource = vivodIn.ToList(); /*db.Ingredients.ToList();*/

                    if (administratorGridView.Rows.Count > 0)
                    {

                        administratorGridView.Columns[0].Visible = false;
                        administratorGridView.Columns[1].HeaderText = "Name";
                        administratorGridView.Columns[2].HeaderText = "Last Name";
                        administratorGridView.Columns[3].HeaderText = "Age";
                        administratorGridView.Columns[4].HeaderText = "User role";
                        administratorGridView.Columns[5].HeaderText = "Email address";
                        administratorGridView.Columns[6].HeaderText = "Office";
                        administratorGridView.Columns[7].Visible = false;


                        foreach (DataGridViewRow row in administratorGridView.Rows)
                        {
                            if (row.Cells[4].Value.ToString() == "Administrator")
                            {
                                row.DefaultCellStyle.BackColor = Color.LightGreen;
                            }
                            if (row.Cells[7].Value.ToString() == "False")
                            {
                                row.DefaultCellStyle.BackColor = Color.Red;
                            }
                        }
                        id = Convert.ToInt32(administratorGridView[0, 0].Value);
                    }
          
                }
            }
          
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void enableDisableButton_Click(object sender, EventArgs e)
        {

            Users userss = db.Users.Where(p => p.ID == id).FirstOrDefault();
            if (userss.Active == Convert.ToBoolean(1))
            {
                userss.Active = Convert.ToBoolean(0);
                foreach (DataGridViewRow row in administratorGridView.Rows)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
                
                MessageBox.Show("Вы заблокировали пользователя!");
            }
           else if (userss.Active == Convert.ToBoolean(0))
            {
                userss.Active = Convert.ToBoolean(1);
                foreach (DataGridViewRow row in administratorGridView.Rows)
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
                MessageBox.Show("Вы активировали пользователя!");

            }

            db.SaveChanges();
            OfTable();

        }
        private void guna2Separator3_Click(object sender, EventArgs e)
        {

        }
    }
}
