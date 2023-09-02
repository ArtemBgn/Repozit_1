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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); 
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            decimal a = -1;

            double x;
            double y;
            bool b1 = double.TryParse(textbox1.Text, out x);
            bool c1 = double.TryParse(textbox2.Text, out y);
            //MessageBox.Show($"текстбоксс 1 = {b1}\nтекстбокс 2 = {c1}");

            if (b1 && c1)
            {
                if ((double.Parse(textbox1.Text) > double.MaxValue) || (double.Parse(textbox1.Text) < double.MinValue))
                {
                    MessageBox.Show("Ви ввели занадто велеке значення!\nБудь-ласка, спробуйте інше значення..");
                    return;
                }

                if ((double.Parse(textbox2.Text) > double.MaxValue) || (double.Parse(textbox2.Text) < double.MinValue))
                {
                    MessageBox.Show("Ви ввели занадто мале значення!\nБудь-ласка, спробуйте інше значення..");
                    return;
                }

                switch (combobox1.SelectedIndex)
                {
                    case (0):
                        a = Calc.sum(x, y);
                        break;
                    case (1):
                        a = Calc.sub(x, y);
                        break;
                    case (2):
                        a = Calc.mult(x, y);
                        break;
                    case (3):
                        if (y == 0)
                        {
                            MessageBox.Show("Ділення на 0 заборонено!\nБудь-ласка, перевірте значення!");
                            return;
                        }
                        a = Calc.div(x, y);
                        break;
                    case (4):
                        a = Calc.remOfdiv(x, y);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Введене значення не є числом!\nБудь-ласка, перевірте введені значення!");
                return;
            }

            label1.Content = a.ToString(format: "");
        }
    }
}
