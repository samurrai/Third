using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Third
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<string> products;
        string language = "";

        public MainWindow()
        {
            CultureInfo culture = Thread.CurrentThread.CurrentCulture;
            language = culture.IetfLanguageTag.Substring(0, 2);
            InitializeComponent();
            if (language == "en")
            {
                firstLabel.Content = "Product #1";
                secondLabel.Content = "Product #2";
                thirdLabel.Content = "Product #3";
                fourthLabel.Content = "Product #4";

                firstButton.Content = "Add";
                secondButton.Content = "Add";
                thirdButton.Content = "Add";
                fourthButton.Content = "Add";

                showCartButton.Content = "Show cart";
                changeLanguageButton.Content = "Change language";
            }
            products = new List<string>();
        }


        private void FirstButtonClick(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(firstTextBox.Text))
            {
                products.Add(firstTextBox.Text);
                firstTextBox.Text = "";
            }
        }

        private void SecondButtonClick(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(secondTextBox.Text))
            {
                products.Add(secondTextBox.Text);
                secondTextBox.Text = "";
            }
        }

        private void ThirdButtonClick(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(thirdTextBox.Text))
            {
                products.Add(thirdTextBox.Text);
                thirdTextBox.Text = "";
            }
        }

        private void FourthButtonClick(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(fourthTextBox.Text))
            {
                products.Add(fourthTextBox.Text);
                fourthTextBox.Text = "";
            }
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            string productsString = "";
            foreach (var product in products)
            {
                productsString += product + ", ";
            }
            MessageBox.Show(productsString);
        }

        private void ChangeLanguage(object sender, RoutedEventArgs e)
        {
            if (language == "ru")
            {
                language = "en";
                firstLabel.Content = "Product #1";
                secondLabel.Content = "Product #2";
                thirdLabel.Content = "Product #3";
                fourthLabel.Content = "Product #4";

                firstButton.Content = "Add";
                secondButton.Content = "Add";
                thirdButton.Content = "Add";
                fourthButton.Content = "Add";

                showCartButton.Content = "Show cart";
                changeLanguageButton.Content = "Change language";

            }
            else
            {
                language = "ru";
                firstLabel.Content = "Товар #1";
                secondLabel.Content = "Товар #2";
                thirdLabel.Content = "Товар #3";
                fourthLabel.Content = "Товар #4";

                firstButton.Content = "Добавить";
                secondButton.Content = "Добавить";
                thirdButton.Content = "Добавить";
                fourthButton.Content = "Добавить";

                showCartButton.Content = "Просмотреть корзину";
                changeLanguageButton.Content = "Сменить язык";
            }
        }
    }
}
