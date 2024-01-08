using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace YourNamespace
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            JobTitleTextBox.TextChanged += JobTitleTextBox_TextChanged;
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            ShowEnteredDataMessageBox();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            ClearTextBoxes();
        }

        private void ShowEnteredDataMessageBox()
        {
            StringBuilder SB = new StringBuilder();
            SB.AppendLine($"First Name: {FirstNameTextBox.Text}");
            SB.AppendLine($"Last Name: {LastNameTextBox.Text}");
            SB.AppendLine($"Gender: {GenderTextBox.Text}");
            SB.AppendLine($"Address: {AddressTextBox.Text}");
            SB.AppendLine($"Phone: {PhoneTextBox.Text}");
            SB.AppendLine($"Mobile: {MobileTextBox.Text}");
            SB.AppendLine($"Email: {EmailTextBox.Text}");
            SB.AppendLine($"Job Title: {JobTitleTextBox.Text}");

            MessageBoxResult result = MessageBox.Show(SB.ToString(), "Info", MessageBoxButton.OKCancel, MessageBoxImage.Information);

            if (result == MessageBoxResult.OK)
            {
                ShowSavingMessageBox("Data saved successfully");
            }
            else if (result == MessageBoxResult.Cancel)
            {
                ClearTextBoxes();
            }
        }

        private void ShowSavingMessageBox(string message)
        {
            MessageBox.Show(message, "Saving", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ClearTextBoxes()
        {
            FirstNameTextBox.Text = "";
            LastNameTextBox.Text = "";
            GenderTextBox.Text = "";
            AddressTextBox.Text = "";
            PhoneTextBox.Text = "";
            MobileTextBox.Text = "";
            EmailTextBox.Text = "";
            JobTitleTextBox.Text = "";
        }

        private void JobTitleTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // You can add specific logic related to the JobTitleTextBox.TextChanged event here
        }
    }
}
