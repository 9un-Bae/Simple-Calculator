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

namespace SimpleCalculator
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

        private void OperationChanged(Object sender, Object e)
        {
            decimal num1 = 0;
            decimal num2 = 0;
            decimal result = 0;

            if (TxtNum2 != null && TxtNum1 != null && LblResult != null && decimal.TryParse(TxtNum1.Text, out num1) && decimal.TryParse(TxtNum2.Text, out num2))
            {
                switch(((ComboBoxItem)combo.SelectedItem).Content)
                {
                    case "Add":
                        result = num1 + num2;
                        break;
                    case "Subtract":
                        result = num1 - num2;
                        break;
                    case "Multiply":
                        result = num1 * num2;
                        break;
                    case "Divide":
                        result = num1 / num2;
                        break;
                    default:
                        break;
                }
                LblResult.Content = result.ToString();
            }
        }

        private void OperationChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
