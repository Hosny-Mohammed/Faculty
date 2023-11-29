using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for ForgetPage.xaml
    /// </summary>
    public partial class ForgetPage : Page
    {
        New_FcultyEntities DB = new New_FcultyEntities();
        public ForgetPage()
        {
            InitializeComponent();
        }

        private void Forget_btn_Click(object sender, object e)
        {
            if(Combo.SelectedItem != null)
            {
                if(Combo.SelectedIndex == 0)
                {
                    var user = DB.Admins.FirstOrDefault(x => x.Usernames == UserName_txt.Text);
                    if(user != null)
                    {
                        if (Password_txt.Text.Length > 16 && Regex.IsMatch(Password_txt.Text, @"[!@#$%^&*()_+=\[{\]};:<>|./?,-]"))
                        {
                            user.Passwords = Password_txt.Text;
                            DB.Admins.AddOrUpdate(user);
                            DB.SaveChanges();
                            MessageBox.Show("password is updated successfully");
                        }
                        else
                        {
                            MessageBox.Show("The password don't strong enough");
                        }
                    }
                    else
                    {
                        MessageBox.Show("This user not found");
                    }
                    
                } else if(Combo.SelectedIndex == 1)
                {
                    var user = DB.User_LogIn.FirstOrDefault(x => x.Usernames == UserName_txt.Text);
                    if (user != null)
                    {
                        if (Password_txt.Text.Length > 16 && Regex.IsMatch(Password_txt.Text, @"[!@#$%^&*()_+=\[{\]};:<>|./?,-]"))
                        {
                            user.Passwords = Password_txt.Text;
                            DB.User_LogIn.AddOrUpdate(user);
                            DB.SaveChanges();
                            MessageBox.Show("password is updated successfully");
                        }
                        else
                        {
                            MessageBox.Show("The password don't strong enough");
                        }
                    }
                    else
                    {
                        MessageBox.Show("This user not found");
                    }
                }
                else
                {
                    MessageBox.Show("U must select an item");
                }

            }
        }
    }
}
