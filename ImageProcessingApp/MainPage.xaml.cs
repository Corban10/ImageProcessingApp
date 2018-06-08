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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ImageProcessingApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        //private ObservableCollection<string> current;
        //private int ThreeImagesPerColumn = 3;
        public MainPage()
        {
            this.InitializeComponent();
        }
        private void DogCategoryButton_Click(object sender, RoutedEventArgs e)
        {
            var parameters = new SearchParameters(1, "Dog");
            Frame.Navigate(typeof(SearchResultPage), parameters);
        }
        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            var parameters = SearchTextBox.Text == "" ? new SearchParameters() : new SearchParameters(1, SearchTextBox.Text);
            Frame.Navigate(typeof(SearchResultPage), parameters);
        }
    }
}
