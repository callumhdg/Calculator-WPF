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
        private StringBuilder _selectedOpperation = new StringBuilder();
        private StringBuilder _currentNum = new StringBuilder();

        private string[] _nums = new string[9];
        private int _currentNumCount = 0;


        public MainWindow()
        {
            InitializeComponent();
            display();
        }


        //Number Selection
        private void btnNum1_Click(object sender, RoutedEventArgs e)
        {
            _currentNum.Append(btnNum1.Content);
            updateCurrentNum();

            display();
        }

        private void btnNum2_Click(object sender, RoutedEventArgs e)
        {
            _currentNum.Append(btnNum2.Content.ToString());
            updateCurrentNum();

            display();
        }

        private void btnNum3_Click(object sender, RoutedEventArgs e)
        {
            _currentNum.Append(btnNum3.Content);
            updateCurrentNum();

            display();
        }

        private void btnNum4_Click(object sender, RoutedEventArgs e)
        {
            _currentNum.Append(btnNum4.Content);
            updateCurrentNum();

            display();
        }

        private void btnNum5_Click(object sender, RoutedEventArgs e)
        {
            _currentNum.Append(btnNum5.Content);
            updateCurrentNum();

            display();
        }

        private void btnNum6_Click(object sender, RoutedEventArgs e)
        {
            _currentNum.Append(btnNum6.Content);
            updateCurrentNum();

            display();
        }

        private void btnNum7_Click(object sender, RoutedEventArgs e)
        {
            _currentNum.Append(btnNum7.Content);
            updateCurrentNum();

            display();
        }

        private void btnNum8_Click(object sender, RoutedEventArgs e)
        {
            _currentNum.Append(btnNum8.Content);
            updateCurrentNum();

            display();
        }

        private void btnNum9_Click(object sender, RoutedEventArgs e)
        {
            _currentNum.Append(btnNum9.Content);
            updateCurrentNum();

            display();
        }

        private void btnNum0_Click(object sender, RoutedEventArgs e)
        {
            _currentNum.Append(btnNum0.Content);
            updateCurrentNum();

            display();
        }





        //Math Opperations
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            _selectedOpperation.Append("+");
            _currentNum.Clear();

            _currentNumCount++;
            display();
        }

        private void btnSubtract_Click(object sender, RoutedEventArgs e)
        {
            _selectedOpperation.Append("-");
             _currentNum.Clear();

            _currentNumCount++;
            display();
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            _selectedOpperation.Append("X");
            _currentNum.Clear();

            _currentNumCount++;
            display();
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            _selectedOpperation.Append("/");
            _currentNum.Clear();

            _currentNumCount++;
            display();
        }



        //Calculate Output
        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {
            int result = 0, count = 0;
            int divCount = 0, mulCount = 0, addCount = 0, minCount = 0;
            StringBuilder BODMAS = new StringBuilder();
            List<char> input = new List<char>();

            foreach (char item in _selectedOpperation.ToString())
            {
                input.Add(item);
            }

            while (count < input.Count)
            {
                if (input.Contains('/'))
                {
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input[i].ToString() == "/")
                        {
                            BODMAS.Append(i + "/");
                            count++;
                            divCount++;
                        }
                    }
                }
                if (input.Contains('X'))
                {
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input[i].ToString() == "X")
                        {
                            BODMAS.Append(i + "X");
                            count++;
                            mulCount++;
                        }
                    }
                }
                if (input.Contains('+'))
                {
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input[i].ToString() == "+")
                        {
                            BODMAS.Append(i + "+");
                            count++;
                            addCount++;
                        }
                    }
                }
                if (input.Contains('-'))
                {
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input[i].ToString() == "-")
                        {
                            BODMAS.Append(i + "-");
                            count++;
                            minCount++;
                        }
                    }
                }                
            }



            bool hasDoneMath = false;

            if (divCount > 0)
            {
                for (int j = 0; j < BODMAS.Length; j += 2)
                {
                    if (BODMAS[j + 1].ToString() == "/")
                    {
                        int num1 = BODMAS[j] - 48;
                        int num2 = BODMAS[j] - 47;

                        result += Calculator.Divide(Convert.ToInt32(_nums[num1]), Convert.ToInt32(_nums[num2]));
                        hasDoneMath = true;
                    }
                }                    
            }
            if (mulCount > 0)
            {
                for (int j = 0; j < BODMAS.Length; j += 2)
                {
                    if (BODMAS[j + 1].ToString() == "X" && hasDoneMath == false)
                    {
                        int num1 = BODMAS[j] - 48;
                        int num2 = BODMAS[j] - 47;

                        result += Calculator.Multiply(Convert.ToInt32(_nums[num1]), Convert.ToInt32(_nums[num2]));
                        hasDoneMath = true;
                    }
                    else if (BODMAS[j + 1].ToString() == "X" && hasDoneMath == true)
                    {
                        int num1 = BODMAS[j] - 48;
                        int num2 = result;

                        result += Calculator.Multiply(Convert.ToInt32(_nums[num1]), num2);
                        hasDoneMath = true;
                    }
                }                    
            }
            if (addCount > 0)
            {
                for (int j = 0; j < BODMAS.Length; j += 2)
                {
                    if (BODMAS[j + 1].ToString() == "+" && hasDoneMath == false)
                    {
                        int num1 = BODMAS[j] - 48;
                        int num2 = BODMAS[j] - 47;

                        result += Calculator.Add(Convert.ToInt32(_nums[num1]), Convert.ToInt32(_nums[num2]));
                        hasDoneMath = true;
                    }
                    else if (BODMAS[j + 1].ToString() == "+" && hasDoneMath == true)
                    {
                        int num1 = BODMAS[j] - 48;
                        int num2 = result;

                        result = Calculator.Add(Convert.ToInt32(_nums[num1]), num2);
                        hasDoneMath = true;
                    }
                }
            }


            if (minCount > 0)
            {
                for (int j = 0; j < BODMAS.Length; j += 2)
                {
                    if (BODMAS[j + 1].ToString() == "-" && hasDoneMath == false)
                    {
                        int num1 = BODMAS[j] - 48;
                        int num2 = BODMAS[j] - 47;

                        result += Calculator.Subtract(Convert.ToInt32(_nums[num1]), Convert.ToInt32(_nums[num2]));
                    }
                    else if (BODMAS[j + 1].ToString() == "-" && hasDoneMath == true)
                    {
                        int num1 = BODMAS[j] - 48;
                        int num2 = result;

                        result = Calculator.Subtract(Convert.ToInt32(_nums[num1]), num2);
                        hasDoneMath = true;
                    }
                }
            }

            lblDisplay.Content = result;
            _selectedOpperation.Clear();

        }



        //Clear
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            _currentNum.Clear();
            _currentNumCount = 0;

            for (int i = 0; i < 10; i++)
            {
                _nums[i] = null;
            }

            _selectedOpperation.Clear();
            lblDisplay.Content = "";
        }



        //Display
        private void display()
        {
            StringBuilder displayOut = new StringBuilder();
            int counter = 0;

            for (int i = 0; i < 10; i++)
            {
                if (_nums[i] != null)
                {
                    counter++;
                }
            }


            if (_nums[0] == null)
            {
                displayOut.Append("0");
            }
            else if (_nums[0] != null && _selectedOpperation.ToString() != "")
            {

                for (int i = 0; i < counter; i++)
                {
                    displayOut.Append(_nums[i] + " ");

                    if (i < _selectedOpperation.Length)
                    {
                        displayOut.Append(_selectedOpperation[i] + " ");
                    }
                    
                }

            }
            else if (_nums[0] != null)
            {
                for (int i = 0; i < _nums.Length; i++)
                {
                    if (_nums[i] != null)
                    {
                        displayOut.Append(_nums[i] + " ");
                    }                    
                }
            }

            lblDisplay.Content = displayOut.ToString();

        }


        private void updateCurrentNum()
        {
            for (int i = _nums.Length - 1; i >= 0; i--)
            {
                if (_nums[0] == null)
                {
                    _nums[0] = _currentNum.ToString();
                    break;
                }
                else if (_nums[i] != null)
                {
                    _nums[_currentNumCount] = _currentNum.ToString();
                    break;
                }                
            }
        }




    }
}
