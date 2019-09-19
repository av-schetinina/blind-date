using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blind_dating.Web_forms
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void UserGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        public  bool IsValidEmail(string email)
        {
            string pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";
            Match isMatch = Regex.Match(email, pattern, RegexOptions.IgnoreCase);
            if (isMatch.Success!=true)
            {
                MessageBox.Show("E-mail is not correct");
                return false;
            }
            return true;

        }

        public bool IsNotNUll(TextBox txt) {
            if (txt.Text == "")
            {
                txt.Text = "Fill this field!!!";
                return false;
            }
            return true;
        }

        public bool notNullCmbbx(ComboBox lst)
        {
            if (lst.Text == "")
            {
                lst.Text = "Fill this field!!!";
                return false;
            }
            return true;
        }

        public bool IsValidAge(DateTimePicker dtp )
        {
                if((DateTime.Today.Year - dtp.Value.Year)<18)
                {
                
                    MessageBox.Show("Sorry, but you are too young. Try again later :)");
                return false;
                //MessageBox.Show((DateTime.Today.Year - dtp.Value.Year).ToString());
            };
            return true;
        }

        public bool IsValidNumber(MaskedTextBox mtb) {
            var txt = mtb.Text.Replace(" ", "");
            MessageBox.Show(txt.Length.ToString());
            if (txt.Length != 16)
            {
                MessageBox.Show("Number is not correct");
                return false;

            }
            //  MessageBox.Show(mtb.Text.Length.ToString() + '/');
            return true;

        }



        private void BtnRegister_Click(object sender, EventArgs e)
        {   if (IsValidEmail(userEmail.Text) == true &&
            IsNotNUll(userName) == true &&
            IsNotNUll(userSurname) == true &&
            IsNotNUll(userEmail) == true &&
            IsNotNUll(userPassword) == true &&
            IsValidAge(userDateofBirth) == true &&
            notNullCmbbx(userGender) == true &&
            /*notNullCmbbx(userCity) == true &&*/
            IsValidNumber(userTelephone) == true &&
            IsNotNUll(userInfo) == true ) {

                Test inout = new Test();
                inout.Show();
                this.Hide();

            }




        }
    }
}
