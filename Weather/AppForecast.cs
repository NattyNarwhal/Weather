using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Weather
{
    // TERRIBLE UGLY HACK for WPF
    public class AppForecast : INotifyPropertyChanged
    {
        private WeatherData _weatherData;
        public WeatherData WeatherData
        {
            get { return _weatherData; }
            set
            {
                _weatherData = value;
                OnPropertyChanged();
            }
        }

        protected void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
