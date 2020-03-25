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
            String date;
            String time;
            String Date_Time;

            InitializeComponent();
            // DataContext = this;

            // displaying the current date
          
            DateTime dateTime = DateTime.Now;
            date = dateTime.ToString("d");
            time = dateTime.ToString("T");
            Date_Time = date + " " + time;

            date_time.Content = Date_Time;

            person.Name = fName.Text;



        }
        // saving inputs
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            // showing the new window

            Preview preview = new Preview();

            preview.ViewName.Text = fName.Text;

            preview.ViewAddress.Text = Address.Text;

            if (Male.IsChecked == true)
            {
                preview.ViewGender.Text = Male.Content.ToString();
            }
            else preview.ViewGender.Text = Female.Content.ToString();

            preview.ViewDob.Text = Date.SelectedDate.Value.Date.ToShortDateString();

            preview.ViewAge.Text = Age.Text;

            preview.ViewDepartment.Text = Department.Text;

            preview.ViewWard.Text = Ward.Text;

            preview.ViewDoc.Text = Doctor.Text;

            preview.Show();

        }

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

        private void Button_Clear(Object sender, RoutedEventArgs e)
        {
            fName.Text = "";

            Address.Text = "";

            if (Male.IsChecked == true)
            {
                Male.IsChecked = false;
            }
            else Female.IsChecked = false;

            Date.Text = "";

            Age.Text = "";

            FileBrowser.Text = "";

            ImageViewer.Source = null;

        }

        // using a function to clear text

        //public void ClearBoxes()
        //{
        //    foreach (Control clearText in this.Controls)
        //    {
        //        if (clearText is TextBox)
        //        {
        //            ((TextBox)clearText).Text = string.Empty;
        //        }
        //    }
        //}
    }
}
