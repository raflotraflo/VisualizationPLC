using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Net;
using Newtonsoft.Json;

namespace VisualizationPLC.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        /// 

        
        public MainViewModel()
        {
            GetStringCommand = new RelayCommand(() => GetString());

        }

        void GetString()
        {
            JsonString = "Test";
            string addres = @"http://praca-przejsciowa.rhcloud.com/";

            // pobieranie z strony
            WebClient webClient = new WebClient();

            webClient.BaseAddress = addres; // adres strony

            JsonString = webClient.DownloadString(addres);

            //JsonString = JsonString.Replace(",", ".");

            PlcDataModel data = JsonConvert.DeserializeObject<PlcDataModel>(JsonString);
            //JsonConvert.

            //Newtonsoft.Json.JsonConvert a = new Newtonsoft.Json.JsonConvert();

            //var a = a.

        }

        private string _jsonString;
        public string JsonString
        {
            get
            {
                return _jsonString;
            }

            set
            {
                if (_jsonString != value)
                {
                    _jsonString = value;
                    RaisePropertyChanged(() => JsonString);
                }
            }
        }

        public RelayCommand GetStringCommand { get; private set; }
    }
}