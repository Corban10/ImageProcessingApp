using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ImageProcessingApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ImageEditingPage : Page
    {
        public ImageEditingPage()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            CurrentImage.DataContext = e.Parameter; //new BitmapImage(new Uri(imgData.results[0].links.download, UriKind.Absolute));
            //SearchParameters parameters = (SearchResultPage)e.Parameter; //this didnt work?
            //SearchParameters parameters = e.Parameter is SearchParameters ? (SearchParameters)e.Parameter : new SearchParameters();
            //RootObject imgData = await ImageDataImport.GetImageData(parameters.SearchQuery, parameters.PageNumber);
            //FillImageGrid(imgData);
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void ColourEffectButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
