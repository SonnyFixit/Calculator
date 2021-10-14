using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace Calc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private double lastNumber;
        private double result;
        

        public MainWindow()
        {
            InitializeComponent();

            numberSeven.Click += NumberSeven_Click;
            acButton.Click += AcButton_Click;
            positiveNegativeButton.Click += PositiveNegativeButton_Click;
            equalsButton.Click += EqualsButton_Click;
            percentButton.Click += PercentButton_Click;
        }

        private void EqualsButton_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void PercentButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {
                lastNumber = lastNumber /100;
                resultLabel.Content = lastNumber.ToString();
            }
        }

        private void NumberSeven_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "7";
            }

            else
            {

            }
        }

        private void PositiveNegativeButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {
                lastNumber = lastNumber * -1;
                resultLabel.Content = lastNumber.ToString();
            }
        }

        private void AcButton_Click(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = "0";
        }
    }
}
