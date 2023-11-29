using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Faculty
{
    /// <summary>
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Page
    {
        New_FcultyEntities DB = new New_FcultyEntities();
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUP_btn_Click(object sender, object e)
        {
            User_LogIn user_table = new User_LogIn();
            Admin admin_table = new Admin();
            if(Combo.SelectedIndex ==0)
            {
                if(UserName_txt.Text != "" || Password_txt.Text != "")
                {
                    admin_table.Usernames = UserName_txt.Text;
                    admin_table.Passwords = Password_txt.Text;
                    DB.Admins.Add(admin_table);
                    DB.SaveChanges();
                    MessageBox.Show("The user is created successfully");
                }
                else
                {
                    MessageBox.Show("U must enter data");
                }
            } else if(Combo.SelectedIndex ==1)
            {
                if (UserName_txt.Text != "" || Password_txt.Text != "")
                {
                    user_table.Usernames = UserName_txt.Text;
                    user_table.Passwords = Password_txt.Text;
                    DB.User_LogIn.Add(user_table);
                    DB.SaveChanges();
                    MessageBox.Show("The user is created successfully");
                }
                else
                {
                    MessageBox.Show("U must enter data");
                }
            }
        }
    }
}
