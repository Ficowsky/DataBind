using DataBuild.Data;
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

namespace DataBuild
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Person> People = new List<Person>
     {
            new Person { Name = "John", Age = 42 },
            new Person { Name = "Jane", Age = 39 },
            new Person { Name = "Sam", Age = 13 },
            new Person { Name = "Lucy", Age = 22 },
            new Person { Name = "Tom", Age = 33 }
        };
        public MainWindow()
        {
            InitializeComponent();
            ListBoxPeople.ItemsSource = People;

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
           var selectedItems = ListBoxPeople.SelectedItems;

            foreach (var item in selectedItems)
            {
                var person = (Person)item;
                MessageBox.Show(person.Name);
            }
        }
    }
}
