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
    public partial class MineUser : Form
    {
        string emailUser;
        int enterId;
        int timeLogin = 0, countCrash = 0;

        Session1_XXEntities db = new Session1_XXEntities();
        public MineUser(string email)
        {
            InitializeComponent();
            spentTimeTimer.Start();
            emailUser = email;
            var wel = db.Users.Where(s => s.Email == emailUser).FirstOrDefault();
            WelcomeLabel.Text = "Hi " + wel.LastName + " " + wel.FirstName + ", Welcome to AMONIC Airlines";
        }

        DateTime Getdt = DateTime.Now;

        private void ExcitLbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MineUser_FormClosing(object sender, FormClosingEventArgs e)
        {

            //trecking trec = db.trecking.Where(p => p.Email == emailUser && p.ID == enterId).FirstOrDefault();
            //trec.Logout_date = Convert.ToDateTime(Getdt.ToShortDateString());
            //trec.Logout_time = Getdt.TimeOfDay;
            //db.SaveChanges();

        }

        public void countUs()
        {
            int count= db.trecking.Count(p => p.Email == emailUser);
        }

        public void SelectUser()
        {
            try
            {
                int count = db.trecking.Count(p => p.Email == emailUser);

                TrecingGridView.DataSource = db.trecking.Where(s => s.Email == emailUser).ToList();
                if (TrecingGridView.Rows.Count > 0)
                {
                    TrecingGridView.Columns[0].Visible = false;
                    TrecingGridView.Columns[1].Visible = false;
                    TrecingGridView.Columns[2].HeaderText = "Date";
                    TrecingGridView.Columns[3].HeaderText = "Login time";
                    TrecingGridView.Columns[4].Visible = false;
                    TrecingGridView.Columns[5].HeaderText = "Logout time";
                    TrecingGridView.Columns[6].HeaderText = "Unsuccessful logout reason";
                    TrecingGridView.Columns[7].Visible = false;
                    TrecingGridView.Columns[8].Visible = false;
                    TrecingGridView.Columns[9].Visible = false;
                    //int i = 1;

                //    foreach (DataGridViewRow row in TrecingGridView.Rows)
                //        //{
                //        if (row.Cells[6].Value.ToString() == string.Empty)
                //        {
                //            //        row.DefaultCellStyle.BackColor = Color.Red;
                //            //    }

                //        }
                //else
                //    {
                //        countCrash += 1;
                //        i += 1;
                //    }
                //    CrashesLbl.Text = "Number of crashes: " + countCrash.ToString();

                    //foreach (DataGridViewRow row in TrecingGridView.Rows)
                    //{
                    //    if (row.Cells[6].Value.ToString() == string.Empty)
                    //    {
                    //        row.DefaultCellStyle.BackColor = Color.Red;
                    //    }

                    //}
                }
                //if (i == count)
                //{
                //    enterId = Convert.ToInt32(TrecingGridView[0, 0].Value);
                //}
                //if (TrecingGridView[0, 6].ToString() == "")
                //{
                    //string enterDate = TrecingGridView[0, 2].ToString();
                    //string[] enterDateSplit = enterDate.Split(' ');
                    //string enterTime = TrecingGridView[0, 3].ToString();
                    //string[] enterTimeSplit = enterTime.Split(':');
                    //int hourEnter = Convert.ToInt32(enterTimeSplit[0]) * 3600;
                    //int minuteEnter = Convert.ToInt32(enterTimeSplit[1]) * 60;
                    //int secondsEnter = Convert.ToInt32(enterTimeSplit[2]);
                    //int timeEnter = hourEnter + minuteEnter + secondsEnter;
                    //string logoutDate = TrecingGridView[0, 5].ToString();
                    //string[] logoutDateSplit = logoutDate.Split(':');
                    //int hourLogout = Convert.ToInt32(logoutDateSplit[0]) * 3600;
                    //int minuteLogout = Convert.ToInt32(logoutDateSplit[1]) * 60;
                    //int secondsLogout = Convert.ToInt32(logoutDateSplit[2]);
                    //int timeLogout = hourLogout + minuteLogout + secondsLogout;
                    //int spentTime = timeLogout - timeEnter;
                    //int spentTimeHour = spentTime / 3600;
                    //int spentTimeMinute = spentTime / 60;
                    //int spentTimeSeconds = spentTime % 60;
                    //string timeSpentTime;
                    //if (spentTimeHour < 10)
                    //{
                    //    if (spentTimeMinute < 10)
                    //    {
                    //        if (spentTimeSeconds < 10)
                    //        {
                    //            timeSpentTime = "0" + spentTimeHour.ToString() + ":0" +
                    //                spentTimeMinute.ToString() + ":0" + spentTimeSeconds.ToString();
                    //        }
                    //        else
                    //        {
                    //            timeSpentTime = "0" + spentTimeHour.ToString() + ":0" +
                    //                spentTimeMinute.ToString() + ":" + spentTimeSeconds.ToString();
                    //        }
                    //    }
                    //    else
                    //    {
                    //        if (spentTimeSeconds < 10)
                    //        {
                    //            timeSpentTime = "0" + spentTimeHour.ToString() + ":" +
                    //                spentTimeMinute.ToString() + ":0" + spentTimeSeconds.ToString();
                    //        }
                    //        else
                    //        {
                    //            timeSpentTime = "0" + spentTimeHour.ToString() + ":" +
                    //                spentTimeMinute.ToString() + ":" + spentTimeSeconds.ToString();
                    //        }
                    //    }
                    //}
                    //else
                    //{
                    //    if (spentTimeMinute < 10)
                    //    {
                    //        if (spentTimeSeconds < 10)
                    //        {
                    //            timeSpentTime = spentTimeHour.ToString() + ":0" +
                    //                spentTimeMinute.ToString() + ":0" + spentTimeSeconds.ToString();
                    //        }
                    //        else
                    //        {
                    //            timeSpentTime = spentTimeHour.ToString() + ":0" +
                    //                spentTimeMinute.ToString() + ":" + spentTimeSeconds.ToString();
                    //        }
                    //    }
                    //    else
                    //    {
                    //        if (spentTimeSeconds < 10)
                    //        {
                    //            timeSpentTime = spentTimeHour.ToString() + ":" +
                    //                spentTimeMinute.ToString() + ":0" + spentTimeSeconds.ToString();
                    //        }
                    //        else
                    //        {
                    //            timeSpentTime = spentTimeHour.ToString() + ":" +
                    //                spentTimeMinute.ToString() + ":" + spentTimeSeconds.ToString();
                    //        }
                    //    }
                    //}

                    //i += 1;
                //}
                //else
                //{

                //    countCrash += 1;
                //    i += 1;
                //}

            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



            private void spentTimeTimer_Tick(object sender, EventArgs e)
        {
            timeLogin += 1;
            int hour = timeLogin / 3600;
            int minute = timeLogin / 60;
            int second = timeLogin % 60;
            DateTime date = new DateTime(2021, 01, 01, hour, minute, second);
            if (hour == 0)
            {
                timerLabel.Text = "0" + date.ToLongTimeString();
            }
        }
        int idTrec, idInform;
        private void ExitButton_Click(object sender, EventArgs e)
        {
            trecking tr_U = db.trecking.Where(p => p.Email == emailUser).FirstOrDefault();
            idTrec = tr_U.ID;
            NoLogout logout = new NoLogout(idTrec, Convert.ToDateTime(Getdt.ToShortDateString()), Getdt.TimeOfDay);
            logout.Show();
            this.Hide();
        }

        private void MineUser_Load(object sender, EventArgs e)
        {
            SelectUser();
        }
    }
}
