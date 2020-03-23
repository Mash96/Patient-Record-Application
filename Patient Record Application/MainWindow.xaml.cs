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

namespace Patient_Record_Application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {

        public MainWindow()
            
        {
            String date;
            String time;
            String Date_Time;
            InitializeComponent();
            DataContext = this;

            // displaying the current date
          
            DateTime dateTime = DateTime.Now;
            date = dateTime.ToString("d");
            time = dateTime.ToString("T");
            Date_Time = date + " " + time;

            date_time.Text = Date_Time;

            // displaying age
            String var;
            var = fName.Text;
            Console.WriteLine(var);
            Console.WriteLine(Date_Time);

        }
        // saving inputs
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String name = fName.Text;

            String address = Address.Text;

            String gender;
            if (Male.IsChecked == true)
            {
                gender = Male.Content.ToString();
            }
            else gender = Female.Content.ToString();

            String birthDate = Date.SelectedDate.Value.Date.ToShortDateString();

            MessageBox.Show(name + " " + address +  " " + gender+ " " + birthDate);
        }
    }
}
