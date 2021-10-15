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

        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            int selectedNumber = int.Parse((sender as Button).Content.ToString());

            //if(sender == numberZero)
            //{
            //    selectedNumber = 0;
            //}

            //if (sender == numberOne)
            //{
            //    selectedNumber = 1;
            //}

            //if (sender == numberTwo)
            //{
            //    selectedNumber = 2;
            //}

            //if (sender == numberThree)
            //{
            //    selectedNumber = 3;
            //}

            //if (sender == numberFour)
            //{
            //    selectedNumber = 4;
            //}

            //if (sender == numberFive)
            //{
            //    selectedNumber = 5;
            //}

            //if (sender == numberSix)
            //{
            //    selectedNumber = 6;
            //}

            //if (sender == numberSeven)
            //{
            //    selectedNumber = 7;
            //}

            //if (sender == numberEight)
            //{
            //    selectedNumber = 8;
            //}

            //if (sender == numberNine)
            //{
            //    selectedNumber = 9;
            //}

            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = $"{selectedNumber}";
            }

            else
            {
                resultLabel.Content = $"{resultLabel.Content}{selectedNumber}";
            }
        }

        private void PositiveNegativeButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {
                if (lastNumber == 0)
                {
                    resultLabel.Content = lastNumber.ToString();
                }
                else
                {
                    lastNumber = lastNumber * -1;
                    resultLabel.Content = lastNumber.ToString();
                }
            }
        }

        private void AcButton_Click(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = "0";
        }

        private void OperationButton_Click(object sender, RoutedEventArgs e)
        {

            if (double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {

                resultLabel.Content = 0;
            }
                


                if (sender == divideButton)
            {

            }
        }
    }
}
