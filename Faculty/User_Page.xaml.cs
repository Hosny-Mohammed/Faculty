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
    /// Interaction logic for User_Page.xaml
    /// </summary>
    public partial class User_Page : Page
    {
        New_FcultyEntities DB = new New_FcultyEntities();
        public User_Page()
        {
            InitializeComponent();
        }
        public String Split_Comb(String input)
        {
           // Combo.SelectedIndex
            if (input != null)
            {
                input = input.Split(' ').Last();
            }
            return input;
        }

        private void Add_btn_Click(object sender, RoutedEventArgs e)
        {
            Student table = new Student();
            table.Names = Name_txt.Text;
            
                if (Male_Box.IsChecked == true && Female_Box.IsChecked == false)
                {
                    table.Genders = "Male";
                }
                else if (Female_Box.IsChecked == true && Male_Box.IsChecked == false)
                {
                    table.Genders = "Female";
                }
                else
                {
                    table.Genders = null;
                    MessageBox.Show("You must check exactly one checkbox.");
                }
            table.Addresss = Address_txt.Text;
            try
            {
                int Age = int.Parse(Age_txt.Text);
                table.Age = Age;
            }
            catch {
                MessageBox.Show("U must Enter a Numeric value");
            }
            if(Combo.SelectedItem != null)
            {
                table.Departments = Split_Comb(Combo.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("U must select an item");
            }
            
            DB.Students.Add(table);
            DB.SaveChanges();
            MessageBox.Show("Z info is added successfully");
            this.NavigationService.GoBack();
            }
    }
}
