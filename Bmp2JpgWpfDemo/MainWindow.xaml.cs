using System;
using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Bmp2JpgWpfDemo
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenImage_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.bmp)|*.bmp|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == true)
            {
                string imagePath = openFileDialog.FileName;
                txtSourcePath.Text = imagePath;

                // Display the original image in preview
                ShowPreview(imagePath);
            }
        }

        private void Convert_Click(object sender, RoutedEventArgs e)
        {
            string sourceImagePath = txtSourcePath.Text.Trim();
            if (string.IsNullOrEmpty(sourceImagePath) || !File.Exists(sourceImagePath))
            {
                MessageBox.Show("Please select a valid source image.");
                return;
            }

            int quality = (int)sliderQuality.Value;

            try
            {
                string jpgImagePath = ConvertToJpg(sourceImagePath, quality);

                // Display the converted image in preview
                ShowPreview(jpgImagePath);

                MessageBox.Show("Conversion completed successfully. Saved as: " + jpgImagePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during conversion: " + ex.Message);
            }
        }

        private string ConvertToJpg(string sourceImagePath, int quality)
        {
            string jpgImagePath = Path.ChangeExtension(sourceImagePath, ".jpg");

            using (var sourceStream = new FileStream(sourceImagePath, FileMode.Open, FileAccess.Read))
            {
                var bmp = new BitmapImage();
                bmp.BeginInit();
                bmp.CacheOption = BitmapCacheOption.OnLoad;
                bmp.StreamSource = sourceStream;
                bmp.EndInit();

                var encoder = new JpegBitmapEncoder();
                encoder.QualityLevel = quality;
                encoder.Frames.Add(BitmapFrame.Create(bmp));

                using (var outputStream = new FileStream(jpgImagePath, FileMode.Create))
                {
                    encoder.Save(outputStream);
                }
            }

            return jpgImagePath;
        }

        private void ShowPreview(string imagePath)
        {
            if (File.Exists(imagePath))
            {
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(imagePath);
                bitmap.EndInit();

                imgPreview.Source = bitmap;
            }
        }
    }
}