using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepairShop_Soft
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }

        private void main_form_Load(object sender, EventArgs e)
        {
            
            //d
            
            this.RightToLeft = RightToLeft.Yes;
           // GPclass.userbar = "ناشناخته";
           // RTB_notes.Text = "";
            RTB_notes.Text = Properties.Settings.Default.Note ;


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void RTC_Tick(object sender, EventArgs e)
        {
            this.Text = "مدیریت تعمیرگاه       کاربر     :" + GPclass.userbar;
            lbl_userNOT.Text = GPclass.userbar;
            lbl_date.Text = GPclass.getDate();
            lbl_hour.Text = GPclass.getHour();
            switch( GPclass.calendar.GetDayOfWeek(DateTime.Now).ToString())
            {
                case "Monday":      lbl_day.Text = "دوشنبه";     break;
                case "Tuesday":     lbl_day.Text = "دوشنبه";     break;
                case "Wednesday":   lbl_day.Text = "دوشنبه";     break;
                case "Thursday":    lbl_day.Text = "دوشنبه";     break;
                case "Friday":      lbl_day.Text = "دوشنبه";     break;
                case "Saturday":    lbl_day.Text = "دوشنبه";     break;
                case "Sunday":      lbl_day.Text = "دوشنبه";     break;
                default:            lbl_day.Text = "";            break;
            }
            
        }

        private void RTB_notes_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Note = RTB_notes.Text;
            Properties.Settings.Default.Save();
        }

        private void RTB_notes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) 
            {
                RTB_notes.Text += "\n-";
                RTB_notes.SelectionStart = RTB_notes.Text.Length;
                RTB_notes.Focus();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show ("آیا میخواهید از نرم افزار خارج شوید؟","خروج", MessageBoxButtons.YesNo ,MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_hour_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_userNOT_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lbl_date_Click(object sender, EventArgs e)
        {

        }

        private void lbl_day_Click(object sender, EventArgs e)
        {

        }

        private void btn_about_Click(object sender, EventArgs e)
        {

        }

        private void btn_about_Click_1(object sender, EventArgs e)
        {
            about aboutbox = new
                 about();
            aboutbox.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
