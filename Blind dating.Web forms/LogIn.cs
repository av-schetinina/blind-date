using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blind_dating.Web_forms
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            userPassword.PasswordChar = '*';
        }

        private void BtnGotoRegister_Click(object sender, EventArgs e)
        {
            Registration inout = new Registration();
            inout.Show();
            this.Close();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
          
            if (userEmail.Text == "anastasiia.shchetinina@nure.ua" && userPassword.Text == "12345") {
                Admin inout = new Admin();
                inout.Show();
                this.Close();
            }
        }
    }
}
