using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Whatsapp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MessegesendBTN_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    if (!ToNumber.Text.Equals("") && !MessegeContect.Equals(""))
                    {
                        string number = ToNumber.Text.Length >= 0 ? "+91" + ToNumber.Text : "Enter the number";
                        number = number.Replace(" ", "");
                        string messageContent = new TextRange(MessegeContect.Document.ContentStart, MessegeContect.Document.ContentEnd).Text;

                        // Use ProcessStartInfo to set the FileName to the URL
                        ProcessStartInfo psi = new ProcessStartInfo
                        {
                            FileName = "http://api.whatsapp.com/send?phone=" + number + "&text=" + messageContent+" "+i,
                            UseShellExecute = true
                        };

                        // Start the process
                        System.Diagnostics.Process.Start(psi);
                    }
                    else
                    {
                        MessageBox.Show("Enter the number");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}