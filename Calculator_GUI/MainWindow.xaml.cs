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
using Calculator_Back_End;

namespace Calculator_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string _numOne = "";
        private string _numTwo = "";
        private bool _numOneAssigned = false;
        private string _selectedOpperation = "";


        public MainWindow()
        {
            InitializeComponent();
        }


        //Number Selection
        private void btnNum1_Click(object sender, RoutedEventArgs e)
        {
            if (_numOneAssigned == false)
            {
                _numOne += btnNum1.Content;
            }
            else
            {
                _numTwo += btnNum1.Content;
            }
            display();
        }

        private void btnNum2_Click(object sender, RoutedEventArgs e)
        {
            if (_numOneAssigned == false)
            {
                _numOne += btnNum2.Content;
            }
            else
            {
                _numTwo += btnNum2.Content;
            }
            display();
        }

        private void btnNum3_Click(object sender, RoutedEventArgs e)
        {
            if (_numOneAssigned == false)
            {
                _numOne += btnNum3.Content;
            }
            else
            {
                _numTwo += btnNum3.Content;
            }
            display();
        }

        private void btnNum4_Click(object sender, RoutedEventArgs e)
        {
            if (_numOneAssigned == false)
            {
                _numOne += btnNum4.Content;
            }
            else
            {
                _numTwo += btnNum4.Content;
            }
            display();
        }

        private void btnNum5_Click(object sender, RoutedEventArgs e)
        {
            if (_numOneAssigned == false)
            {
                _numOne += btnNum5.Content;
            }
            else
            {
                _numTwo += btnNum5.Content;
            }
            display();
        }

        private void btnNum6_Click(object sender, RoutedEventArgs e)
        {
            if (_numOneAssigned == false)
            {
                _numOne += btnNum6.Content;
            }
            else
            {
                _numTwo += btnNum6.Content;
            }
            display();
        }

        private void btnNum7_Click(object sender, RoutedEventArgs e)
        {
            if (_numOneAssigned == false)
            {
                _numOne += btnNum7.Content;
            }
            else
            {
                _numTwo += btnNum7.Content;
            }
            display();
        }

        private void btnNum8_Click(object sender, RoutedEventArgs e)
        {
            if (_numOneAssigned == false)
            {
                _numOne += btnNum8.Content;
            }
            else
            {
                _numTwo += btnNum8.Content;
            }
            display();
        }

        private void btnNum9_Click(object sender, RoutedEventArgs e)
        {
            if (_numOneAssigned == false)
            {
                _numOne += btnNum9.Content;
            }
            else
            {
                _numTwo += btnNum9.Content;
            }
            display();
        }

        private void btnNum0_Click(object sender, RoutedEventArgs e)
        {
            if (_numOneAssigned == false)
            {
                _numOne += btnNum0.Content;
            }
            else
            {
                _numTwo += btnNum0.Content;
            }
            display();
        }





        //Math Opperations
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            _numOneAssigned = true;
            _selectedOpperation = "+";

            display();
        }

        private void btnSubtract_Click(object sender, RoutedEventArgs e)
        {
            _numOneAssigned = true;
            _selectedOpperation = "-";

            display();
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            _numOneAssigned = true;
            _selectedOpperation = "X";

            display();
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            _numOneAssigned = true;
            _selectedOpperation = "/";

            display();
        }



        //Calculate Output
        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {
            if (_selectedOpperation == "+")
            {
                string output = $"{_numOne} + {_numTwo} = ";
                string calculation = Calculator.Add(Convert.ToInt32(_numOne), Convert.ToInt32(_numTwo)).ToString();
                lblDisplay.Content = output + calculation;

                _numOne = calculation;
            }
            else if (_selectedOpperation == "-")
            {
                string output = $"{_numOne} - {_numTwo} = ";
                string calculation = Calculator.Subtract(Convert.ToInt32(_numOne), Convert.ToInt32(_numTwo)).ToString();
                lblDisplay.Content = output + calculation;

                _numOne = calculation;
            }
            else if (_selectedOpperation == "X")
            {
                string output = $"{_numOne} X {_numTwo} = ";
                string calculation = Calculator.Multiply(Convert.ToInt32(_numOne), Convert.ToInt32(_numTwo)).ToString();
                lblDisplay.Content = output + calculation;

                _numOne = calculation;
            }
            else if (_selectedOpperation == "/")
            {
                string output = $"{_numOne} / {_numTwo} = ";
                string calculation = Calculator.Divide(Convert.ToInt32(_numOne), Convert.ToInt32(_numTwo)).ToString();
                lblDisplay.Content = output + calculation;

                _numOne = calculation;
            }

            _selectedOpperation = "";
            _numOneAssigned = true;
            _numTwo = "";

        }



        //Clear
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            _numOne = "";
            _numTwo = "";
            _numOneAssigned = false;
            _selectedOpperation = "";
            lblDisplay.Content = "";
        }



        //Display
        private void display()
        {
            if (_numOneAssigned == false)
            {
                lblDisplay.Content = _numOne;
            }
            else if (_numOneAssigned + _selectedOpperation != "")
            {
                lblDisplay.Content = _numOne + " " + _selectedOpperation + " " + _numTwo;
            }
            
        }


    }
}
