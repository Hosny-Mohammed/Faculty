using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Interaction logic for Admin_Page.xaml
    /// </summary>
    public partial class Admin_Page : Page
    {
        New_FcultyEntities DB = new New_FcultyEntities();
        public Admin_Page()
        {
            InitializeComponent();
            Data_Grid.ItemsSource = DB.Students.ToList();
        }

        private void Search_btn_Click(object sender, RoutedEventArgs e)
        {
            // Search In Name
            if(Combo.SelectedIndex == 0)
            {
                Data_Grid.ItemsSource = DB.Students.Where(x => x.Names.Contains(Search_txt.Text)).ToList();
            }
            else if(Combo.SelectedIndex == 1) // Search In Gender
            {
                Data_Grid.ItemsSource = DB.Students.Where(x => x.Genders.Contains(Search_txt.Text)).ToList();
            }else if(Combo.SelectedIndex == 2) // Search in Age
            {
                try
                {
                    int age = int.Parse(Search_txt.Text);
                    Data_Grid.ItemsSource = DB.Students.Where(x => x.Age == age).ToList();
                }
                catch
                {
                    MessageBox.Show("ENter A numeric value");
                }
            }else if (Combo.SelectedIndex == 3) //Search in Address
            {
                Data_Grid.ItemsSource = DB.Students.Where(x => x.Addresss.Contains(Search_txt.Text)).ToList();
            } else if (Combo.SelectedIndex == 4) //  Search in Departments
            {
                Data_Grid.ItemsSource = DB.Students.Where(x => x.Departments.Contains(Search_txt.Text)).ToList();
            }
            else
            {
                MessageBox.Show("U must Select Item in an combobox");
            }
        }

        private void Delete_btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int ID = int.Parse(ID_txt.Text);
                var RemoveUser = DB.Students.FirstOrDefault(y => y.ID == ID);
                if (RemoveUser != null) {
                    DB.Students.Remove(RemoveUser);
                    DB.SaveChanges();
                }
                else
                {
                    MessageBox.Show("THis User not found");
                }
                DB.SaveChanges();
                Data_Grid.ItemsSource = DB.Students.ToList();
            }
            catch
            {
                MessageBox.Show("ENter A numeric value");
            }
        }

        private void Update_btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int ID = int.Parse(ID_txt.Text);
                var UpdateUser = DB.Students.FirstOrDefault(x => x.ID == ID);
                if (UpdateUser != null)
                {
                    UpdateUser.Departments = Dep_txt.Text;
                    DB.Students.AddOrUpdate();
                    MessageBox.Show("Data is updated Successfully");
                }
                else
                {
                    MessageBox.Show("THis User not found");
                }
                Data_Grid.ItemsSource = DB.Students.ToList();
            }
            catch
            {
                MessageBox.Show("ENter A numeric value");
            }
            
        }

        private void Refresh_btn_Click(object sender, RoutedEventArgs e)
        {
            Data_Grid.ItemsSource = DB.Students.ToList();
        }
    }
}
