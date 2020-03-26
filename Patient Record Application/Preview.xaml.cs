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
using System.Windows.Shapes;

namespace Patient_Record_Application
{
    /// <summary>
    /// Interaction logic for Preview.xaml
    /// </summary>
    public partial class Preview : Window
    {
        public Preview()
        {
            
            MainWindow mainWindow = new MainWindow();
            InitializeComponent();

            String dateTime = mainWindow.CurrentDate();
            date_time.Content = dateTime;
        }



        private void Button_Print(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
