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
using System.Windows.Threading;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        double temp1 = -1;
        int pos = 0;
        DispatcherTimer timer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
        }

        public void addNum(int num)
        {
            result.Text = result.Text + num.ToString();
        }

        private void Num0_Click(object sender, RoutedEventArgs e)
        {
            addNum(0);
        }

        private void Num1_Click(object sender, RoutedEventArgs e)
        {
            addNum(1);
        }

        private void Num2_Click(object sender, RoutedEventArgs e)
        {
            addNum(2);
        }

        private void Num3_Click(object sender, RoutedEventArgs e)
        {
            addNum(3);
        }

        private void Num6_Click(object sender, RoutedEventArgs e)
        {
            addNum(4);
        }

        private void Num5_Click(object sender, RoutedEventArgs e)
        {
            addNum(5);
        }

        private void Num4_Click(object sender, RoutedEventArgs e)
        {
            addNum(6);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            addNum(7);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            addNum(8);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            addNum(9);
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            pos = 1;
            temp1 = Convert.ToDouble(result.Text);
            result.Text += "+" ;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            pos = 2;
            temp1 = Convert.ToDouble(result.Text);
            result.Text += "_";
        }


        private void Mul_Click(object sender, RoutedEventArgs e)
        {
            pos = 3;
            temp1 = Convert.ToDouble(result.Text);
            result.Text += "*";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            pos = 4;
            temp1 = Convert.ToDouble(result.Text);
            result.Text += "/";
        }

        private void Sqrt1_Click(object sender, RoutedEventArgs e)
        {
            pos = 5;
            temp1 = Convert.ToDouble(result.Text);
            result.Text = "√" + result.Text;
        }

        private void Pow_Click(object sender, RoutedEventArgs e)
        {
            pos = 6;
            temp1 = Convert.ToDouble(result.Text);
            result.Text += "^";
        }

        private void Eq_Click(object sender, RoutedEventArgs e)
        {
            string[] res = result.Text.Split('+', '_', '*', '/', '^', '√');
            switch (pos)
            {
                case 1:
                    result.Text = (Convert.ToDouble(res[0]) + Convert.ToDouble(res[1])).ToString();
                    temp1 = Convert.ToDouble(result.Text);
                    break;
                case 2:
                    result.Text = (Convert.ToDouble(res[0]) - Convert.ToDouble(res[1])).ToString();
                    temp1 = Convert.ToDouble(result.Text);
                    break;
                case 3:
                    result.Text = (Convert.ToDouble(res[0]) * Convert.ToDouble(res[1])).ToString();
                    temp1 = Convert.ToDouble(result.Text);
                    break;
                case 4:
                    result.Text = (Convert.ToDouble(res[0]) / Convert.ToDouble(res[1])).ToString();
                    temp1 = Convert.ToDouble(result.Text);
                    break;
                case 5:
                    result.Text = (Math.Sqrt(Convert.ToDouble(res[1]))).ToString();
                    temp1 = Convert.ToDouble(result.Text);
                    break;
                case 6:
                    result.Text = (Math.Pow(temp1, Convert.ToDouble(res[1]))).ToString();
                    temp1 = Convert.ToDouble(result.Text);
                    break;
                default:
                    result.Text = "error";
                    break;
            }
        }

        private void Ce_Click(object sender, RoutedEventArgs e)
        {
            result.Text = "";
            temp1 = 0;
            pos = 0;
            timer.Stop();
        }

        private void Showtime_Click(object sender, RoutedEventArgs e)
        {
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.result.Text = DateTime.Now.ToString();
        }
    }
}
