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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ImageProcessingApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void DogCategoryButton_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = "";
            RootObject imgData = await ImageDataImport.GetImageData("Dog", 1, "ac9a9267e02fed66bad717e4f1c5c7b1374ef9aff855d4c564baef488adf3e05");
            foreach (var item in imgData.results)
            {
                ResultTextBlock.Text += string.Format("{0}\n", item.links.download);
            }
            Uri imageUri = new Uri(imgData.results[0].links.download, UriKind.Absolute);
            BitmapImage imageBitmap = new BitmapImage(imageUri);
            ImageSource1.Source = imageBitmap;
        }

        private async void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = "";
            RootObject imgData = await ImageDataImport.GetImageData(SearchTextBox.Text, 1, "ac9a9267e02fed66bad717e4f1c5c7b1374ef9aff855d4c564baef488adf3e05");
            foreach (var item in imgData.results)
            {
                ResultTextBlock.Text += string.Format("{0}\n", item.links.download);
            }
            Uri imageUri = new Uri(imgData.results[0].links.download, UriKind.Absolute);
            BitmapImage imageBitmap = new BitmapImage(imageUri);
            ImageSource1.Source = imageBitmap;

            //https://social.msdn.microsoft.com/Forums/vstudio/en-US/dd63bb10-915f-42f3-9f08-b0fe9480d772/convert-string-to-imagesource?forum=wpf
            //ImageSource1.Source = imgData.results[0].links.download;
        }
    }
}
