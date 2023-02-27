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
    public partial class Login : Form
    {
        Session1_XXEntities db = new Session1_XXEntities();
        string email, enterDate;
          TimeSpan  enterTime;
        int id, idUser;
        bool pass = false;
        int count_try = 0;
        int timer = 10;


        public Login()
        {
            InitializeComponent();
        }

            DateTime Getdt = DateTime.Now;

        trecking treck;
        public void admin()
        {


            //if (treck.Logout_date.ToString() == "")
            //{
            //    id = treck.ID;
            //    enterDate = treck.Enter_date.ToString();
            //    enterTime = treck.Enter_time.ToString();
            //    NoLogout logout = new NoLogout(id, enterDate, enterTime);
            //    logout.ShowDialog();
            //}

            treck = new trecking
            {
                Id_user = idUser,
                Email = email,
                Enter_date = Convert.ToDateTime(Getdt.ToShortDateString()),
                Enter_time = Getdt.TimeOfDay
            };
            db.trecking.Add(treck);
            db.SaveChanges();
            id = treck.ID;
            //NoLogout logout = new NoLogout(id, Convert.ToDateTime(Getdt.ToShortDateString()), Getdt.TimeOfDay);
            //logout.Show();

            MineAdmin mine = new MineAdmin(email);
            mine.Show();

        }


        public void user_Amon()
        {

            //if (treck.Logout_date.ToString() == "")
            //{
            //    id = treck.ID;
            //    enterDate = treck.Enter_date.ToString();
            //    enterTime = treck.Enter_time.ToString();
            //    NoLogout logout = new NoLogout(id, enterDate, enterTime);
            //    logout.ShowDialog();
            //}

            treck = new trecking
            {
            Id_user = idUser,
            Email = email,
            Enter_date = Convert.ToDateTime(Getdt.ToShortDateString()),
            Enter_time = Getdt.TimeOfDay
        };
            db.trecking.Add(treck);
            db.SaveChanges();
            id = treck.ID;
            //NoLogout logout = new NoLogout(id, Convert.ToDateTime(Getdt.ToShortDateString()), Getdt.TimeOfDay);
            //logout.Show();
            MineUser mineUser = new MineUser(email);
            mineUser.Show();

        }

        private void IncorrectEnterTimer_Tick(object sender, EventArgs e)
        {
            timer -= 1;
            timerLabel.Text = timer + " сек.";
            if (timer == 0)
            {
                timerLabel.Visible = false;
                banLabel.Visible = false;
                LoginButton.Enabled = true;
                count_try = 0;
                IncorrectEnterTimer.Stop();
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (NameTxtBox.Text == "" && PasswordTxtBox.Text == "")
            {
                DialogResult dialog = MessageBox.Show("Введите данные!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                var inf = (from us in db.Users
                           where us.Email == NameTxtBox.Text && us.Password == PasswordTxtBox.Text
                           select us).ToList();
                foreach (var user in inf)
                {
                    if (user.RoleID.ToString() == "1" && user.Active.ToString() != "False")
                    {
                        email = user.Email.ToString();
                        idUser = user.ID;
                        pass = true;
                        admin();
                        this.Hide();
                    }

                    else if (user.RoleID.ToString() == "2" && user.Active.ToString() != "False")
                    {
                        email = user.Email.ToString();
                        idUser = user.ID;
                        pass = true;
                        user_Amon();
                        this.Hide();
                    }
                }
                if (pass == false)
                {
                    banLabel.Visible = true;
                    count_try += 1;
                    if (count_try > 3)
                    {
                        timer = 10;
                        timerLabel.Text = timer + " сек.";
                        timerLabel.Visible = true;
                        LoginButton.Enabled = false;
                        IncorrectEnterTimer.Enabled = true;
                        IncorrectEnterTimer.Start();


                        DialogResult dialog = MessageBox.Show("Вы заблокированы!" +
                            " По всем вопросам обращайтесь к администратору!",
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }  
      
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
