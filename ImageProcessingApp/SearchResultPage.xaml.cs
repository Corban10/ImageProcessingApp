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
            SearchQuery = "Test";
        }
        public SearchParameters(int p, string s)
        {
            PageNumber = p;
            SearchQuery = s;
        }
    }
    public sealed partial class SearchResultPage : Page
    {
        //private ObservableCollection<string> current;
        public BitmapImage[] Images;
        public SearchResultPage()
        {
            this.InitializeComponent();
        }
        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            //SearchParameters parameters = (SearchResultPage)e.Parameter; //this didnt work?
            SearchParameters parameters = e.Parameter is SearchParameters ? (SearchParameters)e.Parameter : new SearchParameters();
            RootObject imgData = await ImageDataImport.GetImageData(parameters.SearchQuery, parameters.PageNumber);
            FillImageGrid(imgData);
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            //this.Frame.Navigate(typeof(MainPage));
            On_BackRequested();
        }
        private bool On_BackRequested()
        {
            if (this.Frame.CanGoBack)
            {
                this.Frame.GoBack();
                return true;
            }
            return false;
        }
        private void BackInvoked(KeyboardAccelerator sender, KeyboardAcceleratorInvokedEventArgs args)
        {
            On_BackRequested();
            args.Handled = true;
        }
        private async void mySearchBox_QuerySubmitted(SearchBox sender, SearchBoxQuerySubmittedEventArgs args)
        {
            RootObject imgData = await ImageDataImport.GetImageData(args.QueryText, 1);
            Images = new BitmapImage[9];
            FillImageGrid(imgData);
        }

        private void SearchedImageButton1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SearchedImageButton2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SearchedImageButton3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SearchedImageButton4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SearchedImageButton5_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SearchedImageButton6_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SearchedImageButton7_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SearchedImageButton8_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SearchedImageButton9_Click(object sender, RoutedEventArgs e)
        {

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
    }
}
