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

namespace Aula_07_08_2018
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        double memoria;
        double acumula = 0;
        string operador;

        private void Num_7_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "7";
        }

        private void Num_8_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "8";
        }

        private void Num_9_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "9";
        }

        private void Num_4_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "4";
        }

        private void Num_5_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "5";
        }

        private void Num_6_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "6";
        }

        private void Num_1_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "1";
        }

        private void Num_2_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "2";
        }

        private void Num_3_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "3";
        }

        private void Num_0_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "0";
        }

        private void Soma_Click(object sender, RoutedEventArgs e)
        {
            if (operador == "*" || operador == "-" || operador == "/")
            {
                operador = "+";
            }
            else
            {
                acumula += double.Parse(display.Text);
                display.Text = "";
                operador = "+";
            }
        }

        private void Ponto_Click(object sender, RoutedEventArgs e)
        {
            display.Text += ",";
        }

        private void Result_Click(object sender, RoutedEventArgs e)
        {
            if (operador == "+")
            {
                acumula += double.Parse(display.Text);
                display.Text = acumula.ToString();
                acumula = 0;

            }
            else if (operador == "-")
            {
                acumula -= double.Parse(display.Text);
                display.Text = acumula.ToString();
                acumula = 0;
            }
            else if (operador == "*")
            {
                acumula *= double.Parse(display.Text);
                display.Text = acumula.ToString();
                acumula = 0;
            }
            else if (operador == "/")
            {
                if (double.Parse(display.Text) != 0)
                {
                    acumula /= double.Parse(display.Text);
                    display.Text = acumula.ToString();
                    acumula = 0;
                }
                else
                {
                    display.Text = "Dividindo por zero";
                }
            }
        }

        private void Subtracao_Click(object sender, RoutedEventArgs e)
        {
            if (operador == "*" || operador == "+" || operador == "/")
            {
                operador = "-";
            }
            else
            {
                acumula = double.Parse(display.Text);
                display.Text = "";
                operador = "-";
            }
        }

        private void Multi_Click(object sender, RoutedEventArgs e)
        {
            if (operador == "-" || operador == "+" || operador == "/")
            {
                operador = "*";
            }
            else
            {
                acumula = double.Parse(display.Text);
                display.Text = "";
                operador = "*";
            }
        }

        private void Divisao_Click(object sender, RoutedEventArgs e)
        {
            if (operador == "*" || operador == "+" || operador == "-")
            {
                operador = "/";
            }
            else
            {
                acumula = double.Parse(display.Text);
                display.Text = "";
                operador = "/";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        
            int x = display.Text.Length - 1;
            if (x >= 0)
            {
                display.Text = display.Text.Substring(0, x);
            }
        }

        private void Raiz_Click(object sender, RoutedEventArgs e)
        {
            double x = double.Parse(display.Text);
            if (x < 0)
            {
                display.Text = "Este valor não é valido.";
            }
            else
            {
                x = Math.Sqrt(x);
                display.Text = x.ToString();
            }
        }

        private void Pot_Click(object sender, RoutedEventArgs e)
        {
                double x = double.Parse(display.Text);

                display.Text = Math.Pow(x, Double.Parse(display.Text)).ToString();
        }

        private void Memo_Click(object sender, RoutedEventArgs e)
        {
            
       }
    }
}
