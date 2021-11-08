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

namespace WPF_HomeBookkeeping
{
    public partial class MainWindow : Window
    {
        double expenses;
        double income;

        public MainWindow()
        {
            InitializeComponent();
            income = 0;
            expenses = 0;
            TextBlock_Income.Text = "0";
            TextBlock_Expenses.Text = "0";
            TextBlock_Budget.Text = "0";
            TextBox_Sum.Text = "0";
        }
        private void Button_AddExpenses_Click(object sender, RoutedEventArgs e)
        {
            expenses += Convert.ToDouble(TextBox_Sum.Text);
            TextBox_Sum.Text = "0";
            Budget();
        }
        private void Button_AddIncome_Click(object sender, RoutedEventArgs e)
        {
            income += Convert.ToDouble(TextBox_Sum.Text);
            TextBox_Sum.Text = "0";
            Budget();
        }
        private void Budget()
        {
            TextBlock_Budget.Text = (income - expenses).ToString();
            TextBlock_Income.Text = income.ToString();
            TextBlock_Expenses.Text = expenses.ToString();
        }
    }
}
