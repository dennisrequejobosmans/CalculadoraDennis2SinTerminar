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

namespace WpfApp2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            textbox1.Text = "0";
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            if (Numeros.Visibility==Visibility.Visible)
            {
                Numeros.Visibility = Visibility.Hidden;
                Simple.Visibility = Visibility.Visible;
            }
            else
            {
                Numeros.Visibility = Visibility.Visible;
                Simple.Visibility = Visibility.Hidden;
            }
        }

        List<double> memoria = new List<double>();
        bool sumClicked = false;
        bool restClicked = false;
        bool multClicked = false;
        bool divClicked = false;


        


        private void Btn_C_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text = "0";
            LabelOperaciones.Content = "";
            memoria.Clear();
            sumClicked = false;
            restClicked = false;
            multClicked = false;
            divClicked = false;
        }

        private void Btn_1_Click(object sender, RoutedEventArgs e)
        {
            if (textbox1.Text.Equals("0"))
            {
                textbox1.Text = "1";
            }
            else
                textbox1.AppendText("1");
        }

        private void Btn_2_Click(object sender, RoutedEventArgs e)
        {
            if (textbox1.Text.Equals("0"))
            {
                textbox1.Text = "2";
            }
            else
                textbox1.AppendText("2");
        }

        private void Btn_3_Click(object sender, RoutedEventArgs e)
        {
            if (textbox1.Text.Equals("0"))
            {
                textbox1.Text = "3";
            }
            else
                textbox1.AppendText("3");
        }

        private void Btn_4_Click(object sender, RoutedEventArgs e)
        {
            if (textbox1.Text.Equals("0"))
            {
                textbox1.Text = "4";
            }
            else
                textbox1.AppendText("4");
        }

        private void Btn_5_Click(object sender, RoutedEventArgs e)
        {
            if (textbox1.Text.Equals("0"))
            {
                textbox1.Text = "5";
            }
            else
                textbox1.AppendText("5");
        }

        private void Btn_6_Click(object sender, RoutedEventArgs e)
        {
            if (textbox1.Text.Equals("0"))
            {
                textbox1.Text = "6";
            }
            else
                textbox1.AppendText("6");
        }

        private void Btn_7_Click(object sender, RoutedEventArgs e)
        {
            if (textbox1.Text.Equals("0"))
            {
                textbox1.Text = "7";
            }
            else
                textbox1.AppendText("7");
        }

        private void Btn_8_Click(object sender, RoutedEventArgs e)
        {
            if (textbox1.Text.Equals("0"))
            {
                textbox1.Text = "8";
            }
            else
                textbox1.AppendText("8");
        }

        private void Btn_9_Click(object sender, RoutedEventArgs e)
        {
            if (textbox1.Text.Equals("0"))
            {
                textbox1.Text = "9";
            }
            else
                textbox1.AppendText("9");
        }

        private void Btn_Cero_Click(object sender, RoutedEventArgs e)
        {
            if (textbox1.Text.Equals("0"))
            {
                textbox1.Text = "0";
            }
            else
                textbox1.AppendText("0");
        }

        private void Btn_Coma_Click(object sender, RoutedEventArgs e)
        {
            textbox1.AppendText(",");
        }

        private void Btn_Del_Click(object sender, RoutedEventArgs e)
        {
            string pantalla = textbox1.Text;

            if (pantalla.Length > 1)
            {
                pantalla = pantalla.Substring(0, pantalla.Length - 1);
            }
            else
            {
                pantalla = "0";
            }

            textbox1.Text = pantalla;
        }

        private void Btn_Sum_Click(object sender, RoutedEventArgs e)
        {
            double numero = Double.Parse(textbox1.Text);
            if (memoria.Count > 0)
            {
                memoria.Add(memoria[0] + numero);
            }
            else
            {
                memoria.Add(numero);
            }
            sumClicked = true;
            restClicked = false;
            multClicked = false;
            divClicked = false;
            LabelOperaciones.Content = "+";
            textbox1.Text = "0";
        }


        private void Btn_Res_Click(object sender, RoutedEventArgs e)
        {
            double numero = Double.Parse(textbox1.Text);
            if (memoria.Count > 0)
            {
                memoria.Add(memoria[0] - numero);
            }
            else
            {
                memoria.Add(numero);
            }
            sumClicked = false;
            restClicked = true;
            multClicked = false;
            divClicked = false;
            LabelOperaciones.Content = "-";
            textbox1.Text = "0";
        }

        private void Btn_Mult_Click(object sender, RoutedEventArgs e)
        {
            double numero = Double.Parse(textbox1.Text);
            if (memoria.Count > 0)
            {
                memoria.Add(memoria[0] * numero);
            }
            else
            {
                memoria.Add(numero);
            }
            sumClicked = false;
            restClicked = false;
            multClicked = true;
            divClicked = false;
            LabelOperaciones.Content = "*";
            textbox1.Text = "0";
        }

        private void Btn_Div_Click(object sender, RoutedEventArgs e)
        {
            double numero = Double.Parse(textbox1.Text);
            if (memoria.Count > 0)
            {
                memoria.Add(memoria[0] / numero);
            }
            else
            {
                memoria.Add(numero);
            }
            sumClicked = false;
            restClicked = false;
            multClicked = false;
            divClicked = true;
            LabelOperaciones.Content = "/";
            textbox1.Text = "0";
        }

        private void Btn_Solve_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (memoria.Count > 0)
                {

                    LabelOperaciones.Content = "=";
                    if (sumClicked)
                    {
                        textbox1.Text = (memoria[memoria.Count - 1] + Double.Parse(textbox1.Text)).ToString();
                        sumClicked = false;
                    }
                    else if (restClicked)
                    {
                        textbox1.Text = (memoria[memoria.Count - 1] - Double.Parse(textbox1.Text)).ToString();
                        restClicked = false;
                    }
                    else if (multClicked)
                    {
                        textbox1.Text = (memoria[memoria.Count - 1] * Double.Parse(textbox1.Text)).ToString();
                        multClicked = false;
                    }
                    else if (divClicked)
                    {
                        textbox1.Text = (memoria[memoria.Count - 1] / Double.Parse(textbox1.Text)).ToString();
                        divClicked = false;
                    }
                    memoria.Clear();
                }
            }
            catch (Exception ex)
            {
                LabelOperaciones.Content = "Error";
                memoria.Clear();
                sumClicked = false;
                restClicked = false;
                multClicked = false;
                divClicked = false;
            }


        }
        

        private void Btn_Mem_Click(object sender, RoutedEventArgs e)
        {
            double numero = Double.Parse(textbox1.Text);
            memoria.Add(numero);
            textbox1.Text = "0";

        }

        private void Btn_Pow_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_Sqrt_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_PI_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_Fact_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_ParAbre_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_ParCierra_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_x_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
