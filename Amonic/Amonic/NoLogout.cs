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
    public partial class NoLogout : Form
    {
        Session1_XXEntities db = new Session1_XXEntities();
        DateTime dateUserLogout;
        TimeSpan timeUserLogout;
        int idTrec;
        public NoLogout(int id, DateTime enterDate, TimeSpan enterTime)
        {
            InitializeComponent();
            idTrec = id;
            dateUserLogout = enterDate;
            timeUserLogout = enterTime;
        }
        DateTime Getdt = DateTime.Now;
        private void confirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (softwareRadioButton.Checked)
                {
                    trecking tr = db.trecking.Where(p => p.ID == idTrec).FirstOrDefault();
                    tr.Crash_report = Convert.ToString(reasonBox.Text);
                    tr.Crash_type = "Software crash";
                    tr.Logout_date = Convert.ToDateTime(Getdt.ToShortDateString());
                    tr.Logout_time = Getdt.TimeOfDay;
                    db.SaveChanges();
                }
                else if (systemRadioButton.Checked)
                {
                    trecking tr = db.trecking.Where(p => p.ID == idTrec).FirstOrDefault();
                    tr.Crash_report = reasonBox.Text;
                    tr.Crash_type = "System crash";
                    tr.Logout_date = Convert.ToDateTime(Getdt.ToShortDateString());
                    tr.Logout_time = Getdt.TimeOfDay;
                    db.SaveChanges();
                }
                else if (softwareRadioButton.Checked == false && systemRadioButton.Checked == false)
                {
                    DialogResult dialog = MessageBox.Show("Выберите один из вариантов! ",
                            "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void NoLogout_Load(object sender, EventArgs e)
        {
            noLogoutLabel.Text = "No logout detected for your last login on " + dateUserLogout.ToShortDateString() + " at " + timeUserLogout;
        }

        private void Excitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
