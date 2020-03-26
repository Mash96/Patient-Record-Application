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
using Microsoft.Win32;

namespace Patient_Record_Application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {
        Person person = new Person();
        public MainWindow()
            
        {
            InitializeComponent();
            // this is important for databinding
            this.DataContext = person;

            // displaying the current date
            String date_time_value = CurrentDate();
            date_time.Content = date_time_value;

        }

        // Showing Current Date
        public string CurrentDate()
        {
            String date;
            String time;
            String Date_Time;

            DateTime dateTime = DateTime.Now;
            date = dateTime.ToString("d");
            time = dateTime.ToString("T");
            Date_Time = date + " " + time;
            return Date_Time;

        } 

        // Print Preview Button
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // showing the new window
            Preview preview = new Preview();

            preview.ViewName.Text = person.Name;
            preview.ViewAddress.Text = person.Address;

            // #issue 
            if (Male.IsChecked == true)
            {
                preview.ViewGender.Text = Male.Content.ToString();
            }
            else if (Female.IsChecked == true)
            {
                preview.ViewGender.Text = Female.Content.ToString();
            }
                

            //preview.ViewDob.Text = Date.SelectedDate.Value.Date.ToShortDateString();
            // #issue
            preview.ViewDob.Text = person.Dob;     
            
            preview.ViewAge.Text =  person.Age.ToString();
            preview.ViewDepartment.Text = person.Dept;
            preview.ViewWard.Text = person.Ward;
            preview.ViewDoc.Text = person.DocInCharge;
            // preview.ImageViewer2.Source = ImageViewer.Source;

            preview.Show();

        }

        // Viewing Image Button
        private void Open_File(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = @"C:\Users\Maneesha\Desktop\Dips Y-knots\images\";
            dlg.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" +
                            "All files (*.*)|*.*";
            if (dlg.ShowDialog() == true)
            {
                String fileName = dlg.FileName;
                FileBrowser.Text = fileName;
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(fileName);
                bitmap.EndInit();
                ImageViewer.Source = bitmap;
            }

        }

        // Clear the data Button
        private void Button_Clear(Object sender, RoutedEventArgs e)
        {
            fName.Clear();
            Address.Clear();

            if (Male.IsChecked == true)
            {
                Male.IsChecked = false;
            }
            else Female.IsChecked = false;

            Date.Text = String.Empty;
            Age.Clear();
            FileBrowser.Clear();
            ImageViewer.Source = null;
            Department.Text = String.Empty;
            Ward.Text = String.Empty;
            Doctor.Text = String.Empty;

        }
    }
}
