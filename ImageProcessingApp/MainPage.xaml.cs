using Lumia.Imaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.Storage.Streams;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ImageProcessingApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public static RootObject imgData;
        public MainPage()
        {
            this.InitializeComponent();
        }
        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
            Row1Grid.ColumnDefinitions[0].MaxWidth = MySplitView.IsPaneOpen ? 150 : 50;
        }
        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            SearchParameters parameters = e.Parameter is SearchParameters ? (SearchParameters)e.Parameter : new SearchParameters();
            imgData = await ImageDataImport.GetSearchImageData(parameters.SearchQuery, parameters.PageNumber);
            FillImageGrid(imgData);
        }
        private void MainSearchBox_QuerySubmitted(SearchBox sender, SearchBoxQuerySubmittedEventArgs args)
        {
            var parameters = args.QueryText == "" ? new SearchParameters() : new SearchParameters(1, args.QueryText);
            Frame.Navigate(typeof(SearchResultPage), parameters);
        }
        private void MenuButton1_Click(object sender, RoutedEventArgs e)
        {
            var parameters = new SearchParameters(1, "Dogs");
            Frame.Navigate(typeof(SearchResultPage), parameters);
        }

        private void MenuButton2_Click(object sender, RoutedEventArgs e)
        {
            var parameters = new SearchParameters(1, "Cats");
            Frame.Navigate(typeof(SearchResultPage), parameters);
        }

        private void MenuButton3_Click(object sender, RoutedEventArgs e)
        {
            var parameters = new SearchParameters(1, "Cars");
            Frame.Navigate(typeof(SearchResultPage), parameters);
        }
        private void FillImageGrid(RootObject imgData) //gross, i know
        {
            SearchedImage1.DataContext = (new BitmapImage(new Uri(imgData.results[0].links.download, UriKind.Absolute)));
            SearchedImage2.DataContext = (new BitmapImage(new Uri(imgData.results[1].links.download, UriKind.Absolute)));
            SearchedImage3.DataContext = (new BitmapImage(new Uri(imgData.results[2].links.download, UriKind.Absolute)));
            SearchedImage4.DataContext = (new BitmapImage(new Uri(imgData.results[3].links.download, UriKind.Absolute)));
            SearchedImage5.DataContext = (new BitmapImage(new Uri(imgData.results[4].links.download, UriKind.Absolute)));
            SearchedImage6.DataContext = (new BitmapImage(new Uri(imgData.results[5].links.download, UriKind.Absolute)));
            SearchedImage7.DataContext = (new BitmapImage(new Uri(imgData.results[6].links.download, UriKind.Absolute)));
            SearchedImage8.DataContext = (new BitmapImage(new Uri(imgData.results[7].links.download, UriKind.Absolute)));
            SearchedImage9.DataContext = (new BitmapImage(new Uri(imgData.results[8].links.download, UriKind.Absolute)));
        }
        private void PickImage_Click(object sender, RoutedEventArgs e)
        {
            // BitmapProviderImageSource a = new BitmapProviderImageSource(new BitmapImage());
            //var file = new StorageFile(new BitmapImage(new Uri("", UriKind.Absolute)));
            //IRandomAccessStream fileStream = await file.OpenAsync(FileAccessMode.Read);
        }
    }
}
