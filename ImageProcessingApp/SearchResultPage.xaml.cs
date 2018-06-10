using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public class SearchParameters
    {
        public int PageNumber { get; set; }
        public string SearchQuery { get; set; }
        public SearchParameters()
        {
            PageNumber = 1;
            SearchQuery = "Nature";
        }
        public SearchParameters(int p, string s)
        {
            PageNumber = p;
            SearchQuery = s;
        }
    }
    public sealed partial class SearchResultPage : Page
    {
        public static RootObject imgData;
        public static SearchParameters parameters;
        public SearchResultPage()
        {
            this.InitializeComponent();
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            //SearchParameters parameters = (SearchResultPage)e.Parameter; //this didnt work?
            parameters = e.Parameter is SearchParameters ? (SearchParameters)e.Parameter : new SearchParameters();
            imgData = await ImageDataImport.GetSearchImageData(parameters.SearchQuery, parameters.PageNumber);
            FillImageGrid(imgData);
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private async void mySearchBox_QuerySubmitted(SearchBox sender, SearchBoxQuerySubmittedEventArgs args)
        {
            parameters = new SearchParameters(1, args.QueryText);
            imgData = await ImageDataImport.GetSearchImageData(args.QueryText, 1);
            FillImageGrid(imgData);
        }

        private void SearchedImageButton1_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ImageEditingPage), imgData.results[0].links.download);
        }

        private void SearchedImageButton2_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ImageEditingPage), imgData.results[1].links.download);
        }

        private void SearchedImageButton3_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ImageEditingPage), imgData.results[2].links.download);
        }

        private void SearchedImageButton4_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ImageEditingPage), imgData.results[3].links.download);
        }

        private void SearchedImageButton5_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ImageEditingPage), imgData.results[4].links.download);
        }

        private void SearchedImageButton6_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ImageEditingPage), imgData.results[5].links.download);
        }

        private void SearchedImageButton7_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ImageEditingPage), imgData.results[6].links.download);
        }

        private void SearchedImageButton8_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ImageEditingPage), imgData.results[7].links.download);
        }

        private void SearchedImageButton9_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ImageEditingPage), imgData.results[8].links.download);
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

        private async void NextPageButton_Click(object sender, RoutedEventArgs e)
        {
            imgData = await ImageDataImport.GetSearchImageData(parameters.SearchQuery, ++parameters.PageNumber);
            FillImageGrid(imgData);
        }

        private async void PreviousPageButton_Click(object sender, RoutedEventArgs e)
        {
            imgData = await ImageDataImport.GetSearchImageData(parameters.SearchQuery, parameters.PageNumber <= 0 ? parameters.PageNumber : --parameters.PageNumber);
            FillImageGrid(imgData);
        }
    }
}
