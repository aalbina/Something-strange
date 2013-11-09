using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;

namespace name_of_your_app
{

    public sealed partial class MainPage : Page
    {
	
        public async Task<string> Test()
        {
            var client = new HttpClient();
            var uri = new Uri("your_url");
            var page = await client.GetStringAsync(uri);

            return page;
        }

        public async void Print()
        {
            try
            {
                // we have internet and answer from server
		string x = await Test();
		// use x as you need
            }
            catch (HttpRequestException е)
            {
                // no internet
            }
            
        }
		
        public MainPage()
        {
            this.InitializeComponent();
            Print();
        }
  
    }
}
