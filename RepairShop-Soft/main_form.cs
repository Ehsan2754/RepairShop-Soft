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
            GPclass.userbar = "ناشناخته";
            this.RightToLeft = RightToLeft.Yes;
            this.Text = "مدیریت تعمیرگاه       کاربر     :" + GPclass.userbar;
            lbl_userNOT.Text = GPclass.userbar;
            lbl_date.Text = GPclass.getDate();
            lbl_hour.Text = DateTime.Now.ToShortTimeString();
            lbl_day.Text = GPclass.calendar.GetDayOfWeek(DateTime.Now).ToString();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }
    }
}
