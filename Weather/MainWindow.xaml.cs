using System;
using System.Collections.Generic;
using System.IO;
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
using System.Xml.Serialization;

namespace Weather
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public AppForecast data;

        const string example = "Y:\\norway.xml";
        XmlSerializer xs = new XmlSerializer(typeof(WeatherData));

        public MainWindow()
        {
            InitializeComponent();
            data = new AppForecast();

            Refresh();

            DataContext = data.WeatherData;
        }

        public void Refresh()
        {
            using (FileStream fs = File.OpenRead(example))
            {
                data.WeatherData = (WeatherData)xs.Deserialize(fs);
            }
        }

        private void refreshButton_Click(object sender, RoutedEventArgs e)
        {
            Refresh();
        }
    }
}
