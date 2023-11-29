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
    /// Interaction logic for LogIn.xaml
    /// </summary>
    public partial class LogIn : Page
    {
        New_FcultyEntities DB = new New_FcultyEntities();
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_btn_Click(object sender, RoutedEventArgs e)
        {
            if (Combo.SelectedIndex == 0)
            {
                var user = DB.Admins.FirstOrDefault(x => x.Usernames == UserName_txt.Text);
                if (user != null && user.Passwords == Password_txt.Text)
                {
                    // Don't forget The navigation
                    MessageBox.Show("LogIn is successfully");
                    Admin_Page admin = new Admin_Page();
                    this.NavigationService.Navigate(admin);
                }
                else
                {
                    MessageBox.Show("This User or password is incorrect");
                }
            } 
            else if(Combo.SelectedIndex == 1)
            {
                var user = DB.User_LogIn.FirstOrDefault(x => x.Usernames == UserName_txt.Text);
                if (user != null && user.Passwords == Password_txt.Text)
                {
                    // Don't forget The navigation
                    MessageBox.Show("LogIn is successfully");
                    User_Page nn = new User_Page();
                    this.NavigationService.Navigate(nn);
                }
                else
                {
                    MessageBox.Show("This User or password is incorrect");
                }
            }
            else
            {
                MessageBox.Show("U must select Kinda users");
            }
        }

        private void Forget_btn_Click(object sender, RoutedEventArgs e)
        {
            ForgetPage page = new ForgetPage();
            this.NavigationService.Navigate(page);
        }

        private void SinUp_btn_Click(object sender, RoutedEventArgs e)
        {
            SignUp page = new SignUp();
            this.NavigationService.Navigate(page);
        }
    }
}
