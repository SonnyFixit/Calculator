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
        SelectedOperator selectedOperator;
        

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
            double newNumber;


            if (double.TryParse(resultLabel.Content.ToString(), out newNumber))
            {
                if(selectedOperator == SelectedOperator.Addition)
                {
                    result = MathOperations.Add(lastNumber, newNumber);
                }

                if (selectedOperator == SelectedOperator.Substraction)
                {
                    result = MathOperations.Substract(lastNumber, newNumber);
                }

                if (selectedOperator == SelectedOperator.Multiplication)
                {
                    result = MathOperations.Multiply(lastNumber, newNumber);
                }

                if (selectedOperator == SelectedOperator.Division)
                {
                    result = MathOperations.Divide(lastNumber, newNumber);
                }
            }

            resultLabel.Content = result.ToString();


        }

        private void PercentButton_Click(object sender, RoutedEventArgs e)
        {
            double tempNumber;

            if (double.TryParse(resultLabel.Content.ToString(), out tempNumber))
            {
                tempNumber = (tempNumber /100);
                
                if (lastNumber != 0)
                {
                    tempNumber *= lastNumber;
                }

                resultLabel.Content = tempNumber.ToString();
            }
        }

        private void DotButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString().Contains("."))
            {
                
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}.";
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
            result = 0;
            lastNumber = 0;
        }

        private void OperationButton_Click(object sender, RoutedEventArgs e)
        {

            if (double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {

                resultLabel.Content = 0;
            }
                


            if (sender == divideButton)
            {
                selectedOperator = SelectedOperator.Division;
            }
            if (sender == multiplyButton)
            {
                selectedOperator = SelectedOperator.Multiplication;
            }
            if(sender == plusButton)
            {
                selectedOperator = SelectedOperator.Addition;
            }
            if(sender == minusButton)
            {
                selectedOperator = SelectedOperator.Substraction;
            }
        }
    }

    public enum SelectedOperator
    {
        Addition,
        Substraction,
        Multiplication,
        Division
    }

    public class MathOperations
    {
        public static double Add(double number1, double number2)
        {
            return number1 + number2;
        }
        public static double Substract(double number1, double number2)
        {
            return number1 - number2;
        }

        public static double Multiply(double number1, double number2)
        {
            return number1 * number2;
        }

        public static double Divide(double number1, double number2)
        {

            if (number2 == 0)
            {
                MessageBox.Show("Division by 0 is not supported", "Wrong operation", MessageBoxButton.OK, MessageBoxImage.Error);
                return 0;
            }
            else
            {

                return number1 / number2;
            }
        }
    }
}
