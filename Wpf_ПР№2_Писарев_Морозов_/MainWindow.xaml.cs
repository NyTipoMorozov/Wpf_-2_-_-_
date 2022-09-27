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

namespace Wpf_ПР_2_Писарев_Морозов_
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Schet_Click(object sender, RoutedEventArgs e)
        {
            Itog.Text += Environment.NewLine + "Практическая работа 2";
            //Считываем значение А
            double a = double.Parse(A.Text);
            //Вывод значение А в окно
            Itog.Text += Environment.NewLine + "A = " + a.ToString();
            //Считываение значение B
            double b = double.Parse(B.Text);
            //Вывод значение C в окно
            Itog.Text += Environment.NewLine + "B = " + b.ToString();
            double c = double.Parse(C.Text);
            //Вывод значение C в окно
            Itog.Text += Environment.NewLine + "C = " + c.ToString();
            //Считываение значение P
            double p = double.Parse(P.Text);
            //Вывод значение  P окно
            Itog.Text += Environment.NewLine + "P = " + p.ToString();


            //Вычисляем арифметическое выражение 
            double z = ((p - a) * (p - b) * (p - c) / p);
            double r = Math.Sqrt(z);
            Itog.Text += Environment.NewLine + "Результат r = " + r.ToString(); 
            
        }
        
    

    }
}
